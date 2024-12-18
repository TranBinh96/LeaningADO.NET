using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models.Domain;

namespace Warehouse.Data.Reponsitories.Implements
{
    public interface IWareRepository
    {
        Task<IEnumerable<Ware>> GetAllAsync();
        Task<Ware> CreateAsync(Ware kho);
        Task<Ware> UpdateAsync(Ware kho);
        Task<Ware> DeleteAsync(int id);
        Task<Ware> GetByIdAsync(int id);
    }
}
