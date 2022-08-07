namespace Sistema.Views.Transmissao
{
    partial class TransmissaoListagemForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeTransmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeComentarista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCampeonato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNomeTransmissao,
            this.ColumnNomeComentarista,
            this.ColumnPlataforma,
            this.ColumnIdioma,
            this.ColumnCampeonato});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(703, 611);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnNomeTransmissao
            // 
            this.ColumnNomeTransmissao.HeaderText = "Nome Transmissão";
            this.ColumnNomeTransmissao.MinimumWidth = 6;
            this.ColumnNomeTransmissao.Name = "ColumnNomeTransmissao";
            this.ColumnNomeTransmissao.ReadOnly = true;
            // 
            // ColumnNomeComentarista
            // 
            this.ColumnNomeComentarista.HeaderText = "Nome Comentarista";
            this.ColumnNomeComentarista.MinimumWidth = 6;
            this.ColumnNomeComentarista.Name = "ColumnNomeComentarista";
            this.ColumnNomeComentarista.ReadOnly = true;
            // 
            // ColumnPlataforma
            // 
            this.ColumnPlataforma.HeaderText = "Plataforma";
            this.ColumnPlataforma.MinimumWidth = 6;
            this.ColumnPlataforma.Name = "ColumnPlataforma";
            this.ColumnPlataforma.ReadOnly = true;
            // 
            // ColumnIdioma
            // 
            this.ColumnIdioma.HeaderText = "Idioma Transmissão";
            this.ColumnIdioma.MinimumWidth = 6;
            this.ColumnIdioma.Name = "ColumnIdioma";
            this.ColumnIdioma.ReadOnly = true;
            // 
            // ColumnCampeonato
            // 
            this.ColumnCampeonato.HeaderText = "Campeonato";
            this.ColumnCampeonato.MinimumWidth = 6;
            this.ColumnCampeonato.Name = "ColumnCampeonato";
            this.ColumnCampeonato.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(780, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 621);
            this.panel1.TabIndex = 1;
            // 
            // TransmissaoListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransmissaoListagemForm";
            this.Text = "TransmissaoListagemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeTransmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeComentarista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCampeonato;
        private System.Windows.Forms.Panel panel1;
    }
}