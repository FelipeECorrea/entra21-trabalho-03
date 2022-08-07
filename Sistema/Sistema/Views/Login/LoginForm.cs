using Sistema.Service;
using Sistema.Views.Login;
using System;
using System.Windows.Forms;

namespace Sistema.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            textBoxEmail.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cadastrar = new CadastrarForm();
            cadastrar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.AcessarProg(textBoxEmail.Text, textBoxSenha.Text);

            if (controle.validar)
            {
                MessageBox.Show("Seja Bem Vindo","Entrando...",MessageBoxButtons.OK,MessageBoxIcon.Information);
                var abrirMenu = new MenuPrincipalForm();
                abrirMenu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Login não encontrado, Verifique E-mail e Senha", "ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBoxSenha.Text = "";
                textBoxSenha.Focus();
            }
        }
    }
}
