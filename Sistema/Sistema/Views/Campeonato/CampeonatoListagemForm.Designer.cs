namespace Sistema.Views.Campeonato
{
    partial class CampeonatoListagemForm
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
            this.dataGridViewListaCampeonato = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModoStreaming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPremio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCampeonato)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListaCampeonato
            // 
            this.dataGridViewListaCampeonato.AllowUserToAddRows = false;
            this.dataGridViewListaCampeonato.AllowUserToDeleteRows = false;
            this.dataGridViewListaCampeonato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaCampeonato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnStilo,
            this.ColumnModoStreaming,
            this.ColumnDataIn,
            this.ColumnDataFim,
            this.ColumnCat,
            this.ColumnPremio});
            this.dataGridViewListaCampeonato.Location = new System.Drawing.Point(12, 135);
            this.dataGridViewListaCampeonato.Name = "dataGridViewListaCampeonato";
            this.dataGridViewListaCampeonato.ReadOnly = true;
            this.dataGridViewListaCampeonato.RowHeadersWidth = 51;
            this.dataGridViewListaCampeonato.RowTemplate.Height = 24;
            this.dataGridViewListaCampeonato.Size = new System.Drawing.Size(1173, 506);
            this.dataGridViewListaCampeonato.TabIndex = 0;
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
            this.ColumnNome.HeaderText = "Nome Campeonato";
            this.ColumnNome.MinimumWidth = 6;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 170;
            // 
            // ColumnStilo
            // 
            this.ColumnStilo.HeaderText = "Estilo de Jogo";
            this.ColumnStilo.MinimumWidth = 6;
            this.ColumnStilo.Name = "ColumnStilo";
            this.ColumnStilo.ReadOnly = true;
            this.ColumnStilo.Width = 125;
            // 
            // ColumnModoStreaming
            // 
            this.ColumnModoStreaming.HeaderText = "Modo de Streaming";
            this.ColumnModoStreaming.MinimumWidth = 6;
            this.ColumnModoStreaming.Name = "ColumnModoStreaming";
            this.ColumnModoStreaming.ReadOnly = true;
            this.ColumnModoStreaming.Width = 170;
            // 
            // ColumnDataIn
            // 
            this.ColumnDataIn.HeaderText = "Data Inicio";
            this.ColumnDataIn.MinimumWidth = 6;
            this.ColumnDataIn.Name = "ColumnDataIn";
            this.ColumnDataIn.ReadOnly = true;
            this.ColumnDataIn.Width = 125;
            // 
            // ColumnDataFim
            // 
            this.ColumnDataFim.HeaderText = "Data Termino";
            this.ColumnDataFim.MinimumWidth = 6;
            this.ColumnDataFim.Name = "ColumnDataFim";
            this.ColumnDataFim.ReadOnly = true;
            this.ColumnDataFim.Width = 125;
            // 
            // ColumnCat
            // 
            this.ColumnCat.HeaderText = "Categoria Campeonato";
            this.ColumnCat.MinimumWidth = 6;
            this.ColumnCat.Name = "ColumnCat";
            this.ColumnCat.ReadOnly = true;
            this.ColumnCat.Width = 190;
            // 
            // ColumnPremio
            // 
            this.ColumnPremio.HeaderText = "Premiação";
            this.ColumnPremio.MinimumWidth = 6;
            this.ColumnPremio.Name = "ColumnPremio";
            this.ColumnPremio.ReadOnly = true;
            this.ColumnPremio.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1073, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 52);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "CAMPEONATOS CADASTRADOS";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1135, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CampeonatoListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewListaCampeonato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CampeonatoListagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CampeonatoListagemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCampeonato)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaCampeonato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModoStreaming;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPremio;
    }
}