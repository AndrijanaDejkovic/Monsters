using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class Magisjke_sposobnostiMapiranja : ClassMap<Magijske_sposobnosti>
    {

        public Magisjke_sposobnostiMapiranja()
        {
            Table("Magijske_sposobnosti");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv_sposobnosti).Column("Naziv_sposobnosti");
            Map(x => x.Da_li_je_odbrambena).Column("Da_li_je_odbrambena");
            Map(x => x.Opis_sposobnosti).Column("Opis_sposobnosti");

        }
    }
}

