using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Jogadores
    {
            public int Id { get; set; }
            public string Email { get; set; }
            public string Apelido { get; set; }
            public string Senha { get; set; }
            public DateTime DataCriacao { get; set; }
            public string Patente { get; set; }
            public string Time { get; set; }

    }
}
