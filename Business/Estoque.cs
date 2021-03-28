using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public  class Estoque
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int Unidade { get; set; }
        public decimal ValorDeCompra { get; set; }
        public int QtdMax { get; set; }
        public int QtdMin { get; set; }
        public int Porcentagem { get; set; }
        public string Categoria { get; set; }

        public void SalvarEtoque()
        {
            if (string.IsNullOrEmpty(this.Descricao))
            {
                throw new Exception("A Descrição não pode ser vazia!");
            }
            this.Id = new DataBase.Estoque().EstoqueSalvar(this.Codigo, this.Descricao, this.Unidade, this.ValorDeCompra, this.QtdMax, this.QtdMin, this.Porcentagem, this.Categoria);
            
    }



        public static List<Estoque> EstoqueLista()
        {
            return EstoqueLista(string.Empty);
        }

        public static List<Estoque> EstoqueLista(string Codigo)
        {
            var estoques = new List<Estoque>();

            DataTable dados = new DataBase.Estoque().EstoqueLista(Codigo);

            for (var i = 0; i < dados.Rows.Count; i++)
            {
                estoques.Add(new Estoque()
                {
                    Id = Convert.ToInt32(dados.Rows[i]["id"]),
                    Codigo = dados.Rows[i]["Codigo"].ToString(),
                    Descricao = dados.Rows[i]["Descricao"].ToString(),
                    Unidade = Convert.ToInt32(dados.Rows[i]["Unidade"]),
                    ValorDeCompra = Convert.ToDecimal(dados.Rows[i]["ValorDeCompra"]),
                    QtdMax = Convert.ToInt32(dados.Rows[i]["QtdMax"]),
                    QtdMin = Convert.ToInt32(dados.Rows[i]["QtdMin"]),
                    Porcentagem = Convert.ToInt32(dados.Rows[i]["Porcentagem"]),
                    Categoria = dados.Rows[i]["Categoria"].ToString()
                });
            }

            return estoques;
        }

    }

}