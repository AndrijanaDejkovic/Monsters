﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Legende
    {
        public virtual int ID { get; set; }
        public virtual string Tekst { get; set; }
        public virtual DateTime Prvo_pominjanje { get; set; }
        public virtual string Zemlja_porekla { get; set; }
        public virtual Cudoviste Id_cudovista { get; set; } //vidi jel dobro ovo ime

    }
}
