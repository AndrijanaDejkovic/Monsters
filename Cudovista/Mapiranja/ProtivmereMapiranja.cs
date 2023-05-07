using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class ProtivmereMapiranja : SubclassMap<Protivmere>
    {
        public ProtivmereMapiranja()
        {

            Table("Protivmere");

            KeyColumn("Id");

            Map(x => x.Naziv_protivmere).Column("Naziv_protivmere");
            Map(x => x.Opis_protivmere).Column("Opis_protivmere");
            Map(x => x.Da_li_uslovi).Column("Da_li_uslovi");

        }
    }
}

