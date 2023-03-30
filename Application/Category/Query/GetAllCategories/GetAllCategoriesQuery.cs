using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Category.Dto;
using Domain.Entities;
using MediatR;

namespace Application.Category.Query.GetAllCategories
{
    public class GetAllCategoriesQuery : IRequest<List<GetCategoryDto>>
    {
    }
}
