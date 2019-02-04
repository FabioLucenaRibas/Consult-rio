using Biblioteca.ClassesBasicas;
using Biblioteca.Negocio;
using Consultorio.ServiceReference1;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class Atendimento : Form
    {
        private DateTime date_time;
        public ConsultaFiltro filtro;

        public Atendimento()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ConsultarPacientes();
            Limpar();
        }


        private void Bt_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarConsulta();
                PreencherFiltro();
                List<Consulta> resultado = new Service1Client().Consultar(filtro).ToList();
                gridAtendimento.Items.Clear();
                if (resultado.Any())
                {
                    foreach (Consulta item in resultado)
                    {
                        ListViewItem itListView = gridAtendimento.Items.Add("");
                        itListView.SubItems.Add(SiteUtil.formatarDataHora(item.DataConsulta));
                        itListView.SubItems.Add(item.Paciente.Nome);
                        itListView.SubItems.Add(SiteUtil.formatarCPF(item.Paciente.Cpf));
                        itListView.SubItems.Add(SiteUtil.formatarTelefone(item.Paciente.Telefone));
                        itListView.SubItems.Add(SiteUtil.formatarData(item.Paciente.Date));
                        itListView.SubItems.Add(item.Tratamento.Nome);
                        itListView.SubItems.Add(item.Situacao.Descricao);
                    }

                    CarregarTreeView(resultado);
                }
                else
                {
                    throw new Exception("Não existem dados para essa pesquisa.");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ValidarConsulta()
        {
            if (DateTime.Compare(dataInicio.Value, dataFim.Value) > 0)
            {
                throw new Exception("'Data' inicial maior que a 'Data' final");
            }

            if (tb_Nome.Text.Length > 0 && tb_Nome.Text.Length < 3)
            {
                throw new Exception("Você deve informar ao menos 3 caracteres para pesquisar por nome do paciente.");
            }

            if (!string.Empty.Equals(tb_CPF.Text) && !SiteUtil.isValidCPF(tb_CPF.Text))
            {
                throw new Exception("CPF invalido.");
            }
        }

        private void PreencherFiltro()
        {
            filtro = new ConsultaFiltro
            {
                DataInicio = dataInicio.Value,
                DataFim = dataFim.Value,
                NomePaciente = tb_Nome.Text
            };

            String retorno = SiteUtil.removerCaracteresEspecial(tb_CPF.Text);
            if (!retorno.Equals(""))
            {
                filtro.Cpf = Convert.ToInt64(retorno);
            }
        }

        private void Bt_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            filtro = new ConsultaFiltro();
            gridAtendimento.Items.Clear();
            treeViewConsultaSimplificada.Nodes.Clear();
            tb_Nome.Text = "";
            tb_CPF.Text = "";
            dataInicio.Value = DateTime.Now;
            dataFim.Value = DateTime.Now;
        }

        private void CarregarTreeView(List<Consulta> resultado)
        {
            treeViewConsultaSimplificada.Nodes.Clear();

            String data = string.Empty;
            TreeView rootView = treeViewConsultaSimplificada;
            TreeNode rootNode = null;
            foreach (Consulta item in resultado)
            {
                if (data.Equals(SiteUtil.formatarData(item.DataConsulta)))
                {
                    rootNode.Nodes.Add(SiteUtil.formatarHora(item.DataConsulta) + " - " + item.Paciente.Nome);
                }
                else
                {
                    data = SiteUtil.formatarData(item.DataConsulta);
                    rootNode = rootView.Nodes.Add(data);
                    rootNode.Expand();
                    TreeNode paciente = rootNode.Nodes.Add(SiteUtil.formatarHora(item.DataConsulta) + " - " + item.Paciente.Nome);
                }
                
            }


        }

        private void Bt_Cadastrar_Paciente_Click(object sender, EventArgs e)
        {
            CadastroPaciente formCadastroPaciente = new CadastroPaciente
            {
                Owner = this
            };
            formCadastroPaciente.Show();
        }

        private void Txt_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatarCPF_KeyPress(tb_CPF, e);
        }

        private void Txt_CPF_Leave(object sender, EventArgs e)
        {
            FormatarCPF_Leave(tb_CPF);
        }


        // PACIENTE
        private void Txt_Nome_Paciente_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultarPacientePorParametro();
            }
        }

        private void TxtCPF_Paciente_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultarPacientePorParametro();
            }
        }

        private void TxtCPF_Paciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatarCPF_KeyPress(txtCPF_Paciente_Search, e);
        }

        private void TxtCPF_Paciente_Leave(object sender, EventArgs e)
        {
            FormatarCPF_Leave(txtCPF_Paciente_Search);
        }

        private void ConsultarPacientePorParametro()
        {
            Paciente pFiltro = new Paciente
            {
                Nome = txt_Nome_Paciente_Search.Text
            };
            String retorno = SiteUtil.removerCaracteresEspecial(txtCPF_Paciente_Search.Text);
            if (!retorno.Equals(""))
            {
                pFiltro.Cpf = Convert.ToInt64(retorno);
            }
            MontarGrid(new Service1Client().ConsultarPaciente(pFiltro).ToList());
        }

        public void ConsultarPacientes()
        {
            MontarGrid(new Service1Client().ConsultarPaciente(new Paciente()).ToList());
        }

        private void MontarGrid(List<Paciente> resultado)
        {
            materialListView1.Items.Clear();
            foreach (Paciente item2 in resultado)
            {
                ListViewItem itListView = materialListView1.Items.Add("");
                itListView.SubItems.Add(item2.Nome);
                itListView.SubItems.Add(SiteUtil.formatarCPF(item2.Cpf));
                itListView.SubItems.Add(SiteUtil.formatarTelefone(item2.Telefone));
                itListView.SubItems.Add(SiteUtil.obterDescricaoEnum(item2.Sexo));
                itListView.SubItems.Add(SiteUtil.formatarData(item2.Date));
                itListView.SubItems.Add(SiteUtil.formatarCEP(item2.Cep));
                itListView.SubItems.Add(item2.Logradouro);
                if (!0L.Equals(item2.Numero))
                {
                    itListView.SubItems.Add(Convert.ToString(item2.Numero));
                }
                else
                {
                    itListView.SubItems.Add("");
                }
                itListView.SubItems.Add(item2.Complemento);
                itListView.SubItems.Add(item2.Estado);
                itListView.SubItems.Add(item2.Cidade);
                itListView.SubItems.Add(item2.Bairro);
                itListView.SubItems.Add("");
            }
        }

        private void materialListView1_DoubleClick(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 1)
            {
                Paciente pFiltro = new Paciente();
                String retorno = SiteUtil.removerCaracteresEspecial(materialListView1.SelectedItems[0].SubItems[2].Text);
                if (!retorno.Equals(""))
                {
                    pFiltro.Cpf = Convert.ToInt64(retorno);
                }
                Paciente resultado = new Service1Client().ConsultarPaciente(pFiltro).ToList()[0];
                DetalhePaciente formDetalhePaciente = new DetalhePaciente(resultado)
                {
                    Owner = this
                };
                formDetalhePaciente.Show();
            }
        }

        // COMUM
        private void Timer1_Tick(object sender, EventArgs e)
        {
            date_time = DateTime.Now;
            lb_date_time.Text = "Data : " + date_time.ToLongDateString() + "  Hora: " + date_time.ToLongTimeString();
        }

        private void Bt_Sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvedor: Fábio Lucena Ribas\nLinkedIn: fabiolucenaribas", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void FormatarCPF_KeyPress(MaterialSingleLineTextField campoCPF, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (campoCPF.TextLength)
                {
                    case 0:
                        campoCPF.Text = "";
                        break;
                    case 3:
                        campoCPF.Text = campoCPF.Text + ".";
                        campoCPF.SelectionStart = 5;
                        break;
                    case 7:
                        campoCPF.Text = campoCPF.Text + ".";
                        campoCPF.SelectionStart = 9;
                        break;
                    case 11:
                        campoCPF.Text = campoCPF.Text + "-";
                        campoCPF.SelectionStart = 13;
                        break;
                }
            }
        }

        private void FormatarCPF_Leave(MaterialSingleLineTextField campoCPF)
        {
            if (!14.Equals(campoCPF.TextLength) && !11.Equals(campoCPF.TextLength) && !10.Equals(campoCPF.TextLength))
            {
                campoCPF.Text = "";
            }
            else
            {
                campoCPF.Text = SiteUtil.formatarCPF(campoCPF.Text);
            }
        }
    }
}
