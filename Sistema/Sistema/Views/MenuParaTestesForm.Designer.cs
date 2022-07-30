namespace Sistema.Views
{
    partial class MenuParaTestesForm
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
            this.buttonGrupos = new System.Windows.Forms.Button();
            this.buttonPartidas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGrupos
            // 
            this.buttonGrupos.Location = new System.Drawing.Point(7, 12);
            this.buttonGrupos.Name = "buttonGrupos";
            this.buttonGrupos.Size = new System.Drawing.Size(163, 143);
            this.buttonGrupos.TabIndex = 0;
            this.buttonGrupos.Text = "Grupos";
            this.buttonGrupos.UseVisualStyleBackColor = true;
            this.buttonGrupos.Click += new System.EventHandler(this.buttonGrupos_Click);
            // 
            // buttonPartidas
            // 
            this.buttonPartidas.Location = new System.Drawing.Point(176, 12);
            this.buttonPartidas.Name = "buttonPartidas";
            this.buttonPartidas.Size = new System.Drawing.Size(163, 143);
            this.buttonPartidas.TabIndex = 0;
            this.buttonPartidas.Text = "Partidas";
            this.buttonPartidas.UseVisualStyleBackColor = true;
            this.buttonPartidas.Click += new System.EventHandler(this.buttonPartidas_Click);
            // 
            // MenuParaTestesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 164);
            this.Controls.Add(this.buttonPartidas);
            this.Controls.Add(this.buttonGrupos);
            this.Name = "MenuParaTestesForm";
            this.Text = "MenuParaTestesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGrupos;
        private System.Windows.Forms.Button buttonPartidas;
    }
}