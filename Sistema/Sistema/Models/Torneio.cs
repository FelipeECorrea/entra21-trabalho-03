using System;

namespace Sistema.Models
{
    public class Torneio
    {
		public int Id { get; set; }
		public string Nome { get; set; }
		public bool ModoPresencial { get; set; }
		public DateTime DataInicio { get; set; }
		public DateTime DataTermino { get; set; }
		public decimal Premiacao { get; set; }
    }
}