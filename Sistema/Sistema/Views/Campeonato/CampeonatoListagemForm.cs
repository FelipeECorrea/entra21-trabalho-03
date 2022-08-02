using Sistema.Service;
using System;
using System.Windows.Forms;

namespace Sistema.Views.Campeonato
{
    public partial class CampeonatoListagemForm : Form
    {
        private CampeonatoService _campeonatoService;

        public CampeonatoListagemForm()
        {
            InitializeComponent();

            _campeonatoService = new CampeonatoService();

            PreencherDataGridViewComTorneios();
        }

        private void PreencherDataGridViewComTorneios()
        {
            var torneios = _campeonatoService.ObterTodos();

            dataGridViewListaCampeonato.Rows.Clear();

            for (int i = 0; i < torneios.Count; i++)
            {
                var torneio = torneios[i];

                dataGridViewListaCampeonato.Rows.Add(new object[]
                {
                    torneio.Id,
                    torneio.Nome,
                    torneio.ModoJogo,
                    torneio.ModoPresencial,
                    torneio.DataInicio,
                    torneio.DataTermino,
                    torneio.Categoria,
                    torneio.Premiacao});
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Campeonato = new CampeonatoCadastroForm();
            Campeonato.ShowDialog();

            PreencherDataGridViewComTorneios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaCampeonato.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Torneio");
                return;
            }

            var linhaSelecionada = dataGridViewListaCampeonato.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var torneio = _campeonatoService.ObterPorId(id);

            var campeonatoCadastroForm = new CampeonatoCadastroForm(torneio);

            campeonatoCadastroForm.ShowDialog();

            PreencherDataGridViewComTorneios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaCampeonato.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }

            var linhaSelecionada = dataGridViewListaCampeonato.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            _campeonatoService.Apagar(id);

            PreencherDataGridViewComTorneios();

            MessageBox.Show("Registro removido com sucesso");
        }

        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
