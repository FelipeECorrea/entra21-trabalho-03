﻿using System;
using System.Data.SqlClient;
using System.IO;

namespace Sistema.Database
{
    internal class Conexao
    {
        public SqlCommand ConectarCriandoComando()
        {
            var conexao = new SqlConnection();

            var nomeBanco = "Sistema";
            var caminhoCompleto = Directory.GetCurrentDirectory().Substring(0, AppContext.BaseDirectory.LastIndexOf("\\bin"));
            conexao.ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminhoCompleto}\Database\{nomeBanco}.mdf;Integrated Security=True";

            conexao.Open();

            var comando = conexao.CreateCommand();

            return comando;
        }
    }
}
