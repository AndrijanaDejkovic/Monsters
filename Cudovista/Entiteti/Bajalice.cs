using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Bajalice
    {
        public virtual int ID { get; set; }
        public virtual string Bajalica { get; set; }
        public virtual Cudoviste Id_cudovista { get; set; }
    }
}
