using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class Specijalne_sposobnostiMapiranja : SubclassMap<Specijalne_sposobnosti>
    {
        public Specijalne_sposobnostiMapiranja()
        {
            Table("Specijalne_sposobnosti");

            KeyColumn("Spec_Sposobnosti"); //ovo se menja ako dodajemo id

            Map(x => x.Spec_sposobnosti).Column("Spec_sposobnosti");
            //ovo stoji ako dodajemo sposobnosti
        }
    }

}
