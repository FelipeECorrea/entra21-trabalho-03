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
    internal class CampeonatoService : ICampeonatoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM torneios WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Torneio torneio)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO torneios (nome, modo_jogo, modo_presencial, data_inicio, data_termino, categoria, premiacao) VALUES
            (@NOME, @MODO_JOGO, @MODO_PRESENCIAL, @DATA_INICIO, @DATA_TERMINO, @CATEGORIA, @PREMIACAO);";

            comando.Parameters.AddWithValue("@NOME", torneio.Nome);
            comando.Parameters.AddWithValue("@MODO_JOGO", torneio.ModoJogo);
            comando.Parameters.AddWithValue("@MODO_PRESENCIAL", torneio.ModoPresencial);
            comando.Parameters.AddWithValue("@DATA_INICIO", torneio.DataInicio);
            comando.Parameters.AddWithValue("@DATA_TERMINO", torneio.DataTermino);
            comando.Parameters.AddWithValue("@CATEGORIA", torneio.Categoria);
            comando.Parameters.AddWithValue("@PREMIACAO", torneio.Premiacao);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Torneio torneio)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText =
                "UPDATE torneios SET nome = @NOME, modo_jogo = @MODO_JOGO, modo_presencial = @MODO_PRESENCIAL, data_inicio = @DATA_INICIO, data_termino = @DATA_TERMINO, categoria = @CATEGORIA, premiacao = @PREMIACAO WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", torneio.Id);
            comando.Parameters.AddWithValue("@NOME", torneio.Nome);
            comando.Parameters.AddWithValue("@MODO_JOGO", torneio.ModoJogo);
            comando.Parameters.AddWithValue("@MODO_PRESENCIAL", torneio.ModoPresencial);
            comando.Parameters.AddWithValue("@DATA_INICIO", torneio.DataInicio);
            comando.Parameters.AddWithValue("@DATA_TERMINO", torneio.DataTermino);
            comando.Parameters.AddWithValue("@CATEGORIA", torneio.Categoria);
            comando.Parameters.AddWithValue("@PREMIACAO", torneio.Premiacao);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Torneio ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT * FROM torneios WHERE id = @ID";
            // Substituir o @ do comando do select com o id
            comando.Parameters.AddWithValue("@ID", id);

            // Cria tabela em memoria para armazenar o registro da consulta
            var dataTable = new DataTable();
            // Carregar os registros no dataTable
            dataTable.Load(comando.ExecuteReader());
            // Verifica se encontrou um registro
            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var torneio = new Torneio();
            torneio.Id = Convert.ToInt32(registro["id"]);

            // Fechar conexao
            comando.Connection.Close();

            return torneio;
        }

        public List<Torneio> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT * FROM torneios";

            // criado tabela em memoria para armarmazer os registros do SELECT
            var tabelaEmMemoria = new DataTable();
            // Executa o SELET armazenando na tabela em memoria
            tabelaEmMemoria.Load(comando.ExecuteReader());

            // Criado lista de personagens para armazenar os registros
            var torneios = new List<Torneio>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                //Instanciado o personagem populando com os dados do select
                var torneio = new Torneio();
                torneio.Id = Convert.ToInt32(registro["id"]);
                torneio.Nome = registro["nome"].ToString();
                torneio.ModoJogo = registro["modo_jogo"].ToString();
                torneio.ModoPresencial = registro["modo_presencial"].ToString();
                torneio.DataInicio = Convert.ToDateTime(registro["data_inicio"]);
                torneio.DataTermino = Convert.ToDateTime(registro["data_termino"]);
                torneio.Categoria = registro["categoria"].ToString();
                torneio.Premiacao = registro["premiacao"].ToString();


                torneios.Add(torneio);

            }
            return torneios;
        }
    }
}
