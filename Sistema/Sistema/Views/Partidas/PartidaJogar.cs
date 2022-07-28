using System;
using System.Windows.Forms;

namespace Sistema.Views.Partidas
{
    public partial class PartidaJogar : Form
    {
        public PartidaJogar()
        {
            InitializeComponent();
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("csgo.exe");
        }
    }
}
