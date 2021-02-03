using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Interface;
using MovieApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controller
{
    [Microsoft.AspNetCore.Mvc.Route("api/Movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        IMovieRepository movieRepository;
        public MovieController(IMovieRepository _movieRepository)
        {
            movieRepository = _movieRepository;
        }
        // GET: api/Movie
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Movie> movies = movieRepository.GetAll();
            if (movies.Any() == false)
                return NoContent();
            return Ok(movies);
        }
        // GET: api/Movie/5
        [HttpGet("{movieId}")]
        public IActionResult Get(int movieId)
        {
            Movie movie = movieRepository.Get(movieId);
            if (movie == null)
                return NoContent();
            return Ok(movie);
        }
        // POST: api/Movie
        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var newMovie = movieRepository.Post(movie);
            return CreatedAtAction(nameof(Get),
            new { movieId = newMovie.MovieId },
            newMovie);
        }
        // PUT: api/Movie/5
        [HttpPut]
        public IActionResult Put([FromBody] Movie movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var updatedMovie = movieRepository.Put(movie);
            return Ok(updatedMovie);
        }
        // DELETE: api/Movie/5
        [HttpDelete("{movieId}")]
        public IActionResult Delete(int movieId)
        {
            var deletedMovie = movieRepository.Delete(movieId);
            if (deletedMovie == null)
                return NoContent();
            return Ok(deletedMovie);
        }
    }
}
