using Biblioteca.ClassesBasicas;
using Consultorio.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            consultarPacientes();
            limpar();
        }


        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validarConsulta();
                preencherFiltro();
                List<Consulta> resultado = new Service1Client().Consultar(filtro).ToList();
                gridAtendimento.Items.Clear();
                if (resultado.Any())
                {
                    foreach (Consulta item in resultado)
                    {
                        ListViewItem itListView = gridAtendimento.Items.Add("");
                        itListView.SubItems.Add(formatarDataHora(item.DataConsulta));
                        itListView.SubItems.Add(item.Paciente.Nome);
                        itListView.SubItems.Add(Convert.ToString(item.Paciente.Cpf));
                        itListView.SubItems.Add(Convert.ToString(item.Paciente.Rg));
                        itListView.SubItems.Add(Convert.ToString(item.Paciente.Telefone));
                        itListView.SubItems.Add(formatarData(item.Paciente.Date));
                        itListView.SubItems.Add(item.Tratamento.Nome);
                        itListView.SubItems.Add(item.Situacao.Descricao);
                    }

                    carregarTreeView(resultado);
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

        private void validarConsulta()
        {
            if (DateTime.Compare(dataInicio.Value, dataFim.Value) > 0)
            {
                throw new Exception("'Data' inicial maior que a 'Data' final");
            }


            if (tb_Nome.Text.Length > 0 && tb_Nome.Text.Length < 3)
            {
                throw new Exception("Você deve informar ao menos 3 caracteres para pesquisar por nome do paciente.");
            }

            if (radioButtonCPF.Checked && !isValidCPF(tb_RG_CPF.Text))
            {
                throw new Exception("CPF invalido.");
            }
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            filtro = new ConsultaFiltro();
            gridAtendimento.Items.Clear();
            treeViewConsultaSimplificada.Nodes.Clear();
            tb_Nome.Text = "";
            tb_RG_CPF.Text = "";
            radioButtonRG.Checked = true;
            radioButtonCPF.Checked = false;
            dataInicio.Value = DateTime.Now;
            dataFim.Value = DateTime.Now;
        }

        private void preencherFiltro()
        {
            filtro = new ConsultaFiltro();
            filtro.DataInicio = dataInicio.Value;
            filtro.DataFim = dataFim.Value;
            filtro.NomePaciente = tb_Nome.Text;
            filtro.Cpf = radioButtonCPF.Checked;

            String retorno = Regex.Replace(tb_RG_CPF.Text, "[^0-9,]", "");
            if (!retorno.Equals(""))
            {
            filtro.RgCpf = Convert.ToInt64(retorno);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           date_time = DateTime.Now;
           lb_date_time.Text = "Data : " + date_time.ToLongDateString() + "  Hora: " + date_time.ToLongTimeString();
        }

        public static bool isValidCPF(String CPF)
        {
            int[] mt1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mt2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string TempCPF;
            string Digito;
            int soma;
            int resto;

            CPF = CPF.Trim();
            CPF = Regex.Replace(CPF, "[^0-9,]", "");

            if (CPF.Length != 11)
                return false;

            TempCPF = CPF.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = resto.ToString();
            TempCPF = TempCPF + Digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(TempCPF[i].ToString()) * mt2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            Digito = Digito + resto.ToString();

            return CPF.EndsWith(Digito);
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Paciente pFiltro = new Paciente();
                pFiltro.Nome = txt_Search.Text;
                montarGrid(new Service1Client().ConsultarPaciente(pFiltro).ToList());
            }
        }

        private void consultarPacientes()
        {
            montarGrid(new Service1Client().ConsultarPaciente(new Paciente()).ToList());
        }

        private void montarGrid(List<Paciente> resultado)
        {
            materialListView1.Items.Clear();
            foreach (Paciente item2 in resultado)
            {
                ListViewItem itListView = materialListView1.Items.Add("");
                itListView.SubItems.Add(item2.Nome);
                itListView.SubItems.Add(Convert.ToString(item2.Cpf));
                itListView.SubItems.Add(Convert.ToString(item2.Rg));
                itListView.SubItems.Add(Convert.ToString(item2.Telefone));
                itListView.SubItems.Add(formatarData(item2.Date));
                itListView.SubItems.Add(item2.Logradouro);
                itListView.SubItems.Add(Convert.ToString(item2.Numero));
                itListView.SubItems.Add(item2.Complemento);
                itListView.SubItems.Add(item2.Estado);
                itListView.SubItems.Add(item2.Cidade);
                itListView.SubItems.Add(item2.Bairro);
                itListView.SubItems.Add(Convert.ToString(item2.Cep));
                itListView.SubItems.Add("");
            }
        }


        private String formatarDataHora(DateTime dataHora)
        {
            return String.Format("{0:g}", dataHora);
        }

        private String formatarData(DateTime dataHora)
        {
            return String.Format("{0:d}", dataHora);
        }

        private String formatarHora(DateTime dataHora)
        {
            return String.Format("{0:t}", dataHora);
        }

       

        private void bt_Sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvedor: Fábio Lucena Ribas\nLinkedIn: fabiolucenaribas", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tb_RG_CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonCPF.Checked && char.IsNumber(e.KeyChar) == true)
            {
                switch (tb_RG_CPF.TextLength)
                {
                    case 0:
                        tb_RG_CPF.Text = "";
                        break;
                    case 3:
                        tb_RG_CPF.Text = tb_RG_CPF.Text + ".";
                        tb_RG_CPF.SelectionStart = 5;
                        break;
                    case 7:
                        tb_RG_CPF.Text = tb_RG_CPF.Text + ".";
                        tb_RG_CPF.SelectionStart = 9;
                        break;
                    case 11:
                        tb_RG_CPF.Text = tb_RG_CPF.Text + "-";
                        tb_RG_CPF.SelectionStart = 13;
                        break;
                }
            }
        }

        private void carregarTreeView(List<Consulta> resultado)
        {
            treeViewConsultaSimplificada.Nodes.Clear();

            String data = string.Empty;
            TreeView rootView = treeViewConsultaSimplificada;
            TreeNode rootNode = null;
            foreach (Consulta item in resultado)
            {
                if (data.Equals(formatarData(item.DataConsulta)))
                {
                    rootNode.Nodes.Add(formatarHora(item.DataConsulta) + " - " + item.Paciente.Nome);
                }
                else
                {
                    data = formatarData(item.DataConsulta);
                    rootNode = rootView.Nodes.Add(data);
                    rootNode.Expand();
                    TreeNode paciente = rootNode.Nodes.Add(formatarHora(item.DataConsulta) + " - " + item.Paciente.Nome);
                }
                
            }


        }

        private void bt_Cadastrar_Paciente_Click(object sender, EventArgs e)
        {
            new CadastroPaciente().Show();
        }
    }
}
