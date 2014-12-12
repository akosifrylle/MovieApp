using System.Collections;
using System.Collections.Generic;

namespace MovieDB.Data
{
    public interface IGenreDao
    {
        Genre Save(Genre genre);
        void Delete(Genre genre);
        Genre GetById(int id);
        IList<Genre> GetByGenre(string genre);
        IList<Genre> GetList();
    }
}
