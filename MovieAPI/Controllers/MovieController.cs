using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieAPI.Data;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    public class MovieController : ApiController
    {
        public IEnumerable<Movie> Get()
        {
            var db = new MoviesContext();
            return db.Movie.ToList();
        }

        public IHttpActionResult Post(string name)       {
            var newMovie = new Movie
            {
                Title = name
            };
            var db = new MoviesContext();
            db.Movie.Add(newMovie);
            db.SaveChanges();
            return Ok(newMovie);
        }


    }
}
