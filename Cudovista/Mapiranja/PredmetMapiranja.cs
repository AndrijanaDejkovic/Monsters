using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class PredmetMapiranja : SubclassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("Predmet");

            KeyColumn("Id");

            Map(x => x.Tip_predmeta).Column("Tip_predmeta");
        }
    }

}
