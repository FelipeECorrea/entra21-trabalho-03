namespace Sistema.Models
{
    internal class Transmissao
    {
		public int Id { get; set; }
		public string NomeLive { get; set; }
		public string NomeNarrador { get; set; }
		public string Plataforma { get; set; }
		public bool IdiomaPortugues { get; set; }
		public bool IdiomaIngles { get; set; }
		public bool IdiomaEspanhol { get; set; }

		public Torneio Torneio { get; set; }
    }
}