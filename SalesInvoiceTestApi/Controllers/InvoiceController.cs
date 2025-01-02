using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesInvoiceTestApi.Model;
using SalesInvoiceTestApi.Service;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoicedetailService;

        public InvoiceController(IInvoiceService invoicedetailService)
        {
            _invoicedetailService = invoicedetailService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceDetail>>> GetAllInvoiceDetails()
        {
            var InvoiceDetails = await _invoicedetailService.GetAllInvoiceDetailsAsync();
            return Ok(InvoiceDetails);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceDetail>> GetInvoiceDetailById(int id)
        {
            var InvoiceDetail = await _invoicedetailService.GetInvoiceDetailByIdAsync(id);
            if (InvoiceDetail == null) return NotFound();
            return Ok(InvoiceDetail);
        }
        //[HttpPost("{AddInvoice}")]
        //public async Task<IActionResult> CreateInvoice([FromBody] InvoiceRequestDto invoiceRequest)
        //{
        //    if (invoiceRequest == null)
        //    {
        //        return BadRequest();
        //    }

        //    var createdInvoice = await _invoicedetailService.CreateInvoiceAsync(invoiceRequest);

        //    return CreatedAtAction(nameof(GetInvoice), new { id = createdInvoice.InvoiceId }, createdInvoice);
        //}

        [HttpPost("{Invoice}")]
        public async Task<IActionResult> AddInvoiceDetail(InvoiceDetail InvoiceDetail)
        {
            await _invoicedetailService.AddInvoiceDetailAsync(InvoiceDetail);
            return CreatedAtAction(nameof(GetInvoiceDetailById), new { id = InvoiceDetail.InvoiceId }, InvoiceDetail);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInvoiceDetail(int id, InvoiceDetail InvoiceDetail)
        {
            if (id != InvoiceDetail.InvoiceId) return BadRequest();
            await _invoicedetailService.UpdateInvoiceDetailAsync(InvoiceDetail);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoiceDetail(int id)
        {
            await _invoicedetailService.DeleteInvoiceDetailAsync(id);
            return NoContent();
        }
    }
}
