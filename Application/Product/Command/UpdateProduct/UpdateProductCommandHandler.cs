using Domain.Interfaces;
using Mapster;
using MediatR;

namespace Application.Product.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var input = request.Adapt<Domain.Entities.Product>();
            return await _productRepository.Update(input);
        }
    }

    
}
