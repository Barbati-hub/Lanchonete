using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Business;
using DataBase;
using Estoque = Business.Estoque;

namespace Lanchonete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            var estoques = new Estoque()
            {
                Codigo = TxtCodigoDeBarras.Text,
                Descricao = TxtDescricao.Text,
                Unidade = Convert.ToInt32(TxtValorUnit.Text),
                ValorDeCompra = Convert.ToDecimal(TxtValorDeCompra.Text),
                QtdMax = Convert.ToInt32(TxtQtdMax.Text),
                QtdMin = Convert.ToInt32(TxtQtdMin.Text),
                Porcentagem = Convert.ToInt32(TxtPorcentagem.Text),
                Categoria = CbxCategoria.Text

            };

            estoques.SalvarEtoque();
            MessageBox.Show(TxtDescricao.Text + "Cadastrado com Sucesso!");
            DgvItemCadastrado.DataSource = Estoque.EstoqueLista();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DgvItemCadastrado.DataSource = Estoque.EstoqueLista();
        }
    }
}

