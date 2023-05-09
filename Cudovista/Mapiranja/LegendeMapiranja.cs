using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class LegendeMapiranja : ClassMap<Legende>
    {
        public LegendeMapiranja()
        {
            Table("Legende");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Tekst).Column("Tekst");
            Map(x => x.Prvo_pominjanje).Column("Prvo_pominjanje");
            Map(x => x.Zemlja_porekla).Column("Zemlja_porekla");

            //mapiranje veze 1:N Cudoviste-Legende
            References(x => x.PropadaCudovistu).Column("ID_Cudovista").LazyLoad();

        }
    }
}

