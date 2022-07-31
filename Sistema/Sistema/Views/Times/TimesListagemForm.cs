using Sistema.Service;
using Sistema.Views.Jogadores;
using System;
using System.Windows.Forms;

namespace Sistema.Views.Times
{
    public partial class TimesListagemForm : Form
    {
        internal int _idEdicao = -1;
        private TimeService timeService;
        public TimesListagemForm()
        {
            InitializeComponent();

            timeService = new TimeService();

            AtualizarRegistrosDataGridView();
        }

        private void AbrirFormEmPainel(object FormFilho)
        {
            if (this.panelConteudoII.Controls.Count > 0)
                this.panelConteudoII.Controls.RemoveAt(0);
            Form fh = FormFilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelConteudoII.Controls.Add(fh);
            this.panelConteudoII.Tag = fh;
            fh.Show();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Antes de remover um registro.\nSelecione um para remover!");

                return;
            }

            var decisao = MessageBox.Show(
                "Deseja realmente remover esse registro ?", "Aviso",
                MessageBoxButtons.YesNo);

            if (decisao != DialogResult.Yes)
            {
                MessageBox.Show("O registro não foi removido!");

                return;
            }

            var id = Convert.ToInt32(dataGridViewTimes.SelectedRows[0].Cells[0].Value);

            timeService.Apagar(id);

            MessageBox.Show("Registro apagado com sucesso");

            AtualizarRegistrosDataGridView();
        }

        private void AtualizarRegistrosDataGridView()
        {
            var time = timeService.ObterTodos();

            dataGridViewTimes.Rows.Clear();

            for (int i = 0; i < time.Count; i++)
            {
                var timesCadastrados = time[i];

                dataGridViewTimes.Rows.Add(new object[]
               {
                    timesCadastrados.Id,
                    timesCadastrados.Nome,
                    timesCadastrados.Nacionalidade,
                    timesCadastrados.DataCriacao
               });
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimes.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre algum time primeiro");
                return;
            }

            if (dataGridViewTimes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum registro");
                return;
            }

            var linhaSelecionada = dataGridViewTimes.SelectedRows[0];

            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            var times = timeService.ObterPorId(id);

            var cadastroTimeForm = new CadastroTimesForm(times);

            cadastroTimeForm.ShowDialog();

            AtualizarRegistrosDataGridView();
        }


        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
            AbrirFormEmPainel(new CadastroTimesForm());

            AtualizarRegistrosDataGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarRegistrosDataGridView();
        }
    }
}
