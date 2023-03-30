using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Category.Dto;
using Application.Product.Dto;
using Domain.Interfaces;
using Mapster;
using MediatR;

namespace Application.Category.Query.GetAllCategories
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
