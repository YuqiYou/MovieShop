using ApplicationCore.Entities;
using ApplicationCore.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetTop30HighestRevenueMovies()
        {   //Go to db and get the top movies
            //EF Core or Dapper to connect to db
            
            var movies = new List<Movie> { 
                new Movie{}
            
            };

            return movies;


        }

        public List<Movie> GetTop30RatedMovies()
        {
            throw new NotImplementedException();
        }
    }
}
