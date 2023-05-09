using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Predmet
    {
        public virtual int Id { get; set; }
        public virtual Cudoviste PropadaCudovistu { get; set; }

        //public virtual string Tip_predmeta { get; set; }
        //isto kao kod materijala se brise tip
    }

    public class Lobanja : Predmet
    {

    }

    public class krst : Predmet
    {

    }
    public class Mac : Predmet
    {

    }

    public class Knjiga : Predmet
    {

    }
}
