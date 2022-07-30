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
            this.buttonMapas.Location = new System.Drawing.Point(337, 319);
            this.buttonMapas.Name = "buttonMapas";
            this.buttonMapas.Size = new System.Drawing.Size(206, 86);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(305, 393);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            // 
            // ColumnPartida
            // 
            this.ColumnPartida.HeaderText = "Partida";
            this.ColumnPartida.Name = "ColumnPartida";
            this.ColumnPartida.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha os mapas para iniciar";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(337, 178);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(206, 36);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Cadastrar Partida";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // comboBoxTime1
            // 
            this.comboBoxTime1.DisplayMember = "Nome";
            this.comboBoxTime1.FormattingEnabled = true;
            this.comboBoxTime1.Location = new System.Drawing.Point(337, 29);
            this.comboBoxTime1.Name = "comboBoxTime1";
            this.comboBoxTime1.Size = new System.Drawing.Size(206, 21);
            this.comboBoxTime1.TabIndex = 6;
            // 
            // comboBoxTime2
            // 
            this.comboBoxTime2.DisplayMember = "Nome";
            this.comboBoxTime2.FormattingEnabled = true;
            this.comboBoxTime2.Location = new System.Drawing.Point(337, 131);
            this.comboBoxTime2.Name = "comboBoxTime2";
            this.comboBoxTime2.Size = new System.Drawing.Size(206, 21);
            this.comboBoxTime2.TabIndex = 6;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(337, 220);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(206, 39);
            this.buttonApagar.TabIndex = 5;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Location = new System.Drawing.Point(334, 13);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(39, 13);
            this.labelTime1.TabIndex = 7;
            this.labelTime1.Text = "Time 1";
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Location = new System.Drawing.Point(334, 115);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(39, 13);
            this.labelTime2.TabIndex = 7;
            this.labelTime2.Text = "Time 2";
            // 
            // labelVs
            // 
            this.labelVs.AutoSize = true;
            this.labelVs.Location = new System.Drawing.Point(431, 82);
            this.labelVs.Name = "labelVs";
            this.labelVs.Size = new System.Drawing.Size(21, 13);
            this.labelVs.TabIndex = 7;
            this.labelVs.Text = "VS";
            // 
            // PartidaListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 417);
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