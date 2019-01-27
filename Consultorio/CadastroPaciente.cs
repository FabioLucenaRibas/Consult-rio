using Consultorio.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class CadastroPaciente : Form
    {
        public CadastroPaciente()
        {
            InitializeComponent();
        }

        private void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
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
                    MessageBox.Show("Sua busca não retornou resultados!");
                }
            }
        }
    }
}
