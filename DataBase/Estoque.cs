using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Estoque
    {
        private string connString = "";


        public Estoque()
        {
            connString = ConfigurationManager.ConnectionStrings["lanchoneteconexao"].ConnectionString;

        }

        public int EstoqueSalvar(string codigo, string descricao, int unidade, decimal valorDeCompra,
                                 int qtdMax, int qtdMin, int porcentagem, string categoria)
        {
            int id = 0;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "SalvarEstoque"; // Inserir Pessoa via Procedure
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@codigo", SqlDbType.VarChar);
                cmd.Parameters["@codigo"].Value = codigo;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = descricao;

                cmd.Parameters.Add("@unidade", SqlDbType.VarChar);
                cmd.Parameters["@unidade"].Value = unidade;

                cmd.Parameters.Add("@valorDeCompra", SqlDbType.VarChar);
                cmd.Parameters["@valorDeCompra"].Value = valorDeCompra;

                cmd.Parameters.Add("@qtdMax", SqlDbType.VarChar);
                cmd.Parameters["@qtdMax"].Value = qtdMax;

                cmd.Parameters.Add("@qtdMin", SqlDbType.VarChar);
                cmd.Parameters["@qtdMin"].Value = qtdMin;

                cmd.Parameters.Add("@porcentagem", SqlDbType.VarChar);
                cmd.Parameters["@porcentagem"].Value = porcentagem;

                cmd.Parameters.Add("@categoria", SqlDbType.VarChar);
                cmd.Parameters["@categoria"].Value = categoria;

                try
                {
                    conn.Open();
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return id;
        }


        public DataTable EstoqueLista(string codigo)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Estoque"; // Buscar Pessoa via Sql
                if (!string.IsNullOrEmpty(codigo))
                {
                    sql += " where nome like '%" + codigo + "%'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);




                try
                {
                    conn.Open();

                    using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                    {
                        a.Fill(table);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return table;


        }

    }
}

