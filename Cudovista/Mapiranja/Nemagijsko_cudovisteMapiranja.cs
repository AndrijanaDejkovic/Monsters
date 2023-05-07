using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class Nemagijsko_cudovisteMapiranja : SubclassMap<Nemagijsko_cudoviste>
    {
        public Nemagijsko_cudovisteMapiranja()
        {

            Table("Nemagijsko_cudoviste");

            KeyColumn("Id");

            Map(x => x.Da_li_zivi_u_vodi).Column("Da_li_zivi_u_vodi");
            Map(x => x.Da_li_leti).Column("Da_li_leti");
            Map(x => x.Da_li_ima_rep).Column("Da_li_ima_rep");
            Map(x => x.Da_li_je_otrovno).Column("Da_li_je_otrovno");
            Map(x => x.Da_li_ima_kandze).Column("Da_li_ima_kandze");
            Map(x => x.Broj_ociju).Column("Broj_ociju");
            Map(x => x.Broj_ekstremiteta).Column("Broj_ekstremiteta");
            Map(x => x.Duzina).Column("Duzina");
            Map(x => x.Tezina).Column("Tezina");

        }

    }

}
