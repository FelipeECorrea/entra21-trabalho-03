using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal interface ITimeService
    {
        List<Time> ObterTodos();
    }
}