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
            UsuarioCadastrados loginUsuario = new UsuarioCadastrados();
            validar = loginUsuario.verificarCadastro(email, senha);

            if (loginUsuario.aviso.Equals(""))
            {
                this.aviso = loginUsuario.aviso;
            }
            return validar;
        }

        public string Cadastrar(string usuario, string email, string senha, string csenha)
        {
            UsuarioCadastrados loginUsuario = new UsuarioCadastrados();
            this.aviso = loginUsuario.cadastrar(usuario, email, senha, csenha);
            if (loginUsuario.validar)
            {
                this.validar = true;
            }
            return aviso;
        }
    }
}
