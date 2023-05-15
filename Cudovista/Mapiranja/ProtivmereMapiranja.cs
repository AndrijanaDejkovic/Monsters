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

            Table("PROTIVMERE");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv_protivmere).Column("NAZIV_PROTIVMERE");
            Map(x => x.Opis_protivmere).Column("OPIS_PROTIVMERE");
            Map(x => x.Da_li_uslovi).Column("DA_LI_USLOVI");

            //mapiranje veze 1:N Cudoviste-Protuvmera
            References(x => x.Id_cudovista).Column("ID_PROTIVMERE").LazyLoad();

        }
    }
}

