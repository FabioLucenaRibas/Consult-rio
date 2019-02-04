using Biblioteca.ClassesBasicas;
using Biblioteca.Negocio;
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
    public partial class DetalhePaciente : Form
    {
        public Paciente paciente;

        public DetalhePaciente(Paciente pPaciente)
        {
            InitializeComponent();
            paciente = pPaciente;
            CarregarInformacoesPaciente();
        }

        private void CarregarInformacoesPaciente()
        {
            Txt_Nome.Text = paciente.Nome;
            Txt_Cpf.Text = SiteUtil.formatarCPF(paciente.Cpf);
            Txt_Telefone.Text = SiteUtil.formatarTelefone(paciente.Telefone);
            Dt_DataNascimento.Value = paciente.Date;
            if (Sexo.FEMININO.Equals(paciente.Sexo))
            {
                Rb_Feminino.Checked = true;
                Rb_Masculino.Checked = false;
            }
            Txt_Cep.Text = SiteUtil.formatarCEP(paciente.Cep);
            Txt_Logradouro.Text = paciente.Logradouro;
            Txt_Complemento.Text = paciente.Complemento;
            Txt_Estado.Text = paciente.Estado;
            Txt_Cidade.Text = paciente.Cidade;
            Txt_Bairro.Text = paciente.Bairro;
            if (!0L.Equals(paciente.Numero))
            {
                Txt_Numero.Text = Convert.ToString(paciente.Numero);
            }
            else
            {
                Txt_Numero.Text = "";
            }
        }
    }
}
