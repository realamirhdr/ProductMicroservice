using Domain.Interfaces;
using Mapster;
using MediatR;

namespace Application.Category.Command.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, bool>
    {
        private readonly ICategoryRepository _categoryRepository;

        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var input = request.Adapt<Domain.Entities.Category>();
            return await _categoryRepository.Update(input);
        }
    } 
}
