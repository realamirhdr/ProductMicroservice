using Application.Category.Query.GetAllCategories;
using Application.Product.Dto;
using Domain.Interfaces;
using Mapster;
using MediatR;

namespace Application.Product.Query.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductDto>
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<GetProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetById(request.Id);
            return result.Adapt<GetProductDto>();
        }
    }

    
}
