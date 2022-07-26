using System;
using System.Data.SqlClient;
using System.IO;

namespace Sistema.Database
{
    public class Conexao
    {
        internal SqlConnection Conectar()
        {
            var conexao = new SqlConnection();

            var nomeBanco = "Sistema";
            var caminhoCompleto = Directory.GetCurrentDirectory().Substring(0, AppContext.BaseDirectory.LastIndexOf("\\bin"));
            conexao.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminhoCompleto}\Database\{nomeBanco}.mdf;Integrated Security=True";

            conexao.Open();

            return conexao;
        }
    }
}
