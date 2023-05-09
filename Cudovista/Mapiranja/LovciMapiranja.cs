using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class LovciMapiranja : ClassMap<Lovci>
    {
        public LovciMapiranja()
        {
            Table("Lovci");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime_lovca).Column("Ime_lovca");
        }
    }
}

