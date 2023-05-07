using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Protivmere
    {
        public virtual int Id { get; set; }
        public virtual string Naziv_protivmere { get; set; }
        public virtual string Opis_protivmere { get; set; }
        public virtual int Da_li_uslovi { get; set; }

    }
}
