﻿/*using System;
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
            Table("MAGIJSKO_CUDOVISTE");

            KeyColumn("ID_Magijskog");

            Map(x => x.Da_li_postoji).Column("DA_LI_POSTOJI");

            HasMany(x=>x.Poseduje_sposobnosti).KeyColumn("ID_MAGIJSKOG").LazyLoad().Cascade.All().Inverse();
        }
    }
}

*/