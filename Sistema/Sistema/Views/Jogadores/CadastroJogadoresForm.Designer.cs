namespace Sistema.Views.Times
{
    partial class CadastroJogadoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroJogadoresForm));
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelPatente = new System.Windows.Forms.Label();
            this.radioButtonPrata = new System.Windows.Forms.RadioButton();
            this.radioButtonOuro = new System.Windows.Forms.RadioButton();
            this.radioButtonAK = new System.Windows.Forms.RadioButton();
            this.radioButtonXerife = new System.Windows.Forms.RadioButton();
            this.radioButtonAguia = new System.Windows.Forms.RadioButton();
            this.radioButtonGlobal = new System.Windows.Forms.RadioButton();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.panelConteudoIII = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(28, 132);
            this.textBoxEMAIL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(254, 26);
            this.textBoxEMAIL.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelEmail.Location = new System.Drawing.Point(24, 112);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 20);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nickname:";
            // 
            // textBoxNick
            // 
            this.textBoxNick.Location = new System.Drawing.Point(28, 66);
            this.textBoxNick.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(254, 26);
            this.textBoxNick.TabIndex = 3;
            this.textBoxNick.TextChanged += new System.EventHandler(this.textBoxNick_TextChanged);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(28, 194);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(254, 26);
            this.textBoxSenha.TabIndex = 4;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelSenha.Location = new System.Drawing.Point(24, 174);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(54, 20);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha:";
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelPatente.Location = new System.Drawing.Point(23, 276);
            this.labelPatente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(64, 20);
            this.labelPatente.TabIndex = 6;
            this.labelPatente.Text = "Patente:";
            // 
            // radioButtonPrata
            // 
            this.radioButtonPrata.AutoSize = true;
            this.radioButtonPrata.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonPrata.Location = new System.Drawing.Point(27, 306);
            this.radioButtonPrata.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPrata.Name = "radioButtonPrata";
            this.radioButtonPrata.Size = new System.Drawing.Size(65, 24);
            this.radioButtonPrata.TabIndex = 7;
            this.radioButtonPrata.TabStop = true;
            this.radioButtonPrata.Text = "Prata";
            this.radioButtonPrata.UseVisualStyleBackColor = false;
            // 
            // radioButtonOuro
            // 
            this.radioButtonOuro.AutoSize = true;
            this.radioButtonOuro.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonOuro.Location = new System.Drawing.Point(27, 346);
            this.radioButtonOuro.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOuro.Name = "radioButtonOuro";
            this.radioButtonOuro.Size = new System.Drawing.Size(64, 24);
            this.radioButtonOuro.TabIndex = 8;
            this.radioButtonOuro.TabStop = true;
            this.radioButtonOuro.Text = "Ouro";
            this.radioButtonOuro.UseVisualStyleBackColor = false;
            // 
            // radioButtonAK
            // 
            this.radioButtonAK.AutoSize = true;
            this.radioButtonAK.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAK.Location = new System.Drawing.Point(27, 385);
            this.radioButtonAK.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAK.Name = "radioButtonAK";
            this.radioButtonAK.Size = new System.Drawing.Size(49, 24);
            this.radioButtonAK.TabIndex = 9;
            this.radioButtonAK.TabStop = true;
            this.radioButtonAK.Text = "AK";
            this.radioButtonAK.UseVisualStyleBackColor = false;
            // 
            // radioButtonXerife
            // 
            this.radioButtonXerife.AutoSize = true;
            this.radioButtonXerife.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonXerife.Location = new System.Drawing.Point(27, 426);
            this.radioButtonXerife.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonXerife.Name = "radioButtonXerife";
            this.radioButtonXerife.Size = new System.Drawing.Size(69, 24);
            this.radioButtonXerife.TabIndex = 10;
            this.radioButtonXerife.TabStop = true;
            this.radioButtonXerife.Text = "Xerife";
            this.radioButtonXerife.UseVisualStyleBackColor = false;
            // 
            // radioButtonAguia
            // 
            this.radioButtonAguia.AutoSize = true;
            this.radioButtonAguia.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAguia.Location = new System.Drawing.Point(27, 468);
            this.radioButtonAguia.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAguia.Name = "radioButtonAguia";
            this.radioButtonAguia.Size = new System.Drawing.Size(70, 24);
            this.radioButtonAguia.TabIndex = 11;
            this.radioButtonAguia.TabStop = true;
            this.radioButtonAguia.Text = "Águia";
            this.radioButtonAguia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonAguia.UseVisualStyleBackColor = false;
            // 
            // radioButtonGlobal
            // 
            this.radioButtonGlobal.AutoSize = true;
            this.radioButtonGlobal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonGlobal.Location = new System.Drawing.Point(27, 507);
            this.radioButtonGlobal.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonGlobal.Name = "radioButtonGlobal";
            this.radioButtonGlobal.Size = new System.Drawing.Size(74, 24);
            this.radioButtonGlobal.TabIndex = 12;
            this.radioButtonGlobal.TabStop = true;
            this.radioButtonGlobal.Text = "Global";
            this.radioButtonGlobal.UseVisualStyleBackColor = false;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(268, 522);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(116, 44);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelTime.Location = new System.Drawing.Point(131, 276);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(45, 20);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "Time:";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(134, 303);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(148, 26);
            this.textBoxTime.TabIndex = 15;
            // 
            // panelConteudoIII
            // 
            this.panelConteudoIII.Location = new System.Drawing.Point(437, 36);
            this.panelConteudoIII.Margin = new System.Windows.Forms.Padding(2);
            this.panelConteudoIII.Name = "panelConteudoIII";
            this.panelConteudoIII.Size = new System.Drawing.Size(601, 530);
            this.panelConteudoIII.TabIndex = 20;
            // 
            // CadastroJogadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 596);
            this.ControlBox = false;
            this.Controls.Add(this.panelConteudoIII);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.radioButtonGlobal);
            this.Controls.Add(this.radioButtonAguia);
            this.Controls.Add(this.radioButtonXerife);
            this.Controls.Add(this.radioButtonAK);
            this.Controls.Add(this.radioButtonOuro);
            this.Controls.Add(this.radioButtonPrata);
            this.Controls.Add(this.labelPatente);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxNick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEMAIL);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroJogadoresForm";
            this.Text = "CadastroJogadorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNick;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelPatente;
        private System.Windows.Forms.RadioButton radioButtonPrata;
        private System.Windows.Forms.RadioButton radioButtonOuro;
        private System.Windows.Forms.RadioButton radioButtonAK;
        private System.Windows.Forms.RadioButton radioButtonXerife;
        private System.Windows.Forms.RadioButton radioButtonAguia;
        private System.Windows.Forms.RadioButton radioButtonGlobal;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Panel panelConteudoIII;
    }
}