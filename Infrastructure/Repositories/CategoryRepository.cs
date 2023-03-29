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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseContext _context;

        public CategoryRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories
                .OrderBy(p => p.Id)
                .ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            var result = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);

            if (result is null)
                throw new Exception("Category does not exist");

            return result;
        }

        public async Task<bool> Create(Category category)
        {
            _context.Categories.Add(category);

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> Update(Category category)
        {
            _context.Categories.Update(category);

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var exercise = await _context.Categories.FindAsync(id);

            if (exercise == null) throw new NullReferenceException();
            _context.Categories.Remove(exercise);

            var result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
