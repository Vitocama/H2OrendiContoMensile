using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H20RendiContoMensile
{
 
        public class RendiContoAnnuale2025Anagrafe
        {
        public int Id { get; set; }

        public string cmd { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Cognome { get; set; } = string.Empty;

        public DateTime DataNascita { get; set; }

        public DateTime? LuogoDiNascita { get; set; } // Probabilmente è un errore nel tipo: dovrebbe essere stringa

        public string? Residenza { get; set; }

        public string? Email { get; set; }

        public string? Contatto { get; set; }
    }

    }

