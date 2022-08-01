using System;

namespace Sistema.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Patente { get; set; }
        public Time Time { get; set; }
    }
}
