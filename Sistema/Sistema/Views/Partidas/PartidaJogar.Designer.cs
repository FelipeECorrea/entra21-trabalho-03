namespace Sistema.Views.Partidas
{
    partial class PartidaJogar
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
            this.buttonJogar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMapa1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMapa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMapa3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJogar
            // 
            this.buttonJogar.Location = new System.Drawing.Point(635, 12);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(153, 250);
            this.buttonJogar.TabIndex = 6;
            this.buttonJogar.Text = "Jogar";
            this.buttonJogar.UseVisualStyleBackColor = true;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnPartida,
            this.ColumnMapa1,
            this.ColumnMapa2,
            this.ColumnMapa3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(607, 426);
            this.dataGridView1.TabIndex = 5;
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
            // ColumnMapa1
            // 
            this.ColumnMapa1.HeaderText = "Mapa 1";
            this.ColumnMapa1.Name = "ColumnMapa1";
            this.ColumnMapa1.ReadOnly = true;
            // 
            // ColumnMapa2
            // 
            this.ColumnMapa2.HeaderText = "Mapa 2";
            this.ColumnMapa2.Name = "ColumnMapa2";
            this.ColumnMapa2.ReadOnly = true;
            // 
            // ColumnMapa3
            // 
            this.ColumnMapa3.HeaderText = "Mapa 3";
            this.ColumnMapa3.Name = "ColumnMapa3";
            this.ColumnMapa3.ReadOnly = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(635, 334);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(153, 104);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // PartidaJogar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonJogar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PartidaJogar";
            this.Text = "Jogar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonJogar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMapa1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMapa2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMapa3;
        private System.Windows.Forms.Button buttonCancelar;
    }
}