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
        private readonly int _idParaEditar;
        public CampeonatoCadastroForm()
        {
            InitializeComponent();

            _idParaEditar = -1;
        }

        public CampeonatoCadastroForm(Torneio torneio) : this()
        {
            _idParaEditar = -1;

            textBoxNomeCamp.Text = torneio.Nome;
            if (rButtonMJ1.Checked)
            {
                rButtonMJ1.Checked = true;
            }
            else if (rButtonMJ2.Checked)
            {
                rButtonMJ2.Checked = true;
            }
            else if (rButtonMJ3.Checked)
            {
                rButtonMJ3.Checked = true;
            }

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
            var dataInicio = Convert.ToDateTime(dateTimePickerInicio.Value.Date.ToString("dd/MM/yyyy"));
            var dataTermino = Convert.ToDateTime(dateTimePickerTermino.Value.Date.ToString("dd/MM/yyyy"));
            var premiacao = selectPremio.ToString();
            var categoria = comboBoxCatRank.SelectedItem.ToString();

            var torneio = new Torneio();
            torneio.Nome = nome;
            torneio.ModoJogo = modoJogo;
            torneio.ModoPresencial = modoPresencial;
            torneio.DataInicio = dataInicio;
            torneio.DataTermino = dataTermino;
            torneio.Categoria = categoria;
            torneio.Premiacao = premiacao;

            var campeonatoService = new CampeonatoService();
            // Verificar se esta no modod de cadastro
            if (_idParaEditar == -1)
            {
                // Persistir o que o usuario escolheu na tabela de personagens
                campeonatoService.Cadastrar(torneio);

                MessageBox.Show("Campeonato cadastrado com sucesso");
                Close();
            }
            else
            {
<<<<<<< HEAD
                torneios.Id = _idEditar;

                campeonatoService.Editar(torneios);

                MessageBox.Show("Campeonato alterado com sucesso");
                Close();

            }

=======
                // MODO DE EDIÇÃO
                torneio.Id = _idParaEditar;
                campeonatoService.Editar(torneio);
                MessageBox.Show("Campeonato alterado com sucesso");
                Close();
            }
>>>>>>> fb7dd9544338200617a94bdb25a60b4fe58c77ee
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
