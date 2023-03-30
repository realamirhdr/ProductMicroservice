using Domain.Interfaces;
using Mapster;
using MediatR;

namespace Application.Product.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var input = request.Adapt<Domain.Entities.Product>();
            return await _productRepository.Create(input);
        }
    }

    
}
