using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

namespace Cudovista.Mapiranja
{
    public class BajaliceMapiranja : SubclassMap<Bajalice>
    {
        public BajaliceMapiranja()
        {
            Table("Bajalice");

            KeyColumn("Bajalica");

            Map(x => x.Bajalica).Column("Bajalica");
        }
    }
}

