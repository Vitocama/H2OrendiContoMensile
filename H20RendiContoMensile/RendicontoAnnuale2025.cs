using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H20RendiContoMensile
{
    public class RendicontoAnnuale2025
    {
        public int Id { get; set; }

        public string Cmd { get; set; } = string.Empty;  // varchar(50) NOT NULL

        public string Gennaio { get; set; } = string.Empty;   // varchar(5) NOT NULL
        public string Febbraio { get; set; } = string.Empty;
        public string Marzo { get; set; } = string.Empty;
        public string Aprile { get; set; } = string.Empty;
        public string Maggio { get; set; } = string.Empty;
        public string Giugno { get; set; } = string.Empty;
        public string Luglio { get; set; } = string.Empty;
        public string Agosto { get; set; } = string.Empty;
        public string Settembre { get; set; } = string.Empty;
        public string Ottobre { get; set; } = string.Empty;
        public string Novembre { get; set; } = string.Empty;
        public string Dicembre { get; set; } = string.Empty;

        public int NumeroBottiglie { get; set; }  // int NOT NULL

        public DateTime UltimaDataLettura { get; set; }  // nullable DATE
    }
}
