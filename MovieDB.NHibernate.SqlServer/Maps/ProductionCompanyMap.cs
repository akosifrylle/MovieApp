using FluentNHibernate.Mapping;
using MovieDB.NHibernate.Repo;

namespace MovieDB.NHibernate.SqlServer.Maps
{
    public class ProductionCompanyMap : ClassMap<ProductionCompanyRepo>
    {
        public ProductionCompanyMap()
        {
            Table("ProductionComapny");
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
