using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaAirline.api.Models;
using FormulaAirline.api.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormulaAirline.api.Controllers
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingsController : ControllerBase
    {
        private readonly IMessageProducer _producer;

        public static readonly List<Booking> _bookings = new();

        public BookingsController(IMessageProducer producer)
        {
            _producer = producer;
        }

        [HttpPost("book-ticket")]
        public IActionResult CreateBooking(Booking newBooking)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _bookings.Add(newBooking);
            _producer.SendingMessages<Booking>(newBooking);

            return Ok();
        }
    }
}