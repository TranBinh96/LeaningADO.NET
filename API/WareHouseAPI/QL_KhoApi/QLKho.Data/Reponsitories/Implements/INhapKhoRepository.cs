using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.Models.Domain;

namespace QLKho.Data.Reponsitories.Implements
{
    public interface INhapKhoRepository
    {
        Task<IEnumerable<NhapKho>> GetAll();
        Task<NhapKho> Create(NhapKho nhapKho);
        Task<NhapKho> Update(NhapKho nhapKho);
        Task<NhapKho> Delete(string id);
        Task<NhapKho> GetById(string id);
        Task<string> GenIdNhapKho();
    }
}
