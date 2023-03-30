using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Category.Dto;
using Application.Product.Dto;
using Domain.Entities;
using MediatR;

namespace Application.Category.Query.GetAllCategories
{
    public class UpdateProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
