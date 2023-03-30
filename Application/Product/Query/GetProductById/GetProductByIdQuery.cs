using Application.Product.Dto;
using MediatR;

namespace Application.Product.Query.GetProductById
{
    public class GetProductByIdQuery : IRequest<GetProductDto>
    {
        public int Id { get; set; }
    }
}
