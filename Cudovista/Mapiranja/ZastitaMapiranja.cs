using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class ZastitaMapiranja : SubclassMap<Zastita>
    {
        public ZastitaMapiranja()
        {
            Table("Zastita");

            KeyColumn("Id");

            Map(x => x.Naziv).Column("Naziv");
            Map(x => x.Tip_zastite).Column("Tip_zastite");
        }
    }
}

