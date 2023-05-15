using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Predmet
    {
        public virtual int ID { get; set; }
        public virtual Cudoviste Id_cudovista { get; set; }
        public Materijal Id_materijala { get; set; }

        //public virtual string Tip_predmeta { get; set; }
        //isto kao kod materijala se brise tip
    }

    public class Lobanja : Predmet
    {

    }

    public class    Krst : Predmet
    {

    }
    public class Mac : Predmet
    {

    }

    public class Knjiga : Predmet
    {

    }
}
