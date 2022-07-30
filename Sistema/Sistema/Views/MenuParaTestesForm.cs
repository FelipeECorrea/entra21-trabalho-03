using Sistema.Views.Grupos;
using Sistema.Views.Partidas;
using System;
using System.Windows.Forms;

namespace Sistema.Views
{
    public partial class MenuParaTestesForm : Form
    {
        public MenuParaTestesForm()
        {
            InitializeComponent();
        }

        private void buttonGrupos_Click(object sender, EventArgs e)
        {
            var grupoForm = new GrupoListagemForm();
            grupoForm.ShowDialog();
        }

        private void buttonPartidas_Click(object sender, EventArgs e)
        {
            var partidaForm = new PartidaListagemForm();
            partidaForm.ShowDialog();
        }
    }
}
