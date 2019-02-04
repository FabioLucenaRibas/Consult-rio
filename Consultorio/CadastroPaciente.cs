using Biblioteca.ClassesBasicas;
using Biblioteca.Negocio;
using Consultorio.ServiceReference1;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class CadastroPaciente : Form
    {
        public Paciente pPaciente;

        public CadastroPaciente()
        {
            InitializeComponent();
        }

        private void TxtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultarEndereco();
            }
        }

        private void ConsultarEndereco()
        {
            if (10.Equals(txtCEP.TextLength) || 8.Equals(txtCEP.TextLength))
            {
                txtCEP.Text = SiteUtil.formatarCEP(txtCEP.Text);
                var modeloRetorno = new Service1Client().ConsultarCEP(txtCEP.Text);
                if (modeloRetorno.Resultado.Equals("1") || modeloRetorno.Resultado.Equals("2"))
                {
                    txt_Logradouro.Text = modeloRetorno.TipoLogradouro + " " + modeloRetorno.Logradouro;
                    txt_Bairro.Text = modeloRetorno.Bairro;
                    txt_Cidade.Text = modeloRetorno.Cidade;
                    txt_Estado.Text = modeloRetorno.UF;
                }
                else
                {
                    LimparEndereco();
                    MessageBox.Show("Sua busca não retornou resultados!");
                }
            }
            else
            {
                LimparEndereco();
            }

        }

        private void LimparEndereco()
        {
            txt_Logradouro.Text = string.Empty;
            txt_Bairro.Text = string.Empty;
            txt_Cidade.Text = string.Empty;
            txt_Estado.Text = string.Empty;
        }

        private void TxtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                   switch (txtCEP.TextLength)
                {
                   case 0:
                       txtCEP.Text = "";
                        break;
                    case 2:
                     txtCEP.Text = txtCEP.Text + ".";
                     txtCEP.SelectionStart = 4;
                      break;
                    case 6:
                     txtCEP.Text = txtCEP.Text + "-";
                     txtCEP.SelectionStart = 8;
                     break;
               }
            }
        }

        private void TxtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTelefone.TextLength)
                {
                    case 0:
                        txtTelefone.Text = "";
                        break;
                    case 1:
                        txtTelefone.Text =  "(" + txtTelefone.Text;
                        txtTelefone.SelectionStart = 3;
                        break;
                    case 3:
                        txtTelefone.Text = txtTelefone.Text + ") ";
                        txtTelefone.SelectionStart = 7;
                        break;
                    case 6:
                        txtTelefone.Text = txtTelefone.Text + ".";
                        txtTelefone.SelectionStart = 8;
                        break;
                    case 11:
                        txtTelefone.Text = txtTelefone.Text + "-";
                        txtTelefone.SelectionStart = 13;
                        break;
                }
            }
        }

        private void TxtCEP_Leave(object sender, EventArgs e)
        {
            ConsultarEndereco();
        }

        private void TxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCpf.TextLength)
                {
                    case 0:
                        txtCpf.Text = "";
                        break;
                    case 3:
                        txtCpf.Text = txtCpf.Text + ".";
                        txtCpf.SelectionStart = 5;
                        break;
                    case 7:
                        txtCpf.Text = txtCpf.Text + ".";
                        txtCpf.SelectionStart = 9;
                        break;
                    case 11:
                        txtCpf.Text = txtCpf.Text + "-";
                        txtCpf.SelectionStart = 13;
                        break;
                }
            }
        }

        private void TxtCpf_Leave(object sender, EventArgs e)
        {
            if (!14.Equals(txtCpf.TextLength) && !11.Equals(txtCpf.TextLength) && !10.Equals(txtCpf.TextLength))
            {
                txtCpf.Text = "";
            }
            else
            {
                txtCpf.Text = SiteUtil.formatarCPF(txtCpf.Text);
            }
        }

        private void Bt_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarInclusao();
                PreencherInclusao();
                new Service1Client().InserirPaciente(pPaciente);
                ((Atendimento)this.Owner).ConsultarPacientes();
                this.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ValidarInclusao()
        {
            
            if (string.Empty.Equals(txtNomePaciente.Text) || string.Empty.Equals(txtCpf.Text) || string.Empty.Equals(txtTelefone.Text) ||SiteUtil.formatarData(DateTime.Now).Equals(SiteUtil.formatarData(dataNascimento.Value)))
            {
                throw new Exception("Campos obrigatórios não preenchidos!");
            }

            if ( !SiteUtil.isValidCPF(txtCpf.Text))
            {
                throw new Exception("CPF invalido.");
            }

            if (!string.Empty.Equals(txt_Logradouro.Text) && string.Empty.Equals(txtNumero.Text))
            {
                throw new Exception("Favor informar um número para o endereço");
            }
        }

        private void PreencherInclusao()
        {
            pPaciente = new Paciente
            {
                Nome = txtNomePaciente.Text
            };
            String retornoCPF = SiteUtil.removerCaracteresEspecial(txtCpf.Text);
            if (!retornoCPF.Equals(""))
            {
                pPaciente.Cpf = Convert.ToInt64(retornoCPF);
            }

            String retornoTelefone = SiteUtil.removerCaracteresEspecial(txtTelefone.Text);
            if (!retornoTelefone.Equals(""))
            {
                pPaciente.Telefone = Convert.ToInt64(retornoTelefone);
            }

            pPaciente.Date = dataNascimento.Value;
            if (rb_feminino.Checked)
            {
                pPaciente.Sexo = Sexo.FEMININO;
            }
            else
            {
                pPaciente.Sexo = Sexo.MASCULINO;
            }

            pPaciente.Cep = Convert.ToInt64(SiteUtil.removerCaracteresEspecial(txtCEP.Text));
            pPaciente.Logradouro = txt_Logradouro.Text;
            pPaciente.Numero = Convert.ToInt64(txtNumero.Text);
            pPaciente.Complemento = txtComplemento.Text;
            pPaciente.Estado = txt_Estado.Text;
            pPaciente.Cidade = txt_Cidade.Text;
            pPaciente.Bairro = txt_Bairro.Text;
           
        }

        private void TxtTelefone_Leave(object sender, EventArgs e)
        {
            if (!16.Equals(txtTelefone.TextLength) && !11.Equals(txtTelefone.TextLength))
            {
                txtTelefone.Text = "";
            }
            else
            {
                txtTelefone.Text = SiteUtil.formatarTelefone(txtTelefone.Text);
            }
        }
    }
}
