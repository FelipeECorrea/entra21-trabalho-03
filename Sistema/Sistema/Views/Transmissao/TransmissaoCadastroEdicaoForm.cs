using Sistema.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema.Views.Transmissao
{
    public partial class TransmissaoCadastroEdicaoForm : Form
    {
        public TransmissaoCadastroEdicaoForm()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT nome FROM torneios";
            SqlDataReader ler = comando.ExecuteReader();
            DataTable tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(ler);
            DataRow linha = tabelaEmMemoria.NewRow();
            //TODO: FAZER CONEÇÃO COM O DB E LER OS DADOS
            comando.ExecuteReader();

            comando.Connection.Close();
        }
    }
}
