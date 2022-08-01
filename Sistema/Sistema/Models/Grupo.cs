namespace Sistema.Models
{
    public class Grupo
    {
        public int Id { get; set; }

        public Time Time { get; set; }
        public Torneio Torneio { get; set; }
        public Live Transmissao { get; set; }
    }
}
