using Sistema.Models;
using Sistema.Service;
using System;
using System.Windows.Forms;

namespace Sistema.Views.Times
{
    public partial class CadastroJogadoresForm : Form
    {
        private JogadorService _jogadorService;
        internal int _idEdicao = -1;
        public CadastroJogadoresForm()
        {
            InitializeComponent();

            _jogadorService = new JogadorService();

            PreencherDataGridViewComJogadores();

            PreencherComboboxTime();

            _idEdicao = -1;
        }

        public CadastroJogadoresForm(Jogador jogador) : this()
        {
            _idEdicao = jogador.Id;

            textBoxNick.Text = jogador.Nick;
            textBoxEmail.Text = jogador.Email;
            textBoxSenha.Text = jogador.Senha;

            ValidarPatenteSelecionada();
        }

        private string ValidarPatenteSelecionada()
        {
            var patente = "";
            if (radioButtonPrata.Checked)
            {
                patente = "Prata";
            }
            if (radioButtonOuro.Checked)
            {
                patente = "Ouro";
            }
            if (radioButtonAK.Checked)
            {
                patente = "Ak";
            }
            if (radioButtonXerife.Checked)
            {
                patente = "Xerife";
            }
            if (radioButtonAguia.Checked)
            {
                patente = "Aguia";
            }
            if (radioButtonGlobal.Checked)
            {
                patente = "Global";
            }

            return patente;
        }

        private void PreencherComboboxTime()
        {
            var timeService = new TimeService();

            var times = timeService.ObterTodos();

            for (int i = 0; i < times.Count; i++)
            {
                var time = times[i];

                comboBoxTimes.Items.Add(time);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxTimes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um time");
                return;
            }

            var times = comboBoxTimes.SelectedItem as Time;

            var jogador = new Jogador();
            jogador.Time = times;

            var jogadorService = new JogadorService();

            if (_idEdicao == -1)
            {
                jogadorService.Cadastrar(jogador);

                MessageBox.Show("Jogador Cadastrado com sucesso!");
                Close();
            }
            else
            {
                jogadorService.Editar(jogador);

                MessageBox.Show("Jogador alterado com sucesso!");
                Close();
            }
        }

        private void PreencherDataGridViewComJogadores()
        {
            var jogadores = _jogadorService.ObterTodos();
            dataGridViewJogadores.Rows.Clear();

            for (int i = 0; i < jogadores.Count; i++)
            {
                var jogador = jogadores[i];

                dataGridViewJogadores.Rows.Add(new object[]
                {
                    jogador.Id,
                    jogador.Nick,
                    jogador.Email,
                    jogador.Senha,
                    jogador.Patente,
                    jogador.Time.Id,
                    jogador.Time.Nome});
            }
        }


        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewJogadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum jogador");
                return;
            }
            var linhaSelecionada = dataGridViewJogadores.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var jogador = _jogadorService.ObterPorId(id);
            var grupoCadastroEdicaoForm = new CadastroJogadoresForm(jogador);
            grupoCadastroEdicaoForm.ShowDialog();
            PreencherDataGridViewComJogadores();
        }
    }
}