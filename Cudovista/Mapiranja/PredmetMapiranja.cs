/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;
using System.Threading.Tasks;
namespace Cudovista.Mapiranja
{
    public class PredmetMapiranja : ClassMap<Predmet>
    {
        public PredmetMapiranja()
        {
            Table("PREDMET");

            //MAPIRANJE PODKLASA
            DiscriminateSubClassesOnColumn("Tip_Predmeta");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje veze 1:N Cudoviste-Predmet
            References(x => x.Id_cudovista).Column("Id_cudovista").LazyLoad();
            //MAPIRANJE ONE TO ONE
            // References(x => x.Id_materijala).Column("ID_MATERIJALA").Unique().LazyLoad();

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
*/