using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
   
    public class MaterijalMapiranja : ClassMap<Materijal>
    {
        public MaterijalMapiranja()
        {

            Table("Materijal");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

        }
    }
}

