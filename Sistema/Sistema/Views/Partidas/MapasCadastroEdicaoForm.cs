using Sistema.Models;
using Sistema.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema.Views.Partidas
{
    public partial class MapasCadastroEdicaoForm : Form
    {
        public MapasCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboBox();
        }

        private void PreencherComboBox()
        {
            var partidaService = new PartidaService();

            var partidas = partidaService.ObterTodos();

            for (int i = 0; i < partidas.Count; i++)
            {
                var partida = partidas[i];

                comboBoxPartidas.Items.Add(partida.PartidaSorteada);
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
            mapaTime1.Add(radioButtonMapaAncient2.Checked);
            mapaTime1.Add(radioButtonMapaDust22.Checked);
            mapaTime1.Add(radioButtonMapaInferno2.Checked);
            mapaTime1.Add(radioButtonMapaMirage2.Checked);
            mapaTime1.Add(radioButtonMapaNuke2.Checked);
            mapaTime1.Add(radioButtonMapaOverpass2.Checked);
            mapaTime1.Add(radioButtonMapaVertigo2.Checked);

            var numeroMinimo = 1;
            var numeroMaximo = 8;

            var sorteio = random.Next(numeroMinimo, numeroMaximo);

            if (mapaTime1[sorteio - 1] == false || mapaTime2[sorteio - 1] == false)
            {
                
            }
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione a partida que deseja jogar!");
                return;
            }

            System.Diagnostics.Process.Start("csgo.exe");
        }
    }
}
