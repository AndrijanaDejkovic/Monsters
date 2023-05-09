using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class ZastitaMapiranja : ClassMap<Zastita>
    {
        public ZastitaMapiranja()
        {
            Table("Zastita");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv).Column("Naziv");
            Map(x => x.Tip_zastite).Column("Tip_zastite");
        }
    }
}

