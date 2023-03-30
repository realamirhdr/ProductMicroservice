using Application.Category.Command.CreateCategory;
using Application.Category.Command.DeleteCategory;
using Application.Category.Command.UpdateCategory;
using Application.Category.Dto;
using Application.Category.Query.GetAllCategories;
using Application.Category.Query.GetCategoryById;
using Application.Product.Command.CreateProduct;
using Application.Product.Command.DeleteProduct;
using Application.Product.Command.UpdateProduct;
using Application.Product.Dto;
using Application.Product.Query.GetAllProducts;
using Application.Product.Query.GetProductById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers.Category
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryAdminController : Controller
    {
        private readonly IMediator _mediator;

        public CategoryAdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // POST api/<ProductController>
        [HttpPost("Create")]
        public async Task<bool> Create([FromBody] CreateCategoryCommand request)
            => await _mediator.Send(request);

        // PUT api/<ProductController>/5
        [HttpPut("Update")]
        public async Task<bool> Update([FromBody] UpdateCategoryCommand request)
            => await _mediator.Send(request);

        // DELETE api/<ProductController>/5
        [HttpDelete("Delete")]
        public async Task<bool> Delete([FromBody] DeleteCategoryCommand request)
            => await _mediator.Send(request);
    }
}
