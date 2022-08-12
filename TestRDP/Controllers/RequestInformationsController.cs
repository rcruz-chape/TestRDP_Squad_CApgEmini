using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestRDP.Context;
using TestRDP.Models;

namespace TestRDP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestInformationsController : ControllerBase
    {
        private readonly RequestInformationContext _context;

        public RequestInformationsController(RequestInformationContext context)
        {
            _context = context;
        }

        // GET: api/RequestInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RequestInformation>>> GetResponses()
        {
          if (_context.Responses == null)
          {
              return NotFound();
          }
            return await _context.Responses.ToListAsync();
        }

        // GET: api/RequestInformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RequestInformation>> GetRequestInformation(int id)
        {
          if (_context.Responses == null)
          {
              return NotFound();
          }
            var requestInformation = await _context.Responses.FindAsync(id);

            if (requestInformation == null)
            {
                return NotFound();
            }

            return requestInformation;
        }

        // PUT: api/RequestInformations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequestInformation(int id, RequestInformation requestInformation)
        {
            if (id != requestInformation.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(requestInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestInformationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RequestInformations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RequestInformation>> PostRequestInformation(RequestInformation requestInformation)
        {
          if (_context.Responses == null)
          {
              return Problem("Entity set 'RequestInformationContext.Responses'  is null.");
          }
            _context.Responses.Add(requestInformation);
            await _context.SaveChangesAsync();

            //           return CreatedAtAction("GetRequestInformation", new { id = requestInformation.CustomerId }, requestInformation);
            return CreatedAtAction(nameof(GetRequestInformation), new { id = requestInformation.CustomerId }, requestInformation);
        }

        // DELETE: api/RequestInformations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequestInformation(int id)
        {
            if (_context.Responses == null)
            {
                return NotFound();
            }
            var requestInformation = await _context.Responses.FindAsync(id);
            if (requestInformation == null)
            {
                return NotFound();
            }

            _context.Responses.Remove(requestInformation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RequestInformationExists(int id)
        {
            return (_context.Responses?.Any(e => e.CustomerId == id)).GetValueOrDefault();
        }
    }
}
