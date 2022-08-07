using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal interface ITransmissaoService
    {
        List<Live> ObterTodos();
        Live ObterPorId(int id);
        void Cadastrar(Live live);
        void Editar(Live live);
        void Apagar(int id);
    }
}
