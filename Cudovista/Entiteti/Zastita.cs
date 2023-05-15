﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Zastita
    {
        public virtual int ID { get; set; }
        public virtual string Naziv { get; set; }
       // public virtual string Tip_zastite { get; set; }
        public virtual Lokacija Id_lokacije { get; set; }


    }
    public class Duh : Zastita
    {

    }
    public class Zmaj : Zastita
    {

    }
    public class Kletva : Zastita
    {

    }
}
