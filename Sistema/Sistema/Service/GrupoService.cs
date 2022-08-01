using Sistema.Database;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sistema.Service
{
    internal class GrupoService : IGrupoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"DELETE FROM grupos
WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Cadastrar(Grupo grupo)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO grupos (id_time, id_torneio) VALUES
            (@ID_TIME, @ID_TORNEIO);";

            comando.Parameters.AddWithValue("@ID_TIME", grupo.Time.Id);
            comando.Parameters.AddWithValue("@ID_TORNEIO", grupo.Torneio.Id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Grupo grupo)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE grupos SET
            id_time = @ID_TIME,
            id_torneio = @ID_TORNEIO
            WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID_TIME", grupo.Time.Id);
            comando.Parameters.AddWithValue("@ID_TORNEIO", grupo.Torneio.Id);
            comando.Parameters.AddWithValue("@ID", grupo.Id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public Grupo ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT id, id_time, id_torneio
FROM grupos
WHERE id = @ID";

            comando.Parameters.AddWithValue("ID", id);

            var dataTable = new DataTable();

            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];

            var grupo = new Grupo();
            grupo.Id = Convert.ToInt32(registro["id"]);

            grupo.Time = new Time();
            grupo.Time.Id = Convert.ToInt32(registro["id_time"]);

            grupo.Torneio = new Torneio();
            grupo.Torneio.Id = Convert.ToInt32(registro["id_torneio"]);

            conexao.Close();

            return grupo;
        }

        public List<Grupo> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
grupos.id AS 'id',
times.id AS 'time_id',
times.nome AS 'time_nome',
torneios.id AS 'torneio_id',
torneios.nome AS 'torneio_nome'
FROM grupos
INNER JOIN times ON(grupos.id_time = times.id)
INNER JOIN torneios ON(grupos.id_torneio = torneios.id)";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var grupos = new List<Grupo>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var grupo = new Grupo();
                grupo.Id = Convert.ToInt32(registro["id"]);

                grupo.Time = new Time();
                grupo.Time.Id = Convert.ToInt32(registro["time_id"]);
                grupo.Time.Nome = registro["time_nome"].ToString();

                grupo.Torneio = new Torneio();
                grupo.Torneio.Id = Convert.ToInt32(registro["torneio_id"]);
                grupo.Torneio.Nome = registro["torneio_nome"].ToString();

                grupos.Add(grupo);
            }
            conexao.Close();

            return grupos;
        }
    }
}
