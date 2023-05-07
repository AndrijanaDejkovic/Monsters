using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class PredstavniciMapiranja : SubclassMap<Predstavnici>
    {
        public PredstavniciMapiranja()
        {
            Table("Predstavnici");

            KeyColumn("Id");

            Map(x => x.Ime_predstavnika).Column("Ime_predstavnika");
            Map(x => x.Starost).Column("Starost");
            Map(x => x.Datum_susreta).Column("Datum_susreta");
            Map(x => x.Ishod).Column("Ishod");

        }
    }
}

