namespace Sistema.Views.Transmissao
{
    partial class TransmissaoCadastroEdicaoForm
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
            this.textBoxNomeTransmissao = new System.Windows.Forms.TextBox();
            this.labelNameLive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeComentarista = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFacebook = new System.Windows.Forms.RadioButton();
            this.radioButtonTwitch = new System.Windows.Forms.RadioButton();
            this.radioButtonMimo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNomeTransmissao
            // 
            this.textBoxNomeTransmissao.Location = new System.Drawing.Point(50, 114);
            this.textBoxNomeTransmissao.Name = "textBoxNomeTransmissao";
            this.textBoxNomeTransmissao.Size = new System.Drawing.Size(306, 22);
            this.textBoxNomeTransmissao.TabIndex = 0;
            // 
            // labelNameLive
            // 
            this.labelNameLive.AutoSize = true;
            this.labelNameLive.Location = new System.Drawing.Point(35, 95);
            this.labelNameLive.Name = "labelNameLive";
            this.labelNameLive.Size = new System.Drawing.Size(145, 16);
            this.labelNameLive.TabIndex = 1;
            this.labelNameLive.Text = "Nome da Transmissão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome dos Comentaristas";
            // 
            // textBoxNomeComentarista
            // 
            this.textBoxNomeComentarista.Location = new System.Drawing.Point(50, 184);
            this.textBoxNomeComentarista.Name = "textBoxNomeComentarista";
            this.textBoxNomeComentarista.Size = new System.Drawing.Size(306, 22);
            this.textBoxNomeComentarista.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMimo);
            this.groupBox1.Controls.Add(this.radioButtonTwitch);
            this.groupBox1.Controls.Add(this.radioButtonFacebook);
            this.groupBox1.Location = new System.Drawing.Point(50, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 37);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFacebook
            // 
            this.radioButtonFacebook.AutoSize = true;
            this.radioButtonFacebook.Location = new System.Drawing.Point(12, 9);
            this.radioButtonFacebook.Name = "radioButtonFacebook";
            this.radioButtonFacebook.Size = new System.Drawing.Size(90, 20);
            this.radioButtonFacebook.TabIndex = 0;
            this.radioButtonFacebook.TabStop = true;
            this.radioButtonFacebook.Text = "Facebook";
            this.radioButtonFacebook.UseVisualStyleBackColor = true;
            // 
            // radioButtonTwitch
            // 
            this.radioButtonTwitch.AutoSize = true;
            this.radioButtonTwitch.Location = new System.Drawing.Point(108, 9);
            this.radioButtonTwitch.Name = "radioButtonTwitch";
            this.radioButtonTwitch.Size = new System.Drawing.Size(66, 20);
            this.radioButtonTwitch.TabIndex = 1;
            this.radioButtonTwitch.TabStop = true;
            this.radioButtonTwitch.Text = "Twitch";
            this.radioButtonTwitch.UseVisualStyleBackColor = true;
            // 
            // radioButtonMimo
            // 
            this.radioButtonMimo.AutoSize = true;
            this.radioButtonMimo.Location = new System.Drawing.Point(180, 9);
            this.radioButtonMimo.Name = "radioButtonMimo";
            this.radioButtonMimo.Size = new System.Drawing.Size(61, 20);
            this.radioButtonMimo.TabIndex = 2;
            this.radioButtonMimo.TabStop = true;
            this.radioButtonMimo.Text = "Mimo";
            this.radioButtonMimo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plataforme de Transmissão";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-- Selecione o Idioma --",
            "Português",
            "Inglês"});
            this.comboBox1.Location = new System.Drawing.Point(50, 347);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "-- Selecione o Idioma --";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Idioma Transmissão / Comentarista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecione o Camponato";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(50, 456);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(306, 24);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TransmissaoCadastroEdicaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 694);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomeComentarista);
            this.Controls.Add(this.labelNameLive);
            this.Controls.Add(this.textBoxNomeTransmissao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransmissaoCadastroEdicaoForm";
            this.Text = "TransmissaoCadastroEdicaoForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeTransmissao;
        private System.Windows.Forms.Label labelNameLive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeComentarista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMimo;
        private System.Windows.Forms.RadioButton radioButtonTwitch;
        private System.Windows.Forms.RadioButton radioButtonFacebook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}