namespace Sistema.Views.Times
{
    partial class TimesListagemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimesListagemForm));
            this.dataGridViewTimes = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNacionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelConteudoII = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTimes
            // 
            this.dataGridViewTimes.AllowUserToAddRows = false;
            this.dataGridViewTimes.AllowUserToDeleteRows = false;
            this.dataGridViewTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnNacionalidade,
            this.ColumnDataCriacao});
            this.dataGridViewTimes.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewTimes.Name = "dataGridViewTimes";
            this.dataGridViewTimes.ReadOnly = true;
            this.dataGridViewTimes.RowHeadersWidth = 51;
            this.dataGridViewTimes.RowTemplate.Height = 24;
            this.dataGridViewTimes.Size = new System.Drawing.Size(523, 552);
            this.dataGridViewTimes.TabIndex = 11;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 125;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 125;
            // 
            // ColumnNacionalidade
            // 
            this.ColumnNacionalidade.HeaderText = "Nacionalidade";
            this.ColumnNacionalidade.MinimumWidth = 6;
            this.ColumnNacionalidade.Name = "ColumnNacionalidade";
            this.ColumnNacionalidade.ReadOnly = true;
            this.ColumnNacionalidade.Width = 125;
            // 
            // ColumnDataCriacao
            // 
            this.ColumnDataCriacao.HeaderText = "Data Criacao";
            this.ColumnDataCriacao.MinimumWidth = 6;
            this.ColumnDataCriacao.Name = "ColumnDataCriacao";
            this.ColumnDataCriacao.ReadOnly = true;
            this.ColumnDataCriacao.Width = 125;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(542, 547);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(100, 67);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click_1);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(542, 90);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 67);
            this.buttonEditar.TabIndex = 14;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(542, 312);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(100, 67);
            this.buttonApagar.TabIndex = 13;
            this.buttonApagar.Text = "Excluir";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1077, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelConteudoII
            // 
            this.panelConteudoII.Location = new System.Drawing.Point(658, 38);
            this.panelConteudoII.Name = "panelConteudoII";
            this.panelConteudoII.Size = new System.Drawing.Size(449, 627);
            this.panelConteudoII.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Atualizar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimesListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelConteudoII);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dataGridViewTimes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimesListagemForm";
            this.Text = "TimesListagemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNacionalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataCriacao;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelConteudoII;
        private System.Windows.Forms.Button button1;
    }
}