using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRCP_DAL.Models;

namespace QLRCP_DAL.Repos
{
    public interface IMovieRepository
    {
        IEnumerable<movies> GetAllMovies();
        IEnumerable<movies> GetAvailableMovies();
        movies GetMovieById(string movieId);
        void AddMovie(movies movie);
        void UpdateMovie(movies movie);
        void DeleteMovie(int id);
    }
}
