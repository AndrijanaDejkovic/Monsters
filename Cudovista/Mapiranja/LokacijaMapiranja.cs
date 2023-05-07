using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

namespace Cudovista.Mapiranja
{
    public class LokacijaMapiranja : SubclassMap<Lokacija>
    {
        public LokacijaMapiranja()
        {
            Table("Lokacija");

            KeyColumn("Id");

            Map(x => x.Naziv_lokacije).Column("Naziv_lokacije");
            Map(x => x.Tip_lokacije).Column("Tip_lokacije");
            Map(x => x.Zemlja).Column("Zemlja");
            Map(x => x.Blago).Column("Blago");

        }
    }
}

