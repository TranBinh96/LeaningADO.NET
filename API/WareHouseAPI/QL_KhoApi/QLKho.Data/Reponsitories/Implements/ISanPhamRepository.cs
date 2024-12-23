using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.Models.Domain;

namespace QLKho.Data.Reponsitories.Implements
{
    public interface ISanPhamRepository
    {
        Task<IEnumerable<SanPham>> GetAll();
        Task<SanPham> Create(SanPham sanPham);
        Task<SanPham> Update(SanPham sanPham);
        Task<SanPham> Delete(int id);
        Task<SanPham> GetById(int id);
    }
}
