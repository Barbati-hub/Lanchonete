
namespace Lanchonete
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.TxtQtdMax = new System.Windows.Forms.TextBox();
            this.TxtQtdMin = new System.Windows.Forms.TextBox();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.TxtValorDeCompra = new System.Windows.Forms.TextBox();
            this.TxtPorcentagem = new System.Windows.Forms.TextBox();
            this.TxtValorUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvItemCadastrado = new System.Windows.Forms.DataGridView();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItemCadastrado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtValorUnit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtPorcentagem);
            this.panel1.Controls.Add(this.TxtValorDeCompra);
            this.panel1.Controls.Add(this.CbxCategoria);
            this.panel1.Controls.Add(this.TxtQtdMin);
            this.panel1.Controls.Add(this.TxtQtdMax);
            this.panel1.Controls.Add(this.TxtDescricao);
            this.panel1.Controls.Add(this.TxtCodigoDeBarras);
            this.panel1.Controls.Add(this.TxtId);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 213);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CÓDIGO DE BARRAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIÇÃO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "VALOR DE COMPRA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "QTDE MAX.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "QTDE MIN.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "PORCENTAGEM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CATEGORIA";
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.SystemColors.Info;
            this.TxtId.Location = new System.Drawing.Point(61, 22);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(64, 20);
            this.TxtId.TabIndex = 9;
            // 
            // TxtCodigoDeBarras
            // 
            this.TxtCodigoDeBarras.BackColor = System.Drawing.SystemColors.Info;
            this.TxtCodigoDeBarras.Location = new System.Drawing.Point(61, 61);
            this.TxtCodigoDeBarras.Name = "TxtCodigoDeBarras";
            this.TxtCodigoDeBarras.Size = new System.Drawing.Size(232, 20);
            this.TxtCodigoDeBarras.TabIndex = 10;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.BackColor = System.Drawing.SystemColors.Info;
            this.TxtDescricao.Location = new System.Drawing.Point(61, 100);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(344, 20);
            this.TxtDescricao.TabIndex = 11;
            // 
            // TxtQtdMax
            // 
            this.TxtQtdMax.BackColor = System.Drawing.SystemColors.Info;
            this.TxtQtdMax.Location = new System.Drawing.Point(61, 138);
            this.TxtQtdMax.Name = "TxtQtdMax";
            this.TxtQtdMax.Size = new System.Drawing.Size(64, 20);
            this.TxtQtdMax.TabIndex = 12;
            // 
            // TxtQtdMin
            // 
            this.TxtQtdMin.BackColor = System.Drawing.SystemColors.Info;
            this.TxtQtdMin.Location = new System.Drawing.Point(147, 138);
            this.TxtQtdMin.Name = "TxtQtdMin";
            this.TxtQtdMin.Size = new System.Drawing.Size(64, 20);
            this.TxtQtdMin.TabIndex = 13;
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.BackColor = System.Drawing.SystemColors.Info;
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(261, 138);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(144, 21);
            this.CbxCategoria.TabIndex = 14;
            // 
            // TxtValorDeCompra
            // 
            this.TxtValorDeCompra.BackColor = System.Drawing.SystemColors.Info;
            this.TxtValorDeCompra.Location = new System.Drawing.Point(61, 187);
            this.TxtValorDeCompra.Name = "TxtValorDeCompra";
            this.TxtValorDeCompra.Size = new System.Drawing.Size(107, 20);
            this.TxtValorDeCompra.TabIndex = 15;
            // 
            // TxtPorcentagem
            // 
            this.TxtPorcentagem.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPorcentagem.Location = new System.Drawing.Point(186, 187);
            this.TxtPorcentagem.Name = "TxtPorcentagem";
            this.TxtPorcentagem.Size = new System.Drawing.Size(107, 20);
            this.TxtPorcentagem.TabIndex = 16;
            // 
            // TxtValorUnit
            // 
            this.TxtValorUnit.BackColor = System.Drawing.SystemColors.Info;
            this.TxtValorUnit.Location = new System.Drawing.Point(298, 187);
            this.TxtValorUnit.Name = "TxtValorUnit";
            this.TxtValorUnit.Size = new System.Drawing.Size(107, 20);
            this.TxtValorUnit.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "VALOR UNIT.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvItemCadastrado);
            this.groupBox1.Location = new System.Drawing.Point(5, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ITEM CADASTRADO";
            // 
            // DgvItemCadastrado
            // 
            this.DgvItemCadastrado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvItemCadastrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItemCadastrado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvItemCadastrado.GridColor = System.Drawing.SystemColors.Control;
            this.DgvItemCadastrado.Location = new System.Drawing.Point(3, 16);
            this.DgvItemCadastrado.Name = "DgvItemCadastrado";
            this.DgvItemCadastrado.Size = new System.Drawing.Size(610, 151);
            this.DgvItemCadastrado.TabIndex = 0;
            // 
            // BtnRemover
            // 
            this.BtnRemover.BackColor = System.Drawing.Color.Red;
            this.BtnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemover.FlatAppearance.BorderSize = 0;
            this.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemover.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemover.ForeColor = System.Drawing.Color.White;
            this.BtnRemover.Location = new System.Drawing.Point(517, 399);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(101, 47);
            this.BtnRemover.TabIndex = 2;
            this.BtnRemover.Text = "REMOVER";
            this.BtnRemover.UseVisualStyleBackColor = false;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlterar.FlatAppearance.BorderSize = 0;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.Color.White;
            this.BtnAlterar.Location = new System.Drawing.Point(410, 399);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(101, 47);
            this.BtnAlterar.TabIndex = 3;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Green;
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(303, 399);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(101, 47);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "CADASTRAR";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTOQUE SIMPLES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItemCadastrado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtValorUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPorcentagem;
        private System.Windows.Forms.TextBox TxtValorDeCompra;
        private System.Windows.Forms.ComboBox CbxCategoria;
        private System.Windows.Forms.TextBox TxtQtdMin;
        private System.Windows.Forms.TextBox TxtQtdMax;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.TextBox TxtCodigoDeBarras;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvItemCadastrado;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnSalvar;
    }
}

