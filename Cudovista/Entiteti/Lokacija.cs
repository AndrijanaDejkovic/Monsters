using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Lokacija
    {
        public virtual int Id { get; set; }
        public virtual string Naziv_lokacije { get; set; }
        public virtual string Tip_lokacije { get; set; }
        public virtual string Zemlja { get; set; }
        public virtual string Blago { get; set; }
    }
}
