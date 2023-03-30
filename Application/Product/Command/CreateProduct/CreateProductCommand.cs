using Application.Product.Dto;
using MediatR;

namespace Application.Product.Command.CreateProduct
{
    public class CreateProductCommand : IRequest<bool>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
