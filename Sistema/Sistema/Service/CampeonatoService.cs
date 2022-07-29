using Sistema.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Service
{
    internal class CampeonatoService : ICampeonatoService
    {
        public void Apagar(int id)
        {

        }

        public void Cadastrar(CampeonatoService campeonatoService)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO torneios (nome, modo_presencial, data_inicio, data_termino, premiacao) VALUES
            (@NOME, @MODO_PRESENCIAL, @DATA_INICIO, @DATA_TERMINO, @PREMIACAO);";

            //comando.Parameters.AddWithValue("@NOME", grupo.Nome.Id);
            //comando.Parameters.AddWithValue("@MODO_PRESENCIAL", grupo.ModoTorneio.Id);
            //comando.Parameters.AddWithValue("@DATA_INICIO", grupo.DataInicio.Id);
            //comando.Parameters.AddWithValue("@DATA_TERMINO", grupo.DataTermino.Id);
            //comando.Parameters.AddWithValue("@PREMIACAO", grupo.Premiacao.Id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(CampeonatoService campeonatoService)
        {

        }

        public CampeonatoService ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<CampeonatoService> ObterTodos()
        {
            throw new NotImplementedException();
        }

        //public CampeonatoService ObterPorId(int id)
        //{

        //}

        //public List<CampeonatoService> ObterTodos()
        //{

        //}
    }
}
