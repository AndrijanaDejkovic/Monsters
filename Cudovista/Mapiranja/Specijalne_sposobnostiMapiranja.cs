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
            Table("SPECIJALNE_SPOSOBNOSTI");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Spec_sposobnosti).Column("SPEC_SPOSOBNOSTI");
    
            References(x => x.Id_cudovista).Column("ID_SPOSOBNOSTI").LazyLoad();
        }
    }

}
