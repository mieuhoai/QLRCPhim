using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using QLRCP_DAL.Models;
using QLRCP_DAL.Repos;

namespace QLRCP_BUS.Services
{
    public class MovieService
    {
        private readonly IMovieRepository movieRepository;

        public MovieService(IMovieRepository MovieRepository)
        {
            movieRepository = MovieRepository;
        }

        public List<movies> GetAllMovies()
        {
            var movie = movieRepository.GetAllMovies();
            return movie.Select(m => new movies
            {
                id = m.id,
                movie_id = m.movie_id,
                movie_name = m.movie_name,
                genre = m.genre,
                price = m.price,
                capacity = m.capacity,
                status = m.status,
                movie_image = m.movie_image,
                created_at = m.created_at,
            }).ToList();

        }

        public void AddMovie(movies movieS, string imagePath)
        {
            var movie = new movies
            {
                movie_id = movieS.movie_id,
                movie_name = movieS.movie_name,
                genre = movieS.genre,
                price = movieS.price,
                capacity = movieS.capacity,
                status = movieS.status,
                movie_image = imagePath,
                created_at = DateTime.Now,
                update_date = null,
                delete_date = null,
               // Tickets = new List<buy_tickets>()
            };
            movieRepository.AddMovie(movie);
        }
        public movies GetMovieById(string movieId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(movieId))
                {
                    throw new ArgumentException("Movie ID cannot be null or empty", nameof(movieId));
                }

                var movie = movieRepository.GetMovieById(movieId);
                if (movie == null)
                {
                    throw new Exception("Movie not found");
                }

                return movie;
            }
            catch (Exception ex)
            {
                // Log exception or rethrow as necessary
                throw new Exception($"An error occurred while retrieving the movie: {ex.Message}", ex);
            }
        }
        public void DeleteMovie(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Invalid movie ID", nameof(id));
                }

                // Optionally, check if the movie exists first or if additional validation is needed
                movieRepository.DeleteMovie(id);
            }
            catch (Exception ex)
            {
                // Log or rethrow the exception as necessary
                throw new Exception($"An error occurred while deleting the movie: {ex.Message}", ex);
            }
        }
            public void UpdateMovie1(movies movie)
            {
            try
            {

                // Call the repository layer to update the movie details in the database
               movieRepository.UpdateMovie(movie);
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating movie: {ex.Message}", ex);
            }
        }
    }
}
