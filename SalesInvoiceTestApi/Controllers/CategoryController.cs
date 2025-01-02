using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesInvoiceTestApi.Service;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategorys()
        {
            var Categorys = await _categoryService.GetAllCategorysAsync();
            return Ok(Categorys);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategoryById(int id)
        {
            var Category = await _categoryService.GetCategoryByIdAsync(id);
            if (Category == null) return NotFound();
            return Ok(Category);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category Category)
        {
            await _categoryService.AddCategoryAsync(Category);
            return CreatedAtAction(nameof(GetCategoryById), new { id = Category.CategoryId }, Category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, Category Category)
        {
            if (id != Category.CategoryId) return BadRequest();
            await _categoryService.UpdateCategoryAsync(Category);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return NoContent();
        }
    }
}
