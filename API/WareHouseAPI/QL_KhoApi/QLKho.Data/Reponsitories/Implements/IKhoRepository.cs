using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.Models.Domain;

namespace QLKho.Data.Reponsitories.Implements
{
    public interface IKhoRepository
    {
        Task<IEnumerable<Kho>> GetAllAsync();
        Task<Kho> CreateAsync(Kho kho);
        Task<Kho> UpdateAsync(Kho kho);
        Task<Kho> DeleteAsync(int id);
        Task<Kho> GetByIdAsync(int id);

    }
}
