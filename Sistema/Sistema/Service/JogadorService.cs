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
    internal class JogadorService : IJogadorService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM jogador WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Jogador jogador)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO jogador (id, nick, email, senha, patente, time) VALUES (@ID, @NICK, @EMAIL, @SENHA, @PATENTE, @TIME);";
            comando.Parameters.AddWithValue("@ID", jogador.Id);
            comando.Parameters.AddWithValue("@NICK", jogador.Nick);
            comando.Parameters.AddWithValue("@EMAIL", jogador.Email);
            comando.Parameters.AddWithValue("@SENHA", jogador.Senha);
            comando.Parameters.AddWithValue("@PATENTE", jogador.Patente);
            comando.Parameters.AddWithValue("@TIME", jogador.Time);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Jogador jogador)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE jogador SET id = @ID, nick = @NICK, email = @EMAIL, senha = @SENHA, patente = @PATENTE, time = @TIME WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", jogador.Id);
            comando.Parameters.AddWithValue("@NICK", jogador.Nick);
            comando.Parameters.AddWithValue("@EMAIL", jogador.Email);
            comando.Parameters.AddWithValue("@SENHA", jogador.Senha);
            comando.Parameters.AddWithValue("@PATENTE", jogador.Patente);
            comando.Parameters.AddWithValue("@TIME", jogador.Time);
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Jogador ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nick, email, senha, patente, time FROM jogador WHERE id = @ID;";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)

                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var jogador = new Jogador();

            jogador.Id = Convert.ToInt32(registro["id"].ToString());
            jogador.Nick = registro["nick"].ToString();
            jogador.Email = registro["email"].ToString();
            jogador.Senha = registro["senha"].ToString();
            jogador.Patente = registro["patente"].ToString();
            jogador.Time.Id = Convert.ToInt32(registro["id_time"].ToString());

            comando.Connection.Close();

            return jogador;
        }

        public List<Jogador> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nick, email, senha, patente, time FROM jogadores";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var jogadores = new List<Jogador>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var jogador = new Jogador();

                jogador.Id = Convert.ToInt32(registro["id"].ToString());
                jogador.Nick = registro["nick"].ToString();
                jogador.Email = registro["email"].ToString();
                jogador.Senha = registro["senha"].ToString();
                jogador.Patente = registro["patente"].ToString();
                jogador.Time.Id = Convert.ToInt32(registro["time"].ToString());


                jogadores.Add(jogador);
            }

            comando.Connection.Close();

            return jogadores;
        }
    }
}
    
