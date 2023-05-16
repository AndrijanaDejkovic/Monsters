using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

namespace Cudovista.Mapiranja
{
    public class BajaliceMapiranja : ClassMap<Bajalice>
    {
        public BajaliceMapiranja()
        {
            Table("Bajalice");

            Id(x => x.ID, "ID").GeneratedBy.SequenceIdentity();

            Map(x => x.Bajalica).Column("Bajalica");
            References(x => x.Id_cudovista).Column("Id_cudovista").LazyLoad();
        }
    }
}