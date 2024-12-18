using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Warehouse.Data.Data;
using Warehouse.Data.Reponsitories.Implements;
using Warehouse.Models.Domain;

namespace Warehouse.Data.Reponsitories.Interface
{
    public class WareRepository : IWareRepository
    {
        private readonly ApplicationDbContext dbContext;

        public WareRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Ware> CreateAsync(Ware warehouse)
        {
            try
            {
                dbContext.ware.Add(warehouse);
                await dbContext.SaveChangesAsync();
                return warehouse;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating record: {ex.Message}");
                return null;
            }
        }

        public async Task<Ware> DeleteAsync(int id)
        {
            var existing = await dbContext.ware.FirstOrDefaultAsync(x => x.Id == id);

            if (existing is null)
            {
                return null;
            }

            dbContext.ware.Remove(existing);
            await dbContext.SaveChangesAsync();
            return existing;
        }

        public async Task<IEnumerable<Ware>> GetAllAsync()
        {
            try
            {
                return await dbContext.ware.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data: {ex.Message}");
                return Enumerable.Empty<Ware>();
            }
        }

        public async Task<Ware> GetByIdAsync(int id)
        {
            return await dbContext.ware.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Ware> UpdateAsync(Ware warehouse)
        {
            var existing = await dbContext.ware.FirstOrDefaultAsync(x => x.Id == warehouse.Id);

            if (existing != null)
            {
                dbContext.Entry(existing).CurrentValues.SetValues(warehouse);
                await dbContext.SaveChangesAsync();
                return warehouse;
            }

            return null;
        }
    }

}
