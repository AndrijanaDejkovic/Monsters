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
            Table("ZASTITA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv).Column("Naziv");
            References(x => x.Id_lokacije).Column("BROJP").LazyLoad();
        }
    }
    class DuhMapiranja : SubclassMap<Duh>
    {
        public DuhMapiranja()
        {
            DiscriminatorValue("Duh");
        }
    }

    class ZmajMapiranja : SubclassMap<Zmaj>
    {
        public ZmajMapiranja()
        {
            DiscriminatorValue("Duh");
        }
    }

    class KletvaMapiranja : SubclassMap<Kletva>
    {
        public KletvaMapiranja()
        {
            DiscriminatorValue("Duh");
        }
    }


}

