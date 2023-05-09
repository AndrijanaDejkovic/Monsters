using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Magijsko_cudoviste : Cudoviste
    {
        public virtual int Id { get; set; }
        public virtual int Da_li_postoji { get; set; }
    }
}
