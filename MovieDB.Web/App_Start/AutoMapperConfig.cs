using AutoMapper;
using MovieDB.NHibernate.Repo;

namespace MovieDB.Web.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(config =>
            {
                config.AddProfile<NHRepoAutoMapperProfile>();
            });
        }
    }
}