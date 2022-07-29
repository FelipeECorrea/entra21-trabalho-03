using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Service
{
    internal interface ICampeonatoService
    {
        void Cadastrar(CampeonatoService campeonatoService);
        List<CampeonatoService> ObterTodos();
        void Editar(CampeonatoService campeonatoService);
        CampeonatoService ObterPorId(int id);
        void Apagar(int id);
    }
}
