using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Category.Dto;
using Application.Category.Query.GetAllCategories;
using Domain.Interfaces;
using Mapster;
using MediatR;

namespace Application.Category.Command.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, bool>
    {
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var input = request.Adapt<Domain.Entities.Category>();
            return await _categoryRepository.Create(input);
        }
    } 
}
