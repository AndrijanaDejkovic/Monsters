﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public abstract class Materijal
    {
        public virtual int ID { get; set; }

        public virtual string Tip_Materijala { get; set; }

        public virtual Predmet Pripada_predmetu { get; set; }
    }

    public class Zlato : Materijal
    {

    }

    public class Srebro : Materijal
    {

    }

    public class Papir : Materijal
    {

    }
    public class Dijamant : Materijal
    {

    }

    public class Metal : Materijal
    {

    }
}
