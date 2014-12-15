using AutoMapper;

namespace MovieDB.NHibernate.Repo
{
    public class NHRepoAutoMapperProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Genre, GenreRepo>();
        }
    }
}
