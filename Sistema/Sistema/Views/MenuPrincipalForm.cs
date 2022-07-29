using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sistema.Views.Campeonato;

namespace Sistema.Views
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 70)
            {
                MenuVertical.Width = 220;
            }
            else
                MenuVertical.Width = 70;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxRestaurar.Visible = true;
            pictureBoxMinimizar.Visible = false;
        }

        private void pictureBoxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            pictureBoxRestaurar.Visible = false;
            pictureBoxMinimizar.Visible = true;
        }

        private void pictureBoxMinimizador_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEmPainel(object FormFilho)
        {
            if (this.panelConteudo.Controls.Count > 0)
                this.panelConteudo.Controls.RemoveAt(0);
            Form fh = FormFilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelConteudo.Controls.Add(fh);
            this.panelConteudo.Tag = fh;
            fh.Show();
        }

        private void buttonCadastroCamp_Click(object sender, EventArgs e)
        {
            AbrirFormEmPainel(new CampeonatoCadastroForm());
        }
    }
}
