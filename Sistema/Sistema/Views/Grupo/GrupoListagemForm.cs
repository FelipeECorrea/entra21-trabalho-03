using Sistema.Service;
using System;
using System.Windows.Forms;

namespace Sistema.Views.Grupo
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
            var grupops = _grupoService.ObterTodos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < grupops.Count; i++)
            {
                var grupo = grupops[i];

                // TODO: Verificar no models para ver se ta igual
                //dataGridView1.Rows.Add(new object[]
                //{
                //    grupo.Time.Nome,
                //    grupo.Torneio.Nome,
                //    grupo.Transmissao.NomeLive
                //});
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
            //    if (dataGridView1.SelectedRows.Count == 0)
            //    {
            //        MessageBox.Show("Selecione algum grupo");
            //        return;
            //    }

            //    var linhaSelecionada = dataGridView1.SelectedRows[0];

            //    var id = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

            //    var grupo = _grupoService.ObterPorId(id);

            //    // TODO: Verificar se o grupo vai funcionar apos encrementar os modedls
            //    var grupoCadastroEdicaoForm = new GrupoCadastroEdicaoForm(grupo);
            //    grupoCadastroEdicaoForm.ShowDialog();

            //    PreencherDataGridView();
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
    }
}

