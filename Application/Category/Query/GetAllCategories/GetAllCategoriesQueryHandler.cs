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
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<GetCategoryDto>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetAllCategoriesQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<GetCategoryDto>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var result = await _categoryRepository.GetAll();
            return result.Adapt<List<GetCategoryDto>>();
        }
    }
}
