using System;
using System.Collections.Generic;
using System.Linq;
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
                Tickets = new List<buy_tickets>()
            };
            movieRepository.AddMovie(movie);
        }
    }
}
