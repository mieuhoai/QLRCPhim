using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLRCP_DAL.Models;

namespace QLRCP_DAL.Repos
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContextDB Context;

        public MovieRepository(MovieContextDB context)
        {
            Context = context;
        }

        public void DeleteMovie(int id)
        {
            var movie = Context.movies.Find(id);
            if (movie != null)
            {
                movie.delete_date = DateTime.Now;
                movie.status = "Deleted";
                Context.SaveChanges();
            }
        }

        IEnumerable<movies> IMovieRepository.GetAllMovies()
        {
            return Context.movies.Where(m => m.delete_date == null).ToList();
        }

        IEnumerable<movies> IMovieRepository.GetAvailableMovies()
        {
            return Context.movies.Where(m => m.status == "Co san" && m.delete_date == null).ToList();
        }

        movies IMovieRepository.GetMovieById(string movieId)
        {
            return Context.movies.FirstOrDefault(m => m.movie_id == movieId);
        }

        public void AddMovie(movies movie)
        {
            Context.movies.Add(movie);
            Context.SaveChanges();
        }

        public void UpdateMovie(movies movie)
        {
            var existingMovie = Context.movies.Find(movie.id);
            if (existingMovie != null)
            {
                Context.Entry(existingMovie).CurrentValues.SetValues(movie);
                Context.SaveChanges();
            }
        }
    }
}

