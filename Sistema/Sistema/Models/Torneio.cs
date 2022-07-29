using System;

namespace Sistema.Models
{
    public class Torneio
    {
		public int Id { get; set; }
		public string Nome { get; set; }
		public string ModoJogo { get; set; }
		public string ModoPresencial { get; set; }
		public DateTime DataInicio { get; set; }
		public DateTime DataTermino { get; set; }
		public string Categoria { get; set; }
		public string Premiacao { get; set; }
    }
}