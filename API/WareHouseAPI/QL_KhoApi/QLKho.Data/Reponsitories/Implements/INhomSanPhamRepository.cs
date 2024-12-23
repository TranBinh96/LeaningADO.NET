using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.Models.Domain;

namespace QLKho.Data.Reponsitories.Implements
{
    public interface INhomSanPhamRepository
    {
        Task<IEnumerable<NhomSanPham>> GetAllAsync();
        Task<NhomSanPham> CreateAsync(NhomSanPham nhomSanPham);
        Task<NhomSanPham> UpdateAsync(NhomSanPham nhomSanPham);
        Task<NhomSanPham> DeleteAsync(int id);
        Task<NhomSanPham> GetByIdAsync(int id);

    }
}
