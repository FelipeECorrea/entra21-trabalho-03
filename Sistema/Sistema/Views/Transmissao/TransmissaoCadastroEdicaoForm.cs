using Sistema.Database;
using Sistema.Models;
using Sistema.Service;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema.Views.Transmissao
{
    public partial class TransmissaoCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;
        public TransmissaoCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBoxCampeonatos();
            _idParaEditar = -1;
        }

        public TransmissaoCadastroEdicaoForm(Live transmissao)
        {
            _idParaEditar = transmissao.Id;
            textBoxNomeTransmissao.Text = transmissao.NomeLive;
            textBoxNomeComentarista.Text = transmissao.NomeNarrador;
            if (transmissao.Plataforma == "Facebook")
            {
                radioButtonFacebook.Checked = true;
            }
            else if (transmissao.Plataforma == "Twitch")
            {
                radioButtonTwitch.Checked = true;
            }
            else
            {
                radioButtonMimo.Checked = true;
            }

            if (transmissao.IdiomaTransmissao == "Portugues")
            {
                comboBoxIdioma.TabIndex = 0;
            }
            else if (transmissao.IdiomaTransmissao == "Ingles")
            {
                comboBoxIdioma.TabIndex = 1;
            }
            else
            {
                comboBoxIdioma.TabIndex = 2;
            }
            PreencherComboBoxCampeonatos();

        }
        private void PreencherComboBoxCampeonatos()
        {
            var _campeonatoService = new CampeonatoService();
            var campeonatos = _campeonatoService.ObterTodos();

            if (campeonatos.Count == 0)
            {
                MessageBox.Show("Nenhum Campeonato cadastrado");
                return;
            }

            for (int i = 0; i < campeonatos.Count; i++)
            {
                var campeonato = campeonatos[i];
                comboBoxCampeonatos.Items.Add(campeonato);
            }
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxIdioma.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Idioma");
                return;
            }

            if (comboBoxCampeonatos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Campeonato");
                return;
            }

            var nomeTransmissao = textBoxNomeTransmissao.Text.Trim();
            var nomeNarrador = textBoxNomeComentarista.Text.Trim();
            var idiomaLive = comboBoxIdioma.SelectedItem.ToString();
            var torneios = comboBoxCampeonatos.SelectedItem as Torneio;

            var transmissao = new Live();
            transmissao.NomeLive = nomeTransmissao;
            transmissao.NomeNarrador = nomeNarrador;
            transmissao.IdiomaTransmissao = idiomaLive;
            transmissao.Torneio = torneios;

            var transmissaoService = new TransmissaoService();
            // Verificar se esta no modod de cadastro
            if (_idParaEditar == -1)
            {
                // Persistir o que o usuario escolheu na tabela de personagens
                transmissaoService.Cadastrar(transmissao);

                MessageBox.Show("Transmissao cadastrada com sucesso");
                Close();
            }
            else
            {
                // MODO DE EDIÇÃO
                transmissao.Id = _idParaEditar;
                transmissaoService.Editar(transmissao);
                MessageBox.Show("Transmissao alterada com sucesso");
                Close();
            }
        }
    }
}
