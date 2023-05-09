using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class PredmetMapiranja : ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("Predmet");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje veze 1:N Cudoviste-Predmet
            References(x => x.PropadaCudovistu).Column("ID_Cudovista").LazyLoad();

        }
    }

}
