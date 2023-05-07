using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

namespace Cudovista.Mapiranja
{

    public class CudovisteMapiranja : SubclassMap<Cudoviste>
	{
		public CudovisteMapiranja()
		{
            Table("Cudoviste"); //proveri da li su tabele veliki slovima

            KeyColumn("Id");

            Map(x => x.Vek).Column("Vek");
            Map(x => x.Naziv_cudovista).Column("Naziv_cudovista");
            Map(x => x.Podtip).Column("Podtip");
        }
	}
}
