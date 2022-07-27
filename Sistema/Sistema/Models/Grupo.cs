namespace Sistema.Models
{
    internal class Grupo
    {
        public int Id { get; set; }

        public Time Time { get; set; }
        public Torneio Torneio { get; set; }
        public Transmissao Transmissao { get; set; }
    }
}
