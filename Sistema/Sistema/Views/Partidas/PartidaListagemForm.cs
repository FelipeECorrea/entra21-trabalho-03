using Sistema.Models;
using Sistema.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema.Views.Partidas
{
    public partial class PartidaListagemForm : Form
    {
        private GrupoService _grupoService;
        private PartidaService _partidaService;

        public PartidaListagemForm()
        {
            InitializeComponent();

            _grupoService = new GrupoService();

            _partidaService = new PartidaService();

            PreencherComboBox();

            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var partidas = _partidaService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < partidas.Count; i++)
            {
                var partida = partidas[i];

                dataGridView1.Rows.Add(new object[]
                {
                    partida.Id,
                    partida.PartidaEscolhida
                });
            }
        }

        private void PreencherComboBox()
        {
            var grupos = _grupoService.ObterTodos();

            for (int i = 0; i < grupos.Count; i++)
            {
                var grupo = grupos[i];

                comboBoxTime1.Items.Add(grupo.Time);
            }

            for (int i = 0; i < grupos.Count; i++)
            {
                var grupo = grupos[i];

                comboBoxTime2.Items.Add(grupo.Time);
            }
        }

        private void buttonMapas_Click(object sender, EventArgs e)
        {
            var mapaForm = new MapasCadastroEdicaoForm();
            mapaForm.ShowDialog();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma Partida!");
                return;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma partida da tabela!");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _partidaService.Apagar(id);

            PreencherDataGridView();

            MessageBox.Show("Partida removida com sucesso!");
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxTime1.SelectedIndex == -1 || comboBoxTime2.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um time!");
                return;
            }
            if (comboBoxTime1.SelectedIndex == comboBoxTime2.SelectedIndex || comboBoxTime2.SelectedIndex == comboBoxTime1.SelectedIndex)
            {
                MessageBox.Show("Selecione um rival válido!");
                return;
            }

            var partidaEscolhida = comboBoxTime1.Text + " VS " + comboBoxTime2.Text;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(partidaEscolhida))
                {
                    MessageBox.Show("Cadastros iguais não é permitido!");
                    return;
                }
            }

            var partida = new Partida();
            partida.PartidaEscolhida = partidaEscolhida;
            partida.Mapa1 = "";
            partida.Mapa2 = "";
            partida.Mapa3 = "";

            _partidaService.Cadastrar(partida);

            MessageBox.Show("Partida cadastrada com sucesso!");

            PreencherDataGridView();
        }
    }
}
