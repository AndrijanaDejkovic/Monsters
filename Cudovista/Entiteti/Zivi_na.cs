using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Zivi_na
    {
        public virtual int ID { get; set; }
        public virtual int Id_lokacije { get; set; }
        public virtual int Id_predstavnika { get; set; }
        public virtual Predstavnik predstavnikZivi { get; set; }
        public virtual Lokacija lokacijaZivota { get; set; }


    }
}