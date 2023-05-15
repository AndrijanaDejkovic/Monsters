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

            Table("MATERIJALI");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Pripada_predmetu).Unique().Column("ID_MATERIJALA").LazyLoad();

        }

    }
    class ZlatoMapiranja : SubclassMap<Zlato>
    {
        public ZlatoMapiranja()
        {
            DiscriminatorValue("Zlato");
        }
    }
    class SrebroMapiranja : SubclassMap<Srebro>
    {
        public SrebroMapiranja()
        {
            DiscriminatorValue("Srebro");
        }
    }
    class PapirMapiranja : SubclassMap<Papir>
    {
        public PapirMapiranja()
        {
            DiscriminatorValue("Papir");
        }
    }
    class DijamantMapiranja : SubclassMap<Dijamant>
    {
        public DijamantMapiranja()
        {
            DiscriminatorValue("Dijamant");
        }
    }
    class MetalMapiranja : SubclassMap<Metal>
    {
        public MetalMapiranja()
        {
            DiscriminatorValue("Metal");
        }
    }
}

