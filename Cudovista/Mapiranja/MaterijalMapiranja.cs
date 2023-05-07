using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
   
    public class MaterijalMapiranja : SubclassMap<Materijal>
    {
        public MaterijalMapiranja()
        {

            Table("Materijal");

            KeyColumn("Id");

            Map(x => x.Tip_materijala).Column("Tip_materijala");
        }
    }
}

