using Sistema.Models;
using System;
using System.Windows.Forms;

namespace Sistema.Views.Times
{
    public partial class CadastroJogadoresForm : Form
    {
        internal int _idEdicao = -1;
        public CadastroJogadoresForm()
        {
            InitializeComponent();
        }

        public CadastroJogadoresForm(Time time) : this()
        {
            _idEdicao = time.Id;
            //text
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
