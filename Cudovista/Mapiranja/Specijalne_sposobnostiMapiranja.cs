using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class Specijalne_sposobnostiMapiranja : ClassMap<Specijalne_sposobnosti>
    {
        public Specijalne_sposobnostiMapiranja()
        {
            Table("Specijalne_sposobnosti");

            //KeyColumn("Spec_Sposobnosti"); //treba da se pita aleksandar za id sta da se radi

            Map(x => x.Spec_sposobnosti).Column("Spec_sposobnosti");
            //ovo stoji ako dodajemo sposobnosti
        }
    }

}
