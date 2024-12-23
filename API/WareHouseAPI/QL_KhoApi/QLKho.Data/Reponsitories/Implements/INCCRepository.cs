using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.Models.Domain;

namespace QLKho.Data.Reponsitories.Implements
{
    public interface INCCRepository
    {
        Task<IEnumerable<NhaCC>> GetAllAsync();
        Task<NhaCC> CreateAsync(NhaCC ncc);
        Task<NhaCC> UpdateAsync(NhaCC ncc);
        Task<NhaCC> DeleteAsync(int id);
        Task<NhaCC> GetByIdAsync(int id);

    }
}
