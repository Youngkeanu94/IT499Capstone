using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IT499Capstone.Data;
using IT499Capstone.Models;

namespace IT499Capstone.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class PaymentsController : ControllerBase
        {
            private readonly ApplicationDbContext _context;

            public PaymentsController(ApplicationDbContext context)
            {
                _context = context;
            }

            // GET: api/Payments
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Payment>>> GetPayments()
            {
                return await _context.Payments.ToListAsync();
            }

            // GET: api/Payments/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Payment>> GetPayment(int id)
            {
                var payment = await _context.Payments.FindAsync(id);
                if (payment == null)
                {
                    return NotFound();
                }

                return payment;
            }

            // POST: api/Payments
            [HttpPost]
            public async Task<ActionResult<Payment>> CreatePayment(Payment payment)
            {
                _context.Payments.Add(payment);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetPayment), new { id = payment.PaymentID }, payment);
            }

            // PUT: api/Payments/5
            [HttpPut("{id}")]
            public async Task<IActionResult> UpdatePayment(int id, Payment payment)
            {
                if (id != payment.PaymentID)
                {
                    return BadRequest();
                }

                _context.Entry(payment).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Payments.Any(e => e.PaymentID == id))
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

            // DELETE: api/Payments/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeletePayment(int id)
            {
                var payment = await _context.Payments.FindAsync(id);
                if (payment == null)
                {
                    return NotFound();
                }

                _context.Payments.Remove(payment);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }
}


