using System.Collections;
using System.Collections.Generic;
using MovieDB.Data;
using MovieDB.NHibernate.Dao;

namespace MovieDB.Services
{
    public class GenreService
    {
        private readonly IGenreDao _genreDao;

        public GenreService()
        {
            _genreDao = new GenreDao();
        }

        public Genre Save(Genre genre)
        {
            return _genreDao.Save(genre);
        }

        public IList<Genre> GetList()
        {
            return _genreDao.GetList();
        }
    }
}
