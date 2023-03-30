using Application.Product.Dto;
using Application.Product.Query.GetAllProducts;
using Application.Product.Query.GetProductById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<ValuesController>
        [HttpGet("GetAll")]
        public async Task<List<GetProductDto>> GetAll([FromQuery]GetAllProductsQuery request)
            => await _mediator.Send(request);

        // GET api/<ProductController>/5
        [HttpGet("Get")]
        public async Task<GetProductDto> Get([FromQuery]GetProductByIdQuery request)
            => await _mediator.Send(request);
    }
}
