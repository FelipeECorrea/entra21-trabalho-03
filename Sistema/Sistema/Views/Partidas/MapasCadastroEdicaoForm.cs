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
                    partida.PartidaEscolhida,
                    partida.Mapa1,
                    partida.Mapa2,
                    partida.Mapa3
                });
            }
        }

        private void buttonSortearMapa_Click(object sender, EventArgs e)
        {
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

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var partida = new Partida();

            var partidas = _partidaService.ObterPorId(id);

            var partidaSelecionada = linhaSelecionada.Cells[1].Value.ToString();

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
            if (linhaSelecionada.Cells[2].Value.ToString() != "")
            {
                MessageBox.Show("Partida ja cadastrada!");
                return;
            }

            partida.Id = id;
            partida.PartidaEscolhida = partidaSelecionada;
            partida.Mapa1 = mapa1;
            partida.Mapa2 = mapa2;
            partida.Mapa3 = mapa3;

            _partidaService.Editar(partida);

            MessageBox.Show("Mapas cadastrados com cucesso!");

            PreencherDataGridView();
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre mapas a uma partida!");
                return;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione a partida da telinha para jogar!");
                return;
            }

            var linhaSelecionada = dataGridView1.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            PreencherDataGridView();

            System.Diagnostics.Process.Start(@"D:\Downloads\Steam\steam.exe");
        }

        private void buttonApagarMapas_Click(object sender, EventArgs e)
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

            var partidaSelecionada = linhaSelecionada.Cells[1].Value.ToString();

            var partida = new Partida();

            partida.Id = id;
            partida.PartidaEscolhida = partidaSelecionada;
            partida.Mapa1 = "";
            partida.Mapa2 = "";
            partida.Mapa3 = "";

            _partidaService.ApagarMapas(partida);

            PreencherDataGridView();

            MessageBox.Show("Mapas removidos com sucesso!");
        }
    }
}