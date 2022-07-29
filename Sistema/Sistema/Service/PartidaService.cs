using Sistema.Database;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sistema.Service
{
    internal class PartidaService : IPartidaService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"DELETE FROM partidas
WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Cadastrar(Partida partida)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO partidas
(partida_sorteada,
mapa_1,
mapa_2,
mapa_3,)
VALUES
(@PARTIDA_SORTEADA,
@MAPA_1,
@MAPA_2,
@MAPA_3,);";

            comando.Parameters.AddWithValue("@PARTIDA_SORTEADA", partida.PartidaSorteada);
            comando.Parameters.AddWithValue("@MAPA_1", partida.Mapa1);
            comando.Parameters.AddWithValue("@MAPA_2", partida.Mapa2);
            comando.Parameters.AddWithValue("@MAPA_3", partida.Mapa3);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Partida partida)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE partidas SET
partida_sorteada = @PARTIDA_SORTEADA,
mapa_1 = @MAPA_1,
mapa_2 = @MAPA_2,
mapa_3 = @MAPA_3
WHERE id = @ID";

            comando.Parameters.AddWithValue("@PARTIDA_SORTEADA", partida.PartidaSorteada);
            comando.Parameters.AddWithValue("@MAPA_1", partida.Mapa1);
            comando.Parameters.AddWithValue("@MAPA_2", partida.Mapa2);
            comando.Parameters.AddWithValue("@MAPA_3", partida.Mapa3);
            comando.Parameters.AddWithValue("@ID", partida.Id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public Partida ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
id,
partida_sorteada,
mapa_1,
mapa_2,
mapa_3,
WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();

            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];

            var partida = new Partida();
            partida.Id = Convert.ToInt32(registro["id"]);
            partida.PartidaSorteada = registro["partida_sorteada"].ToString();
            partida.Mapa1 = registro["mapa_1"].ToString();
            partida.Mapa2= registro["mapa_2"].ToString();
            partida.Mapa3= registro["mapa_3"].ToString();
            
            conexao.Close();

            return partida;
        }

        public List<Partida> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
partidas.id AS 'id',
partidas.partida_sorteada AS 'partida_sorteada',
partidas.mapa_1 AS 'mapa_1',
partidas.mapa_2 AS 'mapa_2',
partidas.mapa_3 AS 'mapa_3',
FROM partidas)";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var partidas = new List<Partida>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var partida = new Partida();
                partida.Id = Convert.ToInt32(registro["id"]);
                partida.PartidaSorteada = registro["partida_sorteada"].ToString();
                partida.Mapa1 = registro["mapa_1"].ToString();
                partida.Mapa2 = registro["mapa_2"].ToString();
                partida.Mapa3 = registro["mapa_3"].ToString();
                
                partidas.Add(partida);
            }
            conexao.Close();

            return partidas;
        }
    }
}
