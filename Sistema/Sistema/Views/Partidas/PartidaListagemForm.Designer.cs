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
            this.ColumnTorneio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTransmissão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPremiacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMapas
            // 
            this.buttonMapas.Location = new System.Drawing.Point(635, 112);
            this.buttonMapas.Name = "buttonMapas";
            this.buttonMapas.Size = new System.Drawing.Size(153, 248);
            this.buttonMapas.TabIndex = 3;
            this.buttonMapas.Text = "Mapas";
            this.buttonMapas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnPartida,
            this.ColumnTorneio,
            this.ColumnTransmissão,
            this.ColumnPremiacao});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(607, 426);
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
            // ColumnTorneio
            // 
            this.ColumnTorneio.HeaderText = "Torneio";
            this.ColumnTorneio.Name = "ColumnTorneio";
            this.ColumnTorneio.ReadOnly = true;
            // 
            // ColumnTransmissão
            // 
            this.ColumnTransmissão.HeaderText = "Transmissão";
            this.ColumnTransmissão.Name = "ColumnTransmissão";
            this.ColumnTransmissão.ReadOnly = true;
            // 
            // ColumnPremiacao
            // 
            this.ColumnPremiacao.HeaderText = "Premiação";
            this.ColumnPremiacao.Name = "ColumnPremiacao";
            this.ColumnPremiacao.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha os mapas para iniciar";
            // 
            // PartidaListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMapas);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PartidaListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partidas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMapas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTorneio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransmissão;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPremiacao;
        private System.Windows.Forms.Label label1;
    }
}