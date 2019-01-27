using System;

namespace Biblioteca.ClassesBasicas
{
    public class ConsultaFiltro
    {
        private DateTime dataInicio = DateTime.Now;
        private DateTime dataFim = DateTime.Now;
        private String nomePaciente;
        private long rgCpf;
        private bool cpf;


        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }

        public String NomePaciente
        {
            get { return nomePaciente; }
            set { nomePaciente = value; }
        }

        public long RgCpf
        {
            get { return rgCpf; }
            set { rgCpf = value; }
        }

        public bool Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

    }
}
