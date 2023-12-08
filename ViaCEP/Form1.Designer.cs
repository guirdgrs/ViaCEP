namespace ViaCEP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.pibInfo = new System.Windows.Forms.PictureBox();
            this.txbDDD = new System.Windows.Forms.TextBox();
            this.txbUF = new System.Windows.Forms.TextBox();
            this.txbLocalidade = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.lblDDD = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.btnFavoritar = new System.Windows.Forms.PictureBox();
            this.lblFav = new System.Windows.Forms.Label();
            this.dgvFavoritos = new System.Windows.Forms.DataGridView();
            this.btnRemoverSelecionado = new System.Windows.Forms.Button();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibBuscar = new System.Windows.Forms.PictureBox();
            this.grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFavoritar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCep
            // 
            this.txbCep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCep.Location = new System.Drawing.Point(253, 59);
            this.txbCep.Margin = new System.Windows.Forms.Padding(4);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(226, 27);
            this.txbCep.TabIndex = 0;
            this.txbCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCep_KeyPress);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(83, 59);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(140, 25);
            this.lblCep.TabIndex = 1;
            this.lblCep.Text = "Digite o CEP:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(253, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(226, 30);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.pibInfo);
            this.grbInfo.Controls.Add(this.txbDDD);
            this.grbInfo.Controls.Add(this.txbUF);
            this.grbInfo.Controls.Add(this.txbLocalidade);
            this.grbInfo.Controls.Add(this.txbBairro);
            this.grbInfo.Controls.Add(this.txbComplemento);
            this.grbInfo.Controls.Add(this.txbLogradouro);
            this.grbInfo.Controls.Add(this.lblDDD);
            this.grbInfo.Controls.Add(this.lblUF);
            this.grbInfo.Controls.Add(this.lblLocalidade);
            this.grbInfo.Controls.Add(this.lblBairro);
            this.grbInfo.Controls.Add(this.lblComplemento);
            this.grbInfo.Controls.Add(this.lblLogradouro);
            this.grbInfo.Enabled = false;
            this.grbInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfo.Location = new System.Drawing.Point(12, 202);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(623, 187);
            this.grbInfo.TabIndex = 4;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Informações";
            // 
            // pibInfo
            // 
            this.pibInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibInfo.Enabled = false;
            this.pibInfo.Image = ((System.Drawing.Image)(resources.GetObject("pibInfo.Image")));
            this.pibInfo.Location = new System.Drawing.Point(120, 0);
            this.pibInfo.Name = "pibInfo";
            this.pibInfo.Size = new System.Drawing.Size(30, 29);
            this.pibInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibInfo.TabIndex = 11;
            this.pibInfo.TabStop = false;
            // 
            // txbDDD
            // 
            this.txbDDD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDDD.Location = new System.Drawing.Point(502, 114);
            this.txbDDD.Name = "txbDDD";
            this.txbDDD.ReadOnly = true;
            this.txbDDD.Size = new System.Drawing.Size(100, 27);
            this.txbDDD.TabIndex = 11;
            // 
            // txbUF
            // 
            this.txbUF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUF.Location = new System.Drawing.Point(502, 47);
            this.txbUF.Name = "txbUF";
            this.txbUF.ReadOnly = true;
            this.txbUF.Size = new System.Drawing.Size(100, 27);
            this.txbUF.TabIndex = 10;
            // 
            // txbLocalidade
            // 
            this.txbLocalidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLocalidade.Location = new System.Drawing.Point(144, 138);
            this.txbLocalidade.Name = "txbLocalidade";
            this.txbLocalidade.ReadOnly = true;
            this.txbLocalidade.Size = new System.Drawing.Size(238, 23);
            this.txbLocalidade.TabIndex = 9;
            // 
            // txbBairro
            // 
            this.txbBairro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBairro.Location = new System.Drawing.Point(144, 104);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.ReadOnly = true;
            this.txbBairro.Size = new System.Drawing.Size(238, 23);
            this.txbBairro.TabIndex = 8;
            // 
            // txbComplemento
            // 
            this.txbComplemento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComplemento.Location = new System.Drawing.Point(144, 75);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.ReadOnly = true;
            this.txbComplemento.Size = new System.Drawing.Size(238, 23);
            this.txbComplemento.TabIndex = 7;
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogradouro.Location = new System.Drawing.Point(144, 40);
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.ReadOnly = true;
            this.txbLogradouro.Size = new System.Drawing.Size(238, 23);
            this.txbLogradouro.TabIndex = 6;
            // 
            // lblDDD
            // 
            this.lblDDD.AutoSize = true;
            this.lblDDD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDD.Location = new System.Drawing.Point(454, 118);
            this.lblDDD.Name = "lblDDD";
            this.lblDDD.Size = new System.Drawing.Size(42, 19);
            this.lblDDD.TabIndex = 5;
            this.lblDDD.Text = "DDD";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUF.Location = new System.Drawing.Point(467, 51);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(27, 19);
            this.lblUF.TabIndex = 4;
            this.lblUF.Text = "UF";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidade.Location = new System.Drawing.Point(24, 142);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(98, 19);
            this.lblLocalidade.TabIndex = 3;
            this.lblLocalidade.Text = "Localidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(50, 108);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(53, 19);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(16, 79);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(122, 19);
            this.lblComplemento.TabIndex = 1;
            this.lblComplemento.Text = "Complemento";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogradouro.Location = new System.Drawing.Point(23, 44);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(99, 19);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // btnFavoritar
            // 
            this.btnFavoritar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFavoritar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavoritar.Enabled = false;
            this.btnFavoritar.Image = ((System.Drawing.Image)(resources.GetObject("btnFavoritar.Image")));
            this.btnFavoritar.Location = new System.Drawing.Point(485, 170);
            this.btnFavoritar.Name = "btnFavoritar";
            this.btnFavoritar.Size = new System.Drawing.Size(30, 29);
            this.btnFavoritar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFavoritar.TabIndex = 5;
            this.btnFavoritar.TabStop = false;
            this.btnFavoritar.Visible = false;
            this.btnFavoritar.Click += new System.EventHandler(this.btnFavoritar_Click);
            // 
            // lblFav
            // 
            this.lblFav.AutoSize = true;
            this.lblFav.Enabled = false;
            this.lblFav.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFav.Location = new System.Drawing.Point(249, 170);
            this.lblFav.Name = "lblFav";
            this.lblFav.Size = new System.Drawing.Size(222, 23);
            this.lblFav.TabIndex = 6;
            this.lblFav.Text = "Adicionar aos favoritos";
            this.lblFav.Visible = false;
            // 
            // dgvFavoritos
            // 
            this.dgvFavoritos.AllowUserToAddRows = false;
            this.dgvFavoritos.AllowUserToDeleteRows = false;
            this.dgvFavoritos.AllowUserToResizeColumns = false;
            this.dgvFavoritos.AllowUserToResizeRows = false;
            this.dgvFavoritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFavoritos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvFavoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavoritos.Location = new System.Drawing.Point(77, 444);
            this.dgvFavoritos.Name = "dgvFavoritos";
            this.dgvFavoritos.Size = new System.Drawing.Size(499, 199);
            this.dgvFavoritos.TabIndex = 7;
            this.dgvFavoritos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFavoritos_CellClick);
            // 
            // btnRemoverSelecionado
            // 
            this.btnRemoverSelecionado.Enabled = false;
            this.btnRemoverSelecionado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverSelecionado.Location = new System.Drawing.Point(77, 659);
            this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
            this.btnRemoverSelecionado.Size = new System.Drawing.Size(226, 30);
            this.btnRemoverSelecionado.TabIndex = 8;
            this.btnRemoverSelecionado.Text = "Remover Selecionado";
            this.btnRemoverSelecionado.UseVisualStyleBackColor = true;
            this.btnRemoverSelecionado.Click += new System.EventHandler(this.btnRemoverSelecionado_Click);
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.Enabled = false;
            this.btnApagarTudo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarTudo.Location = new System.Drawing.Point(350, 659);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(226, 30);
            this.btnApagarTudo.TabIndex = 9;
            this.btnApagarTudo.Text = "Apagar Tudo";
            this.btnApagarTudo.UseVisualStyleBackColor = true;
            this.btnApagarTudo.Click += new System.EventHandler(this.btnApagarTudo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(269, 416);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(101, 25);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Favoritos";
            // 
            // pibBuscar
            // 
            this.pibBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibBuscar.Enabled = false;
            this.pibBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pibBuscar.Image")));
            this.pibBuscar.Location = new System.Drawing.Point(485, 107);
            this.pibBuscar.Name = "pibBuscar";
            this.pibBuscar.Size = new System.Drawing.Size(30, 29);
            this.pibBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibBuscar.TabIndex = 12;
            this.pibBuscar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 713);
            this.Controls.Add(this.pibBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnApagarTudo);
            this.Controls.Add(this.btnRemoverSelecionado);
            this.Controls.Add(this.dgvFavoritos);
            this.Controls.Add(this.lblFav);
            this.Controls.Add(this.btnFavoritar);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txbCep);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViaCEP";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFavoritar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.TextBox txbDDD;
        private System.Windows.Forms.TextBox txbUF;
        private System.Windows.Forms.TextBox txbLocalidade;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.Label lblDDD;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.PictureBox btnFavoritar;
        private System.Windows.Forms.Label lblFav;
        private System.Windows.Forms.DataGridView dgvFavoritos;
        private System.Windows.Forms.Button btnRemoverSelecionado;
        private System.Windows.Forms.Button btnApagarTudo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibInfo;
        private System.Windows.Forms.PictureBox pibBuscar;
    }
}

