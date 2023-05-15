using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

namespace Cudovista.Mapiranja
{

    public class CudovisteMapiranja : ClassMap<Cudovista.Entiteti.Cudoviste>
	{
		public CudovisteMapiranja()
		{
            Table("CUDOVISTE"); //proveri da li su tabele veliki slovima

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Vek).Column("VEK");
            Map(x => x.Naziv_cudovista).Column("NAZIV_CUDOVISTA");
            Map(x => x.Podtip).Column("PODTIP");

            HasMany(x => x.Predmeti).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse(); 
            HasMany(x => x.Legende).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse(); 
            HasMany(x => x.Predstavnici).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse(); 
            HasMany(x => x.Protivmere).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Bajalice).KeyColumn("Id_cudovista").LazyLoad().Cascade.All().Inverse();

        }
	}
}
