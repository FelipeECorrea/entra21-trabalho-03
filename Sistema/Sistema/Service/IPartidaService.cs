using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal interface IPartidaService
    {
        void Cadastrar(Partida partida);
        List<Partida> ObterTodos();
        Partida ObterPorId(int id);
        void Apagar(int id);
    }
}