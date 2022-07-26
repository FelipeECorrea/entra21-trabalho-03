using Sistema.Database;
using System.Data.SqlClient;

namespace Sistema.Service
{
    class UsuariosCadastrado
    {
        public bool validar = false;
        public string aviso = "";
        Conexao acessar = new Conexao();
        SqlDataReader dr; 
        public bool verificarCadastro(string email, string senha)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT email, senha FROM contas WHERE email = @EMAIL and senha = @SENHA";
            comando.Parameters.AddWithValue("@EMAIL", email);
            comando.Parameters.AddWithValue("@SENHA", senha);

            try
            {
                comando.Connection = acessar.Conectar();
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    validar = true;
                }
            }
            catch (SqlException)
            {
                this.aviso = "Erro com banco de Dados!";
            }

            return validar;
        }

        public string cadastrar(string email, string login, string senha, string csenha)
        {
            return aviso;
        }
    }
}
