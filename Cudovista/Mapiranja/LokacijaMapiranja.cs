/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Cudovista.Entiteti;

namespace Cudovista.Mapiranja
{
    public class LokacijaMapiranja : ClassMap<Lokacija>
    {
        public LokacijaMapiranja()
        {
            Table("LOKACIJA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            DiscriminateSubClassesOnColumn("Tip_lokacije");
            Map(x => x.Naziv_lokacije).Column("NAZIV_LOKACIJE");
           // Map(x => x.tip).Column("Tip_lokacije");
            Map(x => x.Zemlja).Column("ZENLJA");
            Map(x => x.Blago).Column("BLAGO");

            References(x => x.Borio_se).Unique().Column("Borio_se").LazyLoad();
         //   HasMany(x => x.Zastite).KeyColumn("ID_LOKACIJE").LazyLoad().Cascade.All().Inverse();
        }
    }
*//*
    class GrobnicaMapiranja : SubclassMap<Lokacija>
    {
        public GrobnicaMapiranja()
        {
            DiscriminatorValue("Grobnica");
        }
    }
    class OstrvoMapiranja : SubclassMap<Lokacija>
    {
        public OstrvoMapiranja()
        {
            DiscriminatorValue("Ostrvo");
        }
    }
    class PecinaMapiranja : SubclassMap<Lokacija>
    {
        public PecinaMapiranja()
        {
            DiscriminatorValue("Pecina");
        }
    }
    class Grad_duhovaMapiranja : SubclassMap<Lokacija>
    {
        public Grad_duhovaMapiranja()
        {
            DiscriminatorValue("Grad_duhova");
        }
    }
    class PiramidaMapiranja : SubclassMap<Lokacija>
    {
        public PiramidaMapiranja()
        {
            DiscriminatorValue("Piramida");
        }
    }
    class Ukleti_zamakMapiranja : SubclassMap<Lokacija>
    {
        public Ukleti_zamakMapiranja()
        {
            DiscriminatorValue("Ukleti_zamak");
        }
    }*//*
}

*/