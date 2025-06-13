namespace WindowsFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnPontos = new System.Windows.Forms.Button();
            this.btnEncomendas = new System.Windows.Forms.Button();
            this.btnCardapio = new System.Windows.Forms.Button();
            this.btnLoja = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaibamais = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.btnCarrinho);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnPontos);
            this.panel1.Controls.Add(this.btnEncomendas);
            this.panel1.Controls.Add(this.btnCardapio);
            this.panel1.Controls.Add(this.btnLoja);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 117);
            this.panel1.TabIndex = 0;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btnCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrinho.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnCarrinho.Image = ((System.Drawing.Image)(resources.GetObject("btnCarrinho.Image")));
            this.btnCarrinho.Location = new System.Drawing.Point(744, 11);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(49, 46);
            this.btnCarrinho.TabIndex = 6;
            this.btnCarrinho.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(693, 9);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(49, 46);
            this.btnUser.TabIndex = 5;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnPontos
            // 
            this.btnPontos.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btnPontos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPontos.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPontos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnPontos.Location = new System.Drawing.Point(497, 3);
            this.btnPontos.Name = "btnPontos";
            this.btnPontos.Size = new System.Drawing.Size(98, 30);
            this.btnPontos.TabIndex = 4;
            this.btnPontos.Text = "Pontos";
            this.btnPontos.UseVisualStyleBackColor = true;
            // 
            // btnEncomendas
            // 
            this.btnEncomendas.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btnEncomendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncomendas.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncomendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnEncomendas.Location = new System.Drawing.Point(384, 3);
            this.btnEncomendas.Name = "btnEncomendas";
            this.btnEncomendas.Size = new System.Drawing.Size(111, 30);
            this.btnEncomendas.TabIndex = 3;
            this.btnEncomendas.Text = "Encomendas";
            this.btnEncomendas.UseVisualStyleBackColor = true;
            // 
            // btnCardapio
            // 
            this.btnCardapio.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btnCardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCardapio.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardapio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnCardapio.Location = new System.Drawing.Point(287, 3);
            this.btnCardapio.Name = "btnCardapio";
            this.btnCardapio.Size = new System.Drawing.Size(98, 30);
            this.btnCardapio.TabIndex = 2;
            this.btnCardapio.Text = "Cardápio";
            this.btnCardapio.UseVisualStyleBackColor = true;
            // 
            // btnLoja
            // 
            this.btnLoja.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btnLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoja.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnLoja.Location = new System.Drawing.Point(190, 3);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(98, 30);
            this.btnLoja.TabIndex = 1;
            this.btnLoja.Text = "Loja";
            this.btnLoja.UseVisualStyleBackColor = true;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Schadow BT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(226, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descubra o Sabor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(315, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Café de Qualidade";
            // 
            // btnSaibamais
            // 
            this.btnSaibamais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(107)))), ((int)(((byte)(85)))));
            this.btnSaibamais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaibamais.BackgroundImage")));
            this.btnSaibamais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaibamais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaibamais.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaibamais.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaibamais.Location = new System.Drawing.Point(334, 310);
            this.btnSaibamais.Name = "btnSaibamais";
            this.btnSaibamais.Size = new System.Drawing.Size(123, 30);
            this.btnSaibamais.TabIndex = 2;
            this.btnSaibamais.Text = "Saiba Mais";
            this.btnSaibamais.UseVisualStyleBackColor = false;
            this.btnSaibamais.Click += new System.EventHandler(this.btnSaibamais_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaibamais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaibamais;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Button btnCardapio;
        private System.Windows.Forms.Button btnEncomendas;
        private System.Windows.Forms.Button btnPontos;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCarrinho;
    }
}

