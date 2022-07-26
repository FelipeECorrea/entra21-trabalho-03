using Sistema.Database;
using System.Data.SqlClient;

namespace Sistema.Service
{
    class UsuarioCadastrados
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
                comando.Connection.Close();
                dr.Close();
            }
            catch (SqlException)
            {
                this.aviso = "Erro com banco de Dados!";
            }

            return validar;
        }

        public string cadastrar(string usuario, string email, string senha, string csenha)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            validar = false;

            if (senha.Equals(csenha))
            {
                comando.CommandText = "INSERT INTO contas VALUES (@USUARIO,@EMAIL,@SENHA);";
                comando.Parameters.AddWithValue("@USUARIO", usuario);
                comando.Parameters.AddWithValue("@EMAIL", email);
                comando.Parameters.AddWithValue("@SENHA", senha);

                try
                {
                    comando.Connection = acessar.Conectar();

                    comando.ExecuteNonQuery();

                    comando.Connection.Close();
                    this.aviso = "Usuario cadastrado com sucesso!";
                    validar = true;
                }
                catch (SqlException)
                {
                    this.aviso = "Erro com Banco de Dados";
                }
            }
            else
            {
                this.aviso = "Senhas não correspondem!";
            }

            comando.CommandText = "";

            return aviso;
        }
    }
}
