namespace WindowsFormsApp1
{
    partial class Loja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loja));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnadd3 = new System.Windows.Forms.Button();
            this.btnadd2 = new System.Windows.Forms.Button();
            this.btnadd1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Schadow BT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(70)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(44, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(70)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(49, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione o tipo de produto que deseja comprar:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(70)))), ((int)(((byte)(52)))));
            this.radioButton1.Location = new System.Drawing.Point(53, 155);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Torras";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(70)))), ((int)(((byte)(52)))));
            this.radioButton2.Location = new System.Drawing.Point(143, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(136, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Canecas e Copos";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(70)))), ((int)(((byte)(52)))));
            this.radioButton3.Location = new System.Drawing.Point(294, 155);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 20);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Merchandise";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btnCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrinho.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnCarrinho.Image = ((System.Drawing.Image)(resources.GetObject("btnCarrinho.Image")));
            this.btnCarrinho.Location = new System.Drawing.Point(743, 8);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(49, 46);
            this.btnCarrinho.TabIndex = 7;
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click_1);
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Source Code Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(66)))), ((int)(((byte)(51)))));
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(692, 7);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(49, 46);
            this.btnUser.TabIndex = 8;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnadd3);
            this.panel1.Controls.Add(this.btnadd2);
            this.panel1.Controls.Add(this.btnadd1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 243);
            this.panel1.TabIndex = 9;
            // 
            // btnadd3
            // 
            this.btnadd3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(82)))));
            this.btnadd3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(73)))));
            this.btnadd3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnadd3.Location = new System.Drawing.Point(573, 173);
            this.btnadd3.Name = "btnadd3";
            this.btnadd3.Size = new System.Drawing.Size(170, 38);
            this.btnadd3.TabIndex = 15;
            this.btnadd3.Text = "Adicionar ao Carrinho";
            this.btnadd3.UseVisualStyleBackColor = false;
            // 
            // btnadd2
            // 
            this.btnadd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(82)))));
            this.btnadd2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(73)))));
            this.btnadd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnadd2.Location = new System.Drawing.Point(314, 173);
            this.btnadd2.Name = "btnadd2";
            this.btnadd2.Size = new System.Drawing.Size(170, 38);
            this.btnadd2.TabIndex = 14;
            this.btnadd2.Text = "Adicionar ao Carrinho";
            this.btnadd2.UseVisualStyleBackColor = false;
            // 
            // btnadd1
            // 
            this.btnadd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(99)))), ((int)(((byte)(82)))));
            this.btnadd1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(73)))));
            this.btnadd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnadd1.Location = new System.Drawing.Point(55, 173);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(170, 38);
            this.btnadd1.TabIndex = 13;
            this.btnadd1.Text = "Adicionar ao Carrinho";
            this.btnadd1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(553, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 139);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(296, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 139);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 139);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Loja";
            this.Text = "Loja";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnadd3;
        private System.Windows.Forms.Button btnadd2;
        private System.Windows.Forms.Button btnadd1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}