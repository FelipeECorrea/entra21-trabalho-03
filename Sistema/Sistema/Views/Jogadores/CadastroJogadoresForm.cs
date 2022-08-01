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


        private void textBoxNick_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//using Sistema.Models;
//using Sistema.Service;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Sistema.Views.Times
//{
//    public partial class CadastroJogadoresForm : Form
//    {
//        internal int _idEdicao = -1;
//        public CadastroJogadoresForm()
//        {
//            InitializeComponent();
//        }

//        public CadastroJogadoresForm(Jogador jogador) : this()
//        {
//            _idEdicao = jogador.Id;

//            textBoxTime.Text = jogador.Time;
//            textBoxNick.Text = jogador.Nick;
//            textBoxEMAIL.Text = jogador.Email;
//            textBoxSenha.Text = jogador.Senha;

//        }

//        private void buttonSalvar_Click(object sender, EventArgs e)
//        {
//            var nick = textBoxNick.Text.Trim();
//            var email = textBoxEMAIL.Text.Trim();
//            var senha = textBoxSenha.Text.Trim();
//            var time = textBoxTime.Text.Trim();

//            var jogador = new Jogador();
//            jogador.Nick = nick;
//            jogador.Email = email;
//            jogador.Senha = senha;
//            jogador.Time = time;

//            var jogadorService = new JogadorService();

//            if (_idEdicao == -1)
//            {
//                jogadorService.Cadastrar(jogador);

//                MessageBox.Show("Jogador cadastrado com sucesso!");

//                Close();

//                return;
//            }

//            private string ValidarPatente()
//            {
//                var selectPatente = "";
//                if (radioButtonPrata.Checked)
//                {
//                    selectPatente = "Prata";
//                }
//                else if (radioButtonOuro.Checked)
//                {
//                    selectPatente = "Ouro";
//                }
//                else if (radioButtonAK.Checked)
//                {
//                    selectPatente = "AK";
//                }
//                else if (radioButtonXerife.Checked)
//                {
//                    selectPatente = "Xerife";
//                }
//                else if (radioButtonAguia.Checked)
//                {
//                    selectPatente = "Águia";
//                }
//                else if (radioButtonGlobal.Checked)
//                {
//                    selectPatente = "Global";
//                }

//                return selectPatente;
//            }

//        }
//    }
//}