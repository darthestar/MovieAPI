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
    public class MovieFactoryController : ApiController
    {
        public IHttpActionResult Post(Movie data)
        {
            var db = new MoviesContext();
            db.Movie.Add(data);
            db.SaveChanges();
            return Ok(data);

        }
    }
}
