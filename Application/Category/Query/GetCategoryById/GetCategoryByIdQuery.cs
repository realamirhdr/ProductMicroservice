using Application.Category.Dto;
using MediatR;

namespace Application.Category.Query.GetCategoryById
{
    public class GetCategoryByIdQuery : IRequest<GetCategoryDto>
    {
        public int Id { get; set; }
    }
}
