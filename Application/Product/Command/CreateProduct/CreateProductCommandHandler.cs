using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Category.Command.CreateCategory;
using Application.Category.Dto;
using Application.Product.Command.CreateProduct;
using Application.Product.Dto;
using Application.Product.Query.GetProductById;
using Domain.Interfaces;
using Mapster;
using MediatR;

namespace Application.Category.Query.GetAllCategories
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
