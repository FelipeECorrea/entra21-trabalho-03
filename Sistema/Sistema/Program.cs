using Sistema.Views;
using Sistema.Views.Campeonato;
using Sistema.Views.Jogadores;
using Sistema.Views.Times;
using Sistema.Views.Transmissao;
using System;
using System.Windows.Forms;

namespace Sistema
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CadastroJogadoresForm());
        }
    }
}