using Sistema.Service;
using System;
using System.Windows.Forms;
namespace Sistema.Views.Grupos
{
    public partial class GrupoListagemForm : Form
    {
        private GrupoService _grupoService;
        public GrupoListagemForm()
        {
            InitializeComponent();
            _grupoService = new GrupoService();
            PreencherDataGridView();
        }
        private void PreencherDataGridView()
        {
            var grupos = _grupoService.ObterTodos();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < grupos.Count; i++)
            {
                var grupo = grupos[i];

                dataGridView1.Rows.Add(new object[]
                {
                    grupo.Id,
                    grupo.Time.Nome,
                    grupo.Torneio.Nome,
                });
            }
        }
        private void buttonCadastrar_Click(object sender, System.EventArgs e)
        {
            var grupoForm = new GrupoCadastroEdicaoForm();
            grupoForm.ShowDialog();
            PreencherDataGridView();
        }
        private void buttonEditar_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione algum grupo");
                return;
            }
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            var grupo = _grupoService.ObterPorId(id);
            var grupoCadastroEdicaoForm = new GrupoCadastroEdicaoForm(grupo);
            grupoCadastroEdicaoForm.ShowDialog();
            PreencherDataGridView();
        }
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro");
                return;
            }
            var linhaSelecionada = dataGridView1.SelectedRows[0];
            var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);
            _grupoService.Apagar(id);
            PreencherDataGridView();
            MessageBox.Show("Registro removido com sucesso!");
        }

        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}