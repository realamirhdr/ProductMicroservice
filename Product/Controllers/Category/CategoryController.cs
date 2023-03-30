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
    public class CategoryController : Controller
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<ValuesController>
        [HttpGet("GetAll")]
        public async Task<List<GetCategoryDto>> GetAll([FromQuery]GetAllCategoriesQuery request)
            => await _mediator.Send(request);

        // GET api/<ProductController>/5
        [HttpGet("Get")]
        public async Task<GetCategoryDto> Get([FromQuery]GetCategoryByIdQuery request)
            => await _mediator.Send(request);

    }
}
