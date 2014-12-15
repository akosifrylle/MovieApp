using FluentNHibernate.Mapping;
using MovieDB.NHibernate.Repo;

namespace MovieDB.NHibernate.SqlServer.Maps
{
    public class MovieMap : ClassMap<MovieRepo>
    {
        public MovieMap()
        {
            Table("Movie");
            Id(x => x.Id);
            Map(x => x.Title);
            Map(x => x.Description);
            Map(x => x.ReleaseDate);
            Map(x => x.Rating);
            References(x => x.Genre);
            References(x => x.ProductionCompany);
        }
    }
}
