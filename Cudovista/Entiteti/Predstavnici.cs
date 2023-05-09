using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Predstavnici
    {
        public virtual int Id { get; set; }
        public virtual string Ime_predstavnika { get; set; }
        public virtual int Starost { get; set; }
        public virtual DateTime Datum_susreta { get; set; }
        public virtual string Ishod { get; set; }
        public virtual Cudoviste PropadaCudovistu { get; set; }

    }
}
