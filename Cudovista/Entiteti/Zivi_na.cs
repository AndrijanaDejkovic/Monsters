using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    internal class Zivi_na
    {
        public int ID { get; set; }
        public IList<Lokacija> Id_lokacija { get; set; }
        public IList<Predstavnik> Id_predstavnika { get; set; }
    }
}
