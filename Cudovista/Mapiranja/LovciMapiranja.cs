using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class LovciMapiranja : SubclassMap<Lovci>
    {
        public LovciMapiranja()
        {
            Table("Lovci");

            KeyColumn("Id");

            Map(x => x.Ime_lovca).Column("Ime_lovca");
        }
    }
}

