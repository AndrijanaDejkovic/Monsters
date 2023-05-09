using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

namespace Cudovista.Mapiranja
{

    public class CudovisteMapiranja : ClassMap<Cudoviste>
	{
		public CudovisteMapiranja()
		{
            Table("Cudoviste"); //proveri da li su tabele veliki slovima

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Vek).Column("Vek");
            Map(x => x.Naziv_cudovista).Column("Naziv_cudovista");
            Map(x => x.Podtip).Column("Podtip");

            HasMany(x => x.Predmeti).KeyColumn("ID_Predmeta").LazyLoad().Cascade.All().Inverse(); //proveri imena kolona
            HasMany(x => x.Legende).KeyColumn("ID_Legende").LazyLoad().Cascade.All().Inverse(); //proveri
            HasMany(x => x.Predstavnici).KeyColumn("ID_Predstavnika").LazyLoad().Cascade.All().Inverse(); //proveri
            HasMany(x => x.Protivmere).KeyColumn("ID_Protivmere").LazyLoad().Cascade.All().Inverse(); //proveri

        }
	}
}
