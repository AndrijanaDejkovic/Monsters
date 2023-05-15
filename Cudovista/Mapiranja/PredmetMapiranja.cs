using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

 namespace Cudovista.Mapiranja
{
    public class PredmetMapiranja : ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("Predmet");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje veze 1:N Cudoviste-Predmet
            References(x => x.Id_cudovista).Column("ID_PREDMETA").LazyLoad();
            HasOne(x => x.Id_materijala).Cascade.All();
        }
    }
    class LobanjaMapiranja : SubclassMap<Lobanja>
    {
        public LobanjaMapiranja()
        {
            DiscriminatorValue("Lobanja");
        }
    }
    class KrstMapiranja : SubclassMap<Krst>
    {
        public KrstMapiranja()
        {
            DiscriminatorValue("Krst");
        }
    }
    class MacMapiranja : SubclassMap<Mac>
    {
        public MacMapiranja()
        {
            DiscriminatorValue("Mac");
        }
    }
    class KnjigaMapiranja : SubclassMap<Knjiga>
    {
        public KnjigaMapiranja()
        {
            DiscriminatorValue("Knjiga");
        }
    }
}
