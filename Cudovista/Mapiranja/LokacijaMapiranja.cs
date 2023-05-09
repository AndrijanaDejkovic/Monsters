using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

namespace Cudovista.Mapiranja
{
    public class LokacijaMapiranja : ClassMap<Lokacija>
    {
        public LokacijaMapiranja()
        {
            Table("Lokacija");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv_lokacije).Column("Naziv_lokacije");
            Map(x => x.Tip_lokacije).Column("Tip_lokacije");
            Map(x => x.Zemlja).Column("Zemlja");
            Map(x => x.Blago).Column("Blago");

        }
    }
}

