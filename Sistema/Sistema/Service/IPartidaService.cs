using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal interface IPartidaService
    {
        void Cadastrar(Partida partida);
        List<Partida> ObterTodos();
        void Editar(Partida partida);
        Partida ObterPorId(int id);
        void Apagar(int id);
    }
}