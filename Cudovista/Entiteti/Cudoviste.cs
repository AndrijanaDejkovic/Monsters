﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cudovista.Entiteti
{
    public class Cudoviste
    {
        public virtual int Id  { get; set; }
        public virtual int Vek { get; set; }
        public virtual string Naziv_cudovista { get; set; }
        public virtual string Podtip { get; set; }
    }
}
