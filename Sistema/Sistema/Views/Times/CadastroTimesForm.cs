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

namespace Sistema.Views.Jogadores
{
    public partial class CadastroTimesForm : Form
    {
        internal int _idEdicao = -1;
        private TimeService timeService;
        public CadastroTimesForm()
        {
            InitializeComponent();

            timeService = new TimeService();
        }

        public CadastroTimesForm(Time time) : this()
        {
            _idEdicao = time.Id;
            textBoxNome.Text = time.Nome;
            textBoxPais.Text = time.Nacionalidade;
            dateTimePickerDataCriacao.Value = time.DataCriacao;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var nomeTime = textBoxNome.Text.Trim();
            var nacionalidade = textBoxPais.Text.Trim();
            var dataCriacao = dateTimePickerDataCriacao.Value.ToString("d");

            var times = new Time();
            times.Nome = nomeTime;
            times.Nacionalidade = nacionalidade;
            times.DataCriacao = Convert.ToDateTime(dataCriacao);

            var timeService = new TimeService();

            if (_idEdicao == -1)
            {
                timeService.Cadastrar(times);

                MessageBox.Show("Time cadastrada com sucesso!");

                Close();
               
                return;
            }

            times.Id = _idEdicao;

            timeService.Editar(times);

            MessageBox.Show("Time Alterada com sucesso!");
            Close();
        }
    }
}
