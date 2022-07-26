using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Service
{
    public class Controle
    {
        public bool validar;
        public string aviso = "";
        public bool AcessarProg(string email, string senha)
        {
            UsuariosCadastrado loginUsuario = new UsuariosCadastrado();
            validar = loginUsuario.verificarCadastro(email, senha);

            if (loginUsuario.aviso.Equals(""))
            {
                this.aviso = loginUsuario.aviso;
            }
            return validar;
        }

        public string Cadastrar(string email, string senha, string csenha)
        {
            return aviso;
        }
    }
}
