using Sistema.Database;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sistema.Service
{
    internal class TimeService : ITimeService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM times WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Time time)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO times (nome, nacionalidade, data_criacao) VALUES (@NOME, @NACIONALIDADE, @DATACRIACAO);";
            comando.Parameters.AddWithValue("@NOME", time.Nome);
            comando.Parameters.AddWithValue("@NACIONALIDADE", time.Nacionalidade);
            comando.Parameters.AddWithValue("@DATACRIACAO", time.DataCriacao);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Time time)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE times SET nome = @NOME, nacionalidade = @NACIONALIDADE, data_criacao = @DATACRIACAO WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", time.Id);
            comando.Parameters.AddWithValue("@NOME", time.Nome);
            comando.Parameters.AddWithValue("@NACIONALIDADE", time.Nacionalidade);
            comando.Parameters.AddWithValue("@DATACRIACAO", time.DataCriacao);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Time ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, nacionalidade, data_criacao FROM times WHERE id = @ID;";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var times = new Time();

            times.Id = Convert.ToInt32(registro["id"].ToString());
            times.Nome = registro["nome"].ToString();
            times.Nacionalidade = registro["nacionalidade"].ToString();
            times.DataCriacao = Convert.ToDateTime(registro["data_criacao"].ToString());

            comando.Connection.Close();

            return times;
        }

        public List<Time> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, nacionalidade, data_criacao FROM times";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var times = new List<Time>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var time = new Time();

                time.Id = Convert.ToInt32(linha["id"].ToString());
                time.Nome = linha["nome"].ToString();
                time.Nacionalidade = linha["nacionalidade"].ToString();
                time.DataCriacao = Convert.ToDateTime(linha["data_criacao"].ToString());

                times.Add(time);
            }

            comando.Connection.Close();

            return times;
        }
    }
}
