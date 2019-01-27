using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Biblioteca.Dados
{
    public class DadosPaciente : Conexao
    {
        #region selecionando os registros da tabela
        public List<Paciente> Consultar(Paciente pFiltro)
        {
            List<Paciente> retorno = new List<Paciente>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                String sqlQuery = "SELECT CPF";
                sqlQuery += " ,RG";
                sqlQuery += " ,NOME";
                sqlQuery += " ,TELEFONE";
                sqlQuery += " ,DATANASCIMENTO";
                sqlQuery += " ,COALESCE (CIDADE, '') AS CIDADE";
                sqlQuery += " ,COALESCE (ESTADO, '') AS ESTADO";
                sqlQuery += " ,COALESCE (COMPLEMENTO, '') AS COMPLEMENTO";
                sqlQuery += " ,COALESCE (LOGRADOURO, '') AS LOGRADOURO";
                sqlQuery += " ,COALESCE (NUMERO, 0) AS NUMERO";
                sqlQuery += " ,COALESCE (BAIRRO, '') AS BAIRRO";
                sqlQuery += " ,COALESCE (CEP, 0) AS CEP";
                sqlQuery += " FROM PACIENTE";
                sqlQuery += " WHERE NOME LIKE '%"+ pFiltro .Nome + "%'";

                //sqlQuery += "";

                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Paciente paciente = new Paciente();
                    //acessando os valores das colunas do resultado
                    paciente.Nome = DbReader.GetString(DbReader.GetOrdinal("NOME"));
                    paciente.Rg = DbReader.GetInt64(DbReader.GetOrdinal("RG"));
                    paciente.Cpf = DbReader.GetInt64(DbReader.GetOrdinal("CPF"));
                    paciente.Telefone = DbReader.GetInt64(DbReader.GetOrdinal("TELEFONE"));
                    paciente.Date = DbReader.GetDateTime(DbReader.GetOrdinal("DATANASCIMENTO"));
                    paciente.Cidade = DbReader.GetString(DbReader.GetOrdinal("CIDADE"));
                    paciente.Estado = DbReader.GetString(DbReader.GetOrdinal("ESTADO"));
                    paciente.Complemento = DbReader.GetString(DbReader.GetOrdinal("COMPLEMENTO"));
                    paciente.Logradouro = DbReader.GetString(DbReader.GetOrdinal("LOGRADOURO"));
                    paciente.Numero = DbReader.GetInt64(DbReader.GetOrdinal("NUMERO"));
                    paciente.Bairro = DbReader.GetString(DbReader.GetOrdinal("BAIRRO"));
                    paciente.Cep = DbReader.GetInt32(DbReader.GetOrdinal("CEP"));
                    retorno.Add(paciente);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar " + ex.Message);
            }
            return retorno;
        }
        #endregion

        private String formatarData(DateTime data)
        {
           return String.Format("{0:d}", data);
        }
    }
}
