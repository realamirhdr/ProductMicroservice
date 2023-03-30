using Application.Product.Command.CreateProduct;
using Application.Product.Command.DeleteProduct;
using Application.Product.Command.UpdateProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAdminController : Controller
    {
        private readonly IMediator _mediator;

        public ProductAdminController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // POST api/<ProductController>
        [HttpPost("Create")]
        public async Task<bool> Create([FromBody] CreateProductCommand request)
            => await _mediator.Send(request);

        // PUT api/<ProductController>/5
        [HttpPut("Update")]
        public async Task<bool> Update([FromBody] UpdateProductCommand request)
            => await _mediator.Send(request);

        // DELETE api/<ProductController>/5
        [HttpDelete("Delete")]
        public async Task<bool> Delete([FromBody] DeleteProductCommand request)
            => await _mediator.Send(request);
    }
}
