using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal interface IJogadorService
    {
        List<Jogador> ObterTodos();
        Jogador ObterPorId(int id);
        void Cadastrar(Jogador jogador);
        void Apagar(int id);
        void Editar(Jogador jogador);
    }
}