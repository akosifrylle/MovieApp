using System;
using System.Collections.Generic;
using AutoMapper;
using MovieDB.Data;
using MovieDB.NHibernate.Repo;

namespace MovieDB.NHibernate.Dao
{
    public class GenreDao : IGenreDao
    {
        public Genre Save(Genre genre)
        {
            var genreRepo = Mapper.Map<GenreRepo>(genre);
            NH.Run(s => s.SaveOrUpdate(genreRepo));
            return Mapper.Map<Genre>(genreRepo);
        }

        public void Delete(Genre genre)
        {
            throw new NotImplementedException();
        }

        public Genre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetByGenre(string genre)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
