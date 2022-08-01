namespace Sistema.Views.Partidas
{
    partial class PartidaListagemForm
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
            this.buttonMapas = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.comboBoxTime1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTime2 = new System.Windows.Forms.ComboBox();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.labelVs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMapas
            // 
            this.buttonMapas.Location = new System.Drawing.Point(449, 393);
            this.buttonMapas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMapas.Name = "buttonMapas";
            this.buttonMapas.Size = new System.Drawing.Size(275, 106);
            this.buttonMapas.TabIndex = 3;
            this.buttonMapas.Text = "Mapas";
            this.buttonMapas.UseVisualStyleBackColor = true;
            this.buttonMapas.Click += new System.EventHandler(this.buttonMapas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnPartida});
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(407, 484);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.MinimumWidth = 6;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            this.ColumnCodigo.Width = 125;
            // 
            // ColumnPartida
            // 
            this.ColumnPartida.HeaderText = "Partida";
            this.ColumnPartida.MinimumWidth = 6;
            this.ColumnPartida.Name = "ColumnPartida";
            this.ColumnPartida.ReadOnly = true;
            this.ColumnPartida.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 373);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha os mapas para iniciar";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(449, 219);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(275, 44);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Cadastrar Partida";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // comboBoxTime1
            // 
            this.comboBoxTime1.DisplayMember = "Nome";
            this.comboBoxTime1.FormattingEnabled = true;
            this.comboBoxTime1.Location = new System.Drawing.Point(449, 36);
            this.comboBoxTime1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTime1.Name = "comboBoxTime1";
            this.comboBoxTime1.Size = new System.Drawing.Size(273, 24);
            this.comboBoxTime1.TabIndex = 6;
            // 
            // comboBoxTime2
            // 
            this.comboBoxTime2.DisplayMember = "Nome";
            this.comboBoxTime2.FormattingEnabled = true;
            this.comboBoxTime2.Location = new System.Drawing.Point(449, 161);
            this.comboBoxTime2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTime2.Name = "comboBoxTime2";
            this.comboBoxTime2.Size = new System.Drawing.Size(273, 24);
            this.comboBoxTime2.TabIndex = 6;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(449, 271);
            this.buttonApagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(275, 48);
            this.buttonApagar.TabIndex = 5;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Location = new System.Drawing.Point(445, 16);
            this.labelTime1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(48, 16);
            this.labelTime1.TabIndex = 7;
            this.labelTime1.Text = "Time 1";
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Location = new System.Drawing.Point(445, 142);
            this.labelTime2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(48, 16);
            this.labelTime2.TabIndex = 7;
            this.labelTime2.Text = "Time 2";
            // 
            // labelVs
            // 
            this.labelVs.AutoSize = true;
            this.labelVs.Location = new System.Drawing.Point(575, 101);
            this.labelVs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVs.Name = "labelVs";
            this.labelVs.Size = new System.Drawing.Size(25, 16);
            this.labelVs.TabIndex = 7;
            this.labelVs.Text = "VS";
            // 
            // PartidaListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 513);
            this.Controls.Add(this.labelVs);
            this.Controls.Add(this.labelTime2);
            this.Controls.Add(this.labelTime1);
            this.Controls.Add(this.comboBoxTime2);
            this.Controls.Add(this.comboBoxTime1);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMapas);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PartidaListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Partidas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMapas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ComboBox comboBoxTime1;
        private System.Windows.Forms.ComboBox comboBoxTime2;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Label labelVs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPartida;
    }
}