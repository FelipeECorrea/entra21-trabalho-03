using Sistema.Models;
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

namespace Sistema.Views.Campeonato
{
    public partial class CampeonatoCadastroForm : Form
    {
        internal int _idEditar = -1;
        private CampeonatoService campeonatoService;
        public CampeonatoCadastroForm()
        {
            InitializeComponent();

            campeonatoService = new CampeonatoService();
        }

        public CampeonatoCadastroForm(Torneio torneio) : this()
        {
            _idEditar = torneio.Id;

            textBoxNomeCamp.Text = torneio.Nome;
            ValidarModoJogo();
            ValidarModoCampeonato();
            dateTimePickerInicio.Value = torneio.DataInicio;
            dateTimePickerTermino.Value = torneio.DataTermino;
            ValidarPremiacao();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxCatRank.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Categoria");
                return;
            }

            string modoJ = ValidarModoJogo();
            string modoP = ValidarModoCampeonato();
            string selectPremio = ValidarPremiacao();

            var nome = textBoxNomeCamp.Text.Trim();
            var modoJogo = modoJ.ToString();
            var modoPresencial = modoP.ToString();
            var dataInicio = dateTimePickerInicio.Value.ToString("d");
            var dataTermino = dateTimePickerTermino.Value.ToString("d");
            var premiacao = selectPremio.ToString();
            var categoria = comboBoxCatRank.SelectedItem.ToString();

            var torneios = new Torneio();
            torneios.Nome = nome;
            torneios.ModoJogo = modoJogo;
            torneios.ModoPresencial = modoPresencial;
            torneios.DataInicio = Convert.ToDateTime(dataInicio);
            torneios.DataTermino = Convert.ToDateTime(dataTermino);
            torneios.Categoria = categoria;
            torneios.Premiacao = premiacao;

            var campeonatoService = new CampeonatoService();

            if (_idEditar == -1)
            {
                campeonatoService.Cadastrar(torneios);

                MessageBox.Show("Campeonato cadastrado com sucesso");
                Close();
            }
            else
            {
                torneios.Id = _idEditar;

                campeonatoService.Editar(torneios);

                MessageBox.Show("Campeonato alterado com sucesso");
                Close();

            }

        }

        private string ValidarModoJogo()
        {
            var modoJ = "";
            if (rButtonMJ1.Checked)
            {
                modoJ = "5 vs 5";
            }
            else if (rButtonMJ2.Checked)
            {
                modoJ = "2 vs 2";
            }
            else
            {
                modoJ = "1 vs 1";
            }

            return modoJ;
        }

        private string ValidarModoCampeonato()
        {
            var modoP = "";
            if (radioButtonPresencial.Checked)
            {
                modoP = "Presencial";
            }
            else if (radioButtonOnline.Checked)
            {
                modoP = "Online";
            }

            return modoP;
        }

        private string ValidarPremiacao()
        {
            var selectPremio = "";
            if (radioButtonP1.Checked)
            {
                selectPremio = "10.000 a 50.000";
            }
            else if (radioButtonP2.Checked)
            {
                selectPremio = "50.000 a 250.000";
            }
            else if (radioButtonP3.Checked)
            {
                selectPremio = "250.000 a 750.000";
            }
            else if (radioButtonP4.Checked)
            {
                selectPremio = "750.000 a 1.000,000";
            }

            return selectPremio;
        }

        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
