using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal class IJogadorServiceBase
    {
        void Cadastrar(Jogador jogador);
        List<Jogador> ObterTodos();
        void Apagar(int id);
        Jogador ObterPorId(int id);
        void Editar(Jogador);
    }
}