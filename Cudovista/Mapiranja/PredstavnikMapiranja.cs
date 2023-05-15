﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class PredstavnikMapiranja : ClassMap<Predstavnik>
    {
        public PredstavnikMapiranja()
        {
            Table("PREDSTAVNIK");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime_predstavnika).Column("IME_PREDSTAVNIKA");
            Map(x => x.Starost).Column("STAROST");
            Map(x => x.Datum_susreta).Column("DATUM_SUSRETA");
            Map(x => x.Ishod).Column("ISHOD");

            //mapiranje veze 1:N Cudoviste-Predstavnik
            References(x => x.Id_cudovista).Column("ID_PREDSATVNIKA").LazyLoad();
            HasOne(x => x.Id_lokacije).Cascade.All();
            HasMany(x => x.Love_ga).KeyColumn("ID_PREDSATVNIKA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
