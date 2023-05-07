using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class LegendeMapiranja : SubclassMap<Legende>
    {
        public LegendeMapiranja()
        {
            Table("Legende");

            KeyColumn("Id");

            Map(x => x.Tekst).Column("Tekst");
            Map(x => x.Prvo_pominjanje).Column("Prvo_pominjanje");
            Map(x => x.Zemlja_porekla).Column("Zemlja_porekla");

        }
    }
}

