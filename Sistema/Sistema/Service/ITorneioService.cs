using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal interface ITorneioService
    {
        List<Torneio> ObterTodos();
    }
}