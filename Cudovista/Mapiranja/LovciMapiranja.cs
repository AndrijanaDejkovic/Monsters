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
            Table("LOVCI");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Id_predstavnika).Column("ID_LOVCA").LazyLoad();
        }
    }
}

