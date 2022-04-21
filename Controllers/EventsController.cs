using Microsoft.AspNetCore.Mvc;
using WatercoolerApi.Models;

namespace WatercoolerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly DataContext _context;

        public EventsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Event>>> Get()
        {
            return Ok(await _context.Events.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> Get(int id)
        {
            var ev = await _context.Events.FindAsync(id);
            if (ev == null)
                return BadRequest("Event not found.");
            return Ok(ev);
        }

        [HttpPost]
        public async Task<ActionResult<List<Event>>> AddEvent(Event ev)
        {
            _context.Events.Add(ev);
            await _context.SaveChangesAsync();

            return Ok(await _context.Events.ToListAsync());
        }

        // [HttpPost]
        // public async Task<ActionResult<List<Event>>> AddEvents(Event[] events)
        // {
        //     _context.Events.AddRange(events);
        //     await _context.SaveChangesAsync();

        //     return Ok(await _context.Events.ToListAsync());
        // }

        [HttpPut]
        public async Task<ActionResult<List<Event>>> UpdateEvent(Event request)
        {
            var dbEvent = await _context.Events.FindAsync(request.Id);
            if (dbEvent == null)
                return BadRequest("Event not found.");

            dbEvent.Title = request.Title;
            dbEvent.Description = request.Description;
            dbEvent.ImageUri = request.ImageUri;

            await _context.SaveChangesAsync();

            return Ok(await _context.Events.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Event>>> Delete(int id)
        {
            var dbEvent = await _context.Events.FindAsync(id);
            if (dbEvent == null)
                return BadRequest("Event not found.");

            _context.Events.Remove(dbEvent);
            return Ok(await _context.Events.ToListAsync());
        }

    }
}