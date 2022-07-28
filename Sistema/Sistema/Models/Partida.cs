namespace Sistema.Models
{
    public class Partida
    {
        public int Id { get; set; }
        public string PartidaSorteada { get; set; }
        public bool MapaMirage { get; set; }
        public bool MapaDust2 { get; set; }
        public bool MapaOverpass { get; set; }
        public bool MapaVertigo { get; set; }
        public bool MapaNuke { get; set; }
        public bool MapaInferno { get; set; }
        public bool MapaAncient { get; set; }
    }
}
