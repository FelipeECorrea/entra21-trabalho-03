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
mapa_mirage,
mapa_dust2,
mapa_overpass,
mapa_vertigo,
mapa_nuke,
mapa_inferno,
mapa_ancient)
VALUES
(@PARTIDA_SORTEADA,
@MAPA_MIRAGE,
@MAPA_DUST2,
@MAPA_OVERPASS,
@MAPA_VERTIGO,
@MAPA_NUKE,
@MAPA_INFERNO,
@MAPA_ANCIENT);";

            comando.Parameters.AddWithValue("@PARTIDA_SORTEADA", partida.PartidaSorteada);
            comando.Parameters.AddWithValue("@MAPA_MIRAGE", partida.MapaMirage);
            comando.Parameters.AddWithValue("@MAPA_DUST2", partida.MapaDust2);
            comando.Parameters.AddWithValue("@MAPA_OVERPASS", partida.MapaOverpass);
            comando.Parameters.AddWithValue("@MAPA_VERTIGO", partida.MapaVertigo);
            comando.Parameters.AddWithValue("@MAPA_NUKE", partida.MapaNuke);
            comando.Parameters.AddWithValue("@MAPA_INFERNO", partida.MapaInferno);
            comando.Parameters.AddWithValue("@MAPA_ANCIENT", partida.MapaAncient);

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
mapa_mirage,
mapa_dust2,
mapa_overpass,
mapa_vertigo,
mapa_nuke,
mapa_inferno,
mapa_ancient,
FROM partidas
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
            partida.MapaMirage = Convert.ToBoolean(registro["mapa_mirage"]);
            partida.MapaDust2 = Convert.ToBoolean(registro["mapa_dust2"]);
            partida.MapaOverpass = Convert.ToBoolean(registro["mapa_overpass"]);
            partida.MapaVertigo = Convert.ToBoolean(registro["mapa_vertigo"]);
            partida.MapaNuke = Convert.ToBoolean(registro["mapa_nuke"]);
            partida.MapaInferno = Convert.ToBoolean(registro["mapa_inferno"]);
            partida.MapaAncient = Convert.ToBoolean(registro["mapa_ancient"]);

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
partidas.mapa_mirage AS 'mirage',
partidas.mapa_dust2 AS 'dust2',
partidas.mapa_overpass AS 'overpass',
partidas.mapa_vertigo AS 'vertigo',
partidas.mapa_nuke AS 'nuke',
partidas.mapa_inferno AS 'inferno',
partidas.mapa_ancient AS 'ancient',
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
                partida.MapaMirage = Convert.ToBoolean(registro["mirage"]);
                partida.MapaDust2 = Convert.ToBoolean(registro["dust2"]);
                partida.MapaOverpass = Convert.ToBoolean(registro["overpass"]);
                partida.MapaVertigo = Convert.ToBoolean(registro["vertigo"]);
                partida.MapaNuke = Convert.ToBoolean(registro["nuke"]);
                partida.MapaInferno = Convert.ToBoolean(registro["inferno"]);
                partida.MapaAncient = Convert.ToBoolean(registro["ancient"]);

                partidas.Add(partida);
            }
            conexao.Close();

            return partidas;
        }
    }
}
