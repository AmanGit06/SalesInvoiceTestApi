using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesInvoiceTestApi.Service;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceItemController : ControllerBase
    {
        private readonly IInvoiceItemService _invoiceitemService;

        public InvoiceItemController(IInvoiceItemService invoiceitemService)
        {
            _invoiceitemService = invoiceitemService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceItem>>> GetAllInvoiceItems()
        {
            var InvoiceItems = await _invoiceitemService.GetAllInvoiceItemsAsync();
            return Ok(InvoiceItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceItem>> GetInvoiceItemById(int id)
        {
            var InvoiceItem = await _invoiceitemService.GetInvoiceItemByIdAsync(id);
            if (InvoiceItem == null) return NotFound();
            return Ok(InvoiceItem);
        }

        [HttpPost]
        public async Task<IActionResult> AddInvoiceItem(InvoiceItem InvoiceItem)
        {
            await _invoiceitemService.AddInvoiceItemAsync(InvoiceItem);
            return CreatedAtAction(nameof(GetInvoiceItemById), new { id = InvoiceItem.InvoiceId }, InvoiceItem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInvoiceItem(int id, InvoiceItem InvoiceItem)
        {
            if (id != InvoiceItem.InvoiceId) return BadRequest();
            await _invoiceitemService.UpdateInvoiceItemAsync(InvoiceItem);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoiceItem(int id)
        {
            await _invoiceitemService.DeleteInvoiceItemAsync(id);
            return NoContent();
        }
    }
}
