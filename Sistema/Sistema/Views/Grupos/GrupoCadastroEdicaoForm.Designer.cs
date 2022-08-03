namespace Sistema.Views.Grupos
{
    partial class GrupoCadastroEdicaoForm
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
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.comboBoxTorneio = new System.Windows.Forms.ComboBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTorneio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DisplayMember = "Nome";
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(12, 51);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(300, 21);
            this.comboBoxTime.TabIndex = 0;
            // 
            // comboBoxTorneio
            // 
            this.comboBoxTorneio.DisplayMember = "Nome";
            this.comboBoxTorneio.FormattingEnabled = true;
            this.comboBoxTorneio.Location = new System.Drawing.Point(12, 143);
            this.comboBoxTorneio.Name = "comboBoxTorneio";
            this.comboBoxTorneio.Size = new System.Drawing.Size(300, 21);
            this.comboBoxTorneio.TabIndex = 0;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonSalvar.Location = new System.Drawing.Point(172, 193);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(140, 37);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonCancelar.Location = new System.Drawing.Point(12, 193);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(140, 37);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTime.Location = new System.Drawing.Point(147, 22);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time";
            // 
            // labelTorneio
            // 
            this.labelTorneio.AutoSize = true;
            this.labelTorneio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTorneio.Location = new System.Drawing.Point(141, 114);
            this.labelTorneio.Name = "labelTorneio";
            this.labelTorneio.Size = new System.Drawing.Size(43, 13);
            this.labelTorneio.TabIndex = 2;
            this.labelTorneio.Text = "Torneio";
            // 
            // GrupoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 249);
            this.Controls.Add(this.labelTorneio);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.comboBoxTorneio);
            this.Controls.Add(this.comboBoxTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrupoCadastroEdicaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro / Ediçao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.ComboBox comboBoxTorneio;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTorneio;
    }
}