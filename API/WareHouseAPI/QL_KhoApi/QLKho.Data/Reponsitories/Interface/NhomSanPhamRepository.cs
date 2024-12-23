using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QLKho.Data.Data;
using QLKho.Data.Reponsitories.Implements;
using QLKho.Models.Domain;

namespace QLKho.Data.Reponsitories.Interface
{
    public class NhomSanPhamRepository : INhomSanPhamRepository
    {
        private readonly ApplicationDbContext dbContext;
        public NhomSanPhamRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<NhomSanPham> CreateAsync(NhomSanPham sanPham)
        {
            try
            {
                dbContext.nhom_san_pham.Add(sanPham);
                await dbContext.SaveChangesAsync();
                return sanPham;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating record: {ex.Message}");
                return null;
            }
        }
        public async Task<NhomSanPham> DeleteAsync(int id)
        {
            var existing = await dbContext.nhom_san_pham.FirstOrDefaultAsync(x => x.id == id);

            if (existing is null)
            {
                return null;
            }

            dbContext.nhom_san_pham.Remove(existing);
            await dbContext.SaveChangesAsync();
            return existing;
        }
        public async Task<IEnumerable<NhomSanPham>> GetAllAsync()
        {
            try
            {
                return await dbContext.nhom_san_pham.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching data: {ex.Message}");
                return Enumerable.Empty<NhomSanPham>();
            }
        }
        public async Task<NhomSanPham> GetByIdAsync(int id)
        {
            return await dbContext.nhom_san_pham.FirstOrDefaultAsync(x => x.id == id);
        }
        public async Task<NhomSanPham> UpdateAsync(NhomSanPham sanPham)
        {
            var existing = await dbContext.nhom_san_pham.FirstOrDefaultAsync(x => x.id == sanPham.id);

            if (existing != null)
            {
                dbContext.Entry(existing).CurrentValues.SetValues(sanPham);
                await dbContext.SaveChangesAsync();
                return sanPham;
            }
            return null;
        }
    }
}
