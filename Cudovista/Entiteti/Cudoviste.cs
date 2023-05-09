using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Cudoviste
    {
        public virtual int Id { get; set; }
        public virtual int Vek { get; set; }
        public virtual string Naziv_cudovista { get; set; }
        public virtual string Podtip { get; set; }

        public virtual IList<Protivmere> Protivmere { get; set; }
        public virtual IList<Predmet> Predmeti { get; set; }
        public virtual IList<Predstavnici> Predstavnici { get; set; }
        public virtual IList<Legende> Legende { get; set; }




        public void Cudovist()
        {
            Protivmere = new List<Protivmere>();
            Predmeti = new List<Predmet>();
            Predstavnici = new List<Predstavnici>();
            Legende = new List<Legende>();

        }
    }
}
