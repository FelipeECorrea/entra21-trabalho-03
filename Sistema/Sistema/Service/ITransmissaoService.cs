using Sistema.Models;
using System.Collections.Generic;

namespace Sistema.Service
{
    internal interface ITransmissaoService
    {
        List<Live> ObterTodos();
        Live ObterPorId(int id);
        void Cadastrar(Live transmissao);
        void Editar(Live transmissao);
        void Apagar(int id);
    }
}
