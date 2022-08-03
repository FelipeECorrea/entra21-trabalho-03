using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Live
    {
		public int Id { get; set; }
		public string NomeLive { get; set; }
		public string NomeNarrador { get; set; }
		public string Plataforma { get; set; }
		public string IdiomaTransmissao { get; set; }

		//INNER JOIN
		public Torneio Torneio { get; set; }
	}
}
