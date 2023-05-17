using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cudovista.Entiteti;
using FluentNHibernate.Mapping;

namespace Cudovista.Mapiranja
{
    public class Zivi_naMapiranja : ClassMap<Zivi_na>
    {
        public Zivi_naMapiranja()
        {
            Table("ZIVI_NA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.predstavnikZivi).Column("Id_lokacije");
            References(x => x.lokacijaZivota).Column("Id_predstavnika");

        }
    }
}