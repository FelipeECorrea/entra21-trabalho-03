using Sistema.Models;
using Sistema.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema.Views.Partidas
{
    public partial class MapasCadastroEdicaoForm : Form
    {
        private readonly PartidaService _partidaService;
        public MapasCadastroEdicaoForm()
        {
            InitializeComponent();

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
                    partida.PartidaSorteada,
                    partida.Mapa1,
                    partida.Mapa2,
                    partida.Mapa3
                });
            }
        }

        private void PreencherComboBox()
        {
            var partidas = _partidaService.ObterTodos();

            for (int i = 0; i < partidas.Count; i++)
            {
                var partida = partidas[i];

                comboBoxPartidas.Items.Add(partida.PartidaSorteada);
            }
        }

        private void buttonSortearMapa_Click(object sender, EventArgs e)
        {
            if (comboBoxPartidas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma partida!");
                return;
            }

            Random random = new Random();

            List<string> nomeMapa = new List<string>();
            nomeMapa.Add("Ancient");
            nomeMapa.Add("Dust 2");
            nomeMapa.Add("Inferno");
            nomeMapa.Add("Mirage");
            nomeMapa.Add("Nuke");
            nomeMapa.Add("Overpass");
            nomeMapa.Add("Vertigo");

            List<bool> mapaTime1 = new List<bool>();
            mapaTime1.Add(radioButtonMapaAncient1.Checked);
            mapaTime1.Add(radioButtonMapaDust21.Checked);
            mapaTime1.Add(radioButtonMapaInferno1.Checked);
            mapaTime1.Add(radioButtonMapaMirage1.Checked);
            mapaTime1.Add(radioButtonMapaNuke1.Checked);
            mapaTime1.Add(radioButtonMapaOverpass1.Checked);
            mapaTime1.Add(radioButtonMapaVertigo1.Checked);

            List<bool> mapaTime2 = new List<bool>();
            mapaTime2.Add(radioButtonMapaAncient2.Checked);
            mapaTime2.Add(radioButtonMapaDust22.Checked);
            mapaTime2.Add(radioButtonMapaInferno2.Checked);
            mapaTime2.Add(radioButtonMapaMirage2.Checked);
            mapaTime2.Add(radioButtonMapaNuke2.Checked);
            mapaTime2.Add(radioButtonMapaOverpass2.Checked);
            mapaTime2.Add(radioButtonMapaVertigo2.Checked);

            var numeroMinimo = 1;
            var numeroMaximo = 8;

            var mapa1 = "";
            var mapa2 = "";
            var mapa3 = "";

            var i = 0;

            while (i == 0)
            {
                var sorteio = random.Next(numeroMinimo, numeroMaximo);

                if (mapaTime1[sorteio - 1] == false && mapaTime2[sorteio - 1] == false)
                {
                    mapa3 = nomeMapa[sorteio - 1];

                    for (int j = 0; j < 7; j++)
                    {
                        if (mapaTime1[j] == true)
                        {
                            mapa1 = nomeMapa[j];
                        }

                        if (mapaTime2[j] == true)
                        {
                            mapa2 = nomeMapa[j];
                        }
                    }
                    i++;
                }
            }
            var partida = new Partida();

            // TODO: Kauã Verificar se vai funcionar o editar
            if (comboBoxPartidas.SelectedText == partida.PartidaSorteada)
            {
                partida.Mapa1 = mapa1;
                partida.Mapa2 = mapa2;
                partida.Mapa3 = mapa3;

                _partidaService.Editar(partida);

                MessageBox.Show("Mapas cadastrados com cucesso!");

                PreencherDataGridView();
            }
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione a partida da telinha para jogar!");
                return;
            }

            System.Diagnostics.Process.Start("csgo.exe");
        }

        private void buttonApagarMapas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma partida da tabela!");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _partidaService.Apagar(id);

            PreencherDataGridView();

            MessageBox.Show("Mapas removidos com sucesso!");
        }
    }
}
