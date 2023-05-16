using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

namespace Cudovista.Mapiranja
{
    public class LovacMapiranja : ClassMap<Lovac>
    {
        public LovacMapiranja()
        {
            Table("LOVAC");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime_lovca).Column("IME_LOVCA");

            References(x => x.Id_predstavnika).Column("Id_predstavnika").LazyLoad();
        }
    }
}

