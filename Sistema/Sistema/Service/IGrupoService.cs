using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal interface IGrupoService
    {
        void Cadastrar(Grupo grupo);
        List<Grupo> ObterTodos();
        void Editar(Grupo grupo);
        Grupo ObterPorId(int id);
        void Apagar(int id);
    }
}