namespace Sistema.Views.Jogadores
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(58, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nickname:";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(12, 63);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(32, 13);
            this.labelPais.TabIndex = 2;
            this.labelPais.Text = "País:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(12, 116);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(72, 13);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Data Criação:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 25);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(12, 79);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(100, 20);
            this.textBoxPais.TabIndex = 6;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(190, 291);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(190, 9);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 8;
            this.buttonApagar.Text = "Excluir";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(271, 291);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(271, 9);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // CadastroTimesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 326);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "CadastroTimesForm";
            this.Text = "CadastroJogadoresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonSair;
    }
}