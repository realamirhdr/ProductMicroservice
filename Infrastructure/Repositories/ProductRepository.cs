using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _context;

        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products
                .OrderBy(p => p.Id)
                .ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            var result = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (result is null)
                throw new Exception("Product does not exist");

            return result;
        }

        public async Task<bool> Create(Product product)
        {
            _context.Products.Add(product);

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> Update(Product product)
        {
            _context.Products.Update(product);

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var exercise = await _context.Products.FindAsync(id);

            if (exercise == null) throw new NullReferenceException();
                _context.Products.Remove(exercise);

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
