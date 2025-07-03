using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H20RendiContoMensile
{
    public class ComuneCap
    {
        public string CodiceIstat { get; set; }
        public string DenominazioneItaAltra { get; set; }
        public string DenominazioneIta { get; set; }
        public string DenominazioneAltra { get; set; }
        public string Cap { get; set; }
        public string SiglaProvincia { get; set; }
        public string DenominazioneProvincia { get; set; }
        public string TipologiaProvincia { get; set; }
        public string CodiceRegione { get; set; }
        public string DenominazioneRegione { get; set; }
        public string TipologiaRegione { get; set; }
        public string RipartizioneGeografica { get; set; }
        public string FlagCapoluogo { get; set; }
        public string CodiceBelfiore { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double SuperficieKmq { get; set; }
    }
}
