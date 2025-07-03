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

            public string Cmd { get; set; } = string.Empty;  // NOT NULL

            public int Gennaio { get; set; }
            public int Febbraio { get; set; }
            public int Marzo { get; set; }
            public int Aprile { get; set; }
            public int Maggio { get; set; }
            public int Giugno { get; set; }
            public int Luglio { get; set; }
            public int Agosto { get; set; }
            public int Settembre { get; set; }
            public int Ottobre { get; set; }
            public int Novembre { get; set; }
            public int Dicembre { get; set; }

            public int NumeroBottiglie { get; set; }

            // Relazione (opzionale, se stai usando ORM come Entity Framework)
            // public virtual RendiContoAnnuale2025Anagrafe Anagrafe { get; set; }
        }

    
}
