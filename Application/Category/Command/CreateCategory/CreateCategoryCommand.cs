using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Category.Command.CreateCategory
{
    public class CreateCategoryCommand : IRequest<bool>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
