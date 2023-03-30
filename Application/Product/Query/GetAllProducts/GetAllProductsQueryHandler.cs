using Application.Category.Query.GetAllCategories;
using Application.Product.Dto;
using Domain.Interfaces;
using Mapster;
using MediatR;

namespace Application.Product.Query.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<GetProductDto>>
    {
        private readonly IProductRepository _productRepository;

        public GetAllProductsQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<GetProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetAll();
            return result.Adapt<List<GetProductDto>>();
        }
    }
}
