using ApplicationCore.Models;
using ApplicationCore.ServiceContracts;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        public List<MovieCardModel> GetTopRevenueMovies()
        {
            //commnunicate with repo
            var movierepo = new MovieRepository();
            var movies = movierepo.GetTop30HighestRevenueMovies();

            var movieCards = new List<MovieCardModel>();
            foreach (var movie in movies)
            {
                movieCards.Add(new MovieCardModel { Id = movie.Id, Title = movie.Title, PosterUrl = movie.PostUrl});
            }

            return movieCards;
        }
    }
}
