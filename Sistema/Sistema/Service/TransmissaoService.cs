using Sistema.Database;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Service
{
    internal class TransmissaoService : ITransmissaoService // TODO: FALTA FAZER SERVIÇOS E FUNÇOES PARA PUXAR COMBOBOX
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM transmissoes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Live transmissao)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO transmissoes (id_torneio, nome_live, nome_narrador, 
plataforma, idioma_trasmissao) VALUES (@IDTORNEIO, @NOMELIVE, @NOMENARRADOR, @PLATAFORMA, @IDIOMATRANSMISSAO);";
            comando.Parameters.AddWithValue("@IDTORNEIO", transmissao.Torneio);
            comando.Parameters.AddWithValue("@NOMELIVE", transmissao.NomeLive);
            comando.Parameters.AddWithValue("@NOMENARRADOR", transmissao.NomeNarrador);
            comando.Parameters.AddWithValue("@PLATAFORMA", transmissao.Plataforma);
            comando.Parameters.AddWithValue("@IDIOMATRANSMISSAO", transmissao.IdiomaTransmissao);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Live transmissao)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE transmissoes SET id_torneio = @IDTORNEIO, nome_live = @NOMELIVE, 
nome_narrador = @NOMENARRADOR, plataforma = @PLATAFORMA, idioma_transmissao = @IDIOMATRANSMISSAO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", transmissao.Id);
            comando.Parameters.AddWithValue("@IDTORNEIO", transmissao.Torneio);
            comando.Parameters.AddWithValue("@NOMELIVE", transmissao.NomeLive);
            comando.Parameters.AddWithValue("@NOMENARRADOR", transmissao.NomeNarrador);
            comando.Parameters.AddWithValue("@PLATAFORMA", transmissao.Plataforma);
            comando.Parameters.AddWithValue("@IDIOMATRANSMISSAO", transmissao.IdiomaTransmissao);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Live ObterPorId(int id)
        {

            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id_torneio, nome_live, nome_narrador, plataforma, idioma_trasmissao FROM transmissoes WHERE id = @ID;";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];
            var transmissao = new Live();

            transmissao.Id = Convert.ToInt32(registro["id"].ToString());
            transmissao.Torneio = new Torneio();
            transmissao.Torneio.Id = Convert.ToInt32(registro["id"].ToString());
            transmissao.NomeLive = registro["nome_live"].ToString();
            transmissao.NomeNarrador = registro["nome_narrador"].ToString();
            transmissao.Plataforma = registro["plataforma"].ToString();
            transmissao.IdiomaTransmissao = registro["idioma_transmissao"].ToString();

            comando.Connection.Close();

            return transmissao;
        }

        public List<Live> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT t.id, t.nome, c.id,c.tipo FROM transmissao AS t
INNER JOIN torneios AS c ON(t.id_torneio = c.id)";

            // criado tabela em memoria para armarmazer os registros do SELECT
            var tabelaEmMemoria = new DataTable();
            // Executa o SELET armazenando na tabela em memoria
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criado lista de personagens para armazenar os registros
            var transmissoes = new List<Live>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                //Instanciado o personagem populando com os dados do select
                var transmissao = new Live();
                transmissao.Id = Convert.ToInt32(registro["id"].ToString());
                transmissao.NomeLive = registro["nome_live"].ToString();
                transmissao.NomeNarrador = registro["nome_narrador"].ToString();
                transmissao.Plataforma = registro["plataforma"].ToString();
                transmissao.IdiomaTransmissao = registro["idioma_transmissao"].ToString();

                // Instanciar a editora oara poder armazenar o da editora
                transmissao.Torneio = new Torneio();
                transmissao.Torneio.Id = Convert.ToInt32(registro["id"].ToString());
                transmissao.Torneio.Nome = registro["nome"].ToString();

                transmissoes.Add(transmissao);

            }
            return transmissoes;
        }
    }
}
