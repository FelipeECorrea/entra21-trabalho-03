using System;
using System.Windows.Forms;

namespace Sistema.Views.Partidas
{
    public partial class PartidaListagemForm : Form
    {
        //private GrupoService _grupoService;
        //private PartidaService _partidaoService;

        public PartidaListagemForm()
        {
            InitializeComponent();

            //_grupoService = new GrupoService();

            //_partidaoService = new PartidaService();

            //PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            //var grupos = _grupoService.ObterTodos();

            //dataGridView1.Rows.Clear();

            //Random sortearGrupo = new Random();

            //var numeroMinimo = 1;
            //var numeroMaximo = grupos.Count;

            //List<string> mapas = new List<string>();
            //mapas.Add("Ancient");
            //mapas.Add("Dust 2");
            //mapas.Add("Inferno");
            //mapas.Add("Mirage");
            //mapas.Add("Nuke");
            //mapas.Add("Overpass");
            //mapas.Add("Vertigo");

            //var i = 0;
            //var j = 0;

            //while (i == 0)
            //{
            //    while (j == 0)
            //    {
            //        var sorteio = sortearGrupo.Next(numeroMinimo, numeroMaximo);

            //        if (sorteio == grupos)
            //    }
            //}
        }

        private void buttonMapas_Click(object sender, EventArgs e)
        {
            var mapaForm = new MapasCadastroEdicaoForm();
            mapaForm.ShowDialog();
        }
    }
}
