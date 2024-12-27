using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Vidly_ASP.Dtos;
using Vidly_ASP.Models;

namespace Vidly_ASP.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        public ApplicationDbContext _context { get; set; }

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id));

            foreach (var movie in movies)
            {
                if(movie.NumberAvailable == 0)
                    return BadRequest("Movie is not Available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now,
                };

                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();
            
            return Ok();
        }
    }
}