using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

namespace Cudovista.Mapiranja
{
    public class Magijsko_cudovisteMapiranja : SubclassMap<Magijsko_cudoviste>
    {
        public Magijsko_cudovisteMapiranja()
        {
            Table("Magijsko_cudoviste");

            KeyColumn("Id");

            Map(x => x.Da_li_postoji).Column("Da_li_postoji");
        }
    }
}

