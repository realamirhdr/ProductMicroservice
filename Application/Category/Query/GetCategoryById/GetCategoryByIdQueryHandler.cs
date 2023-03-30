using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Category.Dto;
using Domain.Interfaces;
using Mapster;
using MediatR;

namespace Application.Category.Query.GetAllCategories
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryDto>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoryByIdQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<GetCategoryDto> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _categoryRepository.GetById(request.Id);
            return result.Adapt<GetCategoryDto>();
        }
    }

    
}
