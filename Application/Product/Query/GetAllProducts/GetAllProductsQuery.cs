using Application.Product.Dto;
using MediatR;

namespace Application.Product.Query.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<List<GetProductDto>>
    {
    }
}
