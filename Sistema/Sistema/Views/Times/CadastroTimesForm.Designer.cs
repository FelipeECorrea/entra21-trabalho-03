﻿namespace Sistema.Views.Jogadores
{
    partial class CadastroTimesForm
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
            this.dateTimePickerDataCriacao = new System.Windows.Forms.DateTimePicker();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerDataCriacao
            // 
            this.dateTimePickerDataCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataCriacao.Location = new System.Drawing.Point(68, 204);
            this.dateTimePickerDataCriacao.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDataCriacao.Name = "dateTimePickerDataCriacao";
            this.dateTimePickerDataCriacao.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerDataCriacao.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(68, 38);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(100, 16);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome do Time:";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(68, 105);
            this.labelPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(99, 16);
            this.labelPais.TabIndex = 2;
            this.labelPais.Text = "Nacionalidade:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(65, 184);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(89, 16);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Data Criação:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(68, 58);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(265, 22);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(68, 124);
            this.textBoxPais.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(265, 22);
            this.textBoxPais.TabIndex = 6;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(92, 306);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(200, 47);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(165, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(165, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(150, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "*";
            // 
            // CadastroTimesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 449);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.dateTimePickerDataCriacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroTimesForm";
            this.Text = "CadastroTimesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDataCriacao;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}