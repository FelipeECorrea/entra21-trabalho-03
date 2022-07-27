using Sistema.Models;
using Sistema.Service;
using System.Windows.Forms;

namespace Sistema.Views.Grupo
{
    public partial class GrupoCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        public GrupoCadastroEdicaoForm()
        {
            InitializeComponent();

            PreencherComboboxTime();

            PreencherComboboxTorneio();

            _idParaEditar = -1;
        }

        // TODO: Verificar apos models feitos
        //public GrupoCadastroEdicaoForm(Grupo grupo) : this()
        //{
        //    _idParaEditar = grupo.Id;

        //    for (int i = 0; i < comboBoxTime.Items.Count; i++)
        //    {
        //        var timepercorrido = comboBoxTime.Items[i] as Time;

        //        if (timepercorrido.Id == grupo.Time.Id)
        //        {
        //            comboBoxTime.SelectedItem = timepercorrido;
        //        }
        //    }

        //    for (int i = 0; i < comboBoxTorneio.Items.Count; i++)
        //    {
        //        var torneiopercorrido = comboBoxTorneio.Items[i] as Torneio;

        //        if (torneiopercorrido.Id == grupo.Torneio.Id)
        //        {
        //            comboBoxTorneio.SelectedItem = torneiopercorrido;
        //        }
        //    }
        //}

        private void PreencherComboboxTime()
        {
            // TODO: Verificar se esta conforme TimeService
            //var timeService = new TimeService();

            //var times = timeService.ObterTodos();

            //for(int i = 0; i < times.Count; i++)
            //{
            //    var time = times[i];

            //    comboBoxTime.Items.Add(time);
            //}
        }

        private void PreencherComboboxTorneio()
        {
            // TODO: Verificar se esta conforme TorneioService
            //var torneioService = new TorneioService();

            //var torneios = torneioService.ObterTodos();

            //for(int i = 0; i < torneios.Count; i++)
            //{
            //    var torneio = torneios[i];

            //    comboBoxTorneio.Items.Add(torneio);
            //}
        }

        private void buttonSalvar_Click(object sender, System.EventArgs e)
        {
            if (comboBoxTime.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um time");
                return;
            }

            if (comboBoxTorneio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um torneio");
                return;
            }

            var time = comboBoxTime.SelectedItem as Time;

            var torneio = comboBoxTorneio.SelectedItem as Torneio;

            // TODO: Verificar apos models feitos
            //var grupo = new Grupo();
            //grupo.Time = time;
            //grupo.Torneio = torneio;

            //if (grupo.Transmissao.IdTorneio == grupo.Torneio.Id)
            //{
            //    var transmissao = grupo.Transmissao.NomeLive as Transmissao;

            //    grupo.Transmissao = transmissao;
            //}

            //var grupoService = new GrupoService();

            //if (_idParaEditar == -1)
            //{
            //    grupoService.Cadastrar(grupo);

            //    MessageBox.Show("Grupo cadastrado com sucesso!");
            //    Close();
            //}
            //else
            //{
            //    grupo.Id = _idParaEditar;

            //    grupoService.Editar(grupo);

            //    MessageBox.Show("Grupo alterado com sucesso!");
            //    Close();
            //}
        }

        private void buttonCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
