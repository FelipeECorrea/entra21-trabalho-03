using Sistema.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Views.Login
{
    public partial class CadastrarForm : Form
    {
        public CadastrarForm()
        {
            InitializeComponent();
            textBoxUsuario.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNewCadastro_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string aviso = controle.Cadastrar(textBoxUsuario.Text, textBoxEmail.Text, textBoxSenha.Text, textBoxCSenha.Text);

            if (controle.validar)
            {
                MessageBox.Show(aviso, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.aviso);
            }
        }
    }
}
