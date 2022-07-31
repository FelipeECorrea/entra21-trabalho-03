using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal interface ITimeService
    {
        void Cadastrar(Time time);
        List<Time> ObterTodos();
        void Apagar(int id);
        Time ObterPorId(int id);
        void Editar(Time time);
    }
}