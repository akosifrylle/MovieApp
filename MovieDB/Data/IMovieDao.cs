using System.Collections.Generic;

namespace MovieDB.Data
{
    public interface IMovieDao
    {
        Movie AddMovie(Movie movie);
        void DeleteMovie(Movie movie);
        IList<Movie> GetByGenre(string genre);
        IList<Movie> GetByProductionCompany(string productionCompany);
        IList<Movie> GetList();
    }
}
