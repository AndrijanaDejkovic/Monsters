using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class ProtivmereMapiranja : ClassMap<Protivmere>
    {
        public ProtivmereMapiranja()
        {

            Table("Protivmere");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv_protivmere).Column("Naziv_protivmere");
            Map(x => x.Opis_protivmere).Column("Opis_protivmere");
            Map(x => x.Da_li_uslovi).Column("Da_li_uslovi");

            //mapiranje veze 1:N Cudoviste-Protuvmera
            References(x => x.PropadaCudovistu).Column("ID_Cudovista").LazyLoad();

        }
    }
}

