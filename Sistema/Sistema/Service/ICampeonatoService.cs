using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal interface ICampeonatoService
    {
        List<Torneio> ObterTodos();
        Torneio ObterPorId(int id);
        void Cadastrar(Torneio torneio);
        void Editar(Torneio torneio);
        void Apagar(int id);
    }
}
