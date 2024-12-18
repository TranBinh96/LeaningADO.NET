using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Data.Data;
using Warehouse.Data.Reponsitories.Implements;

namespace Warehouse.Data.Reponsitories.Interface
{
    public class UnitWork : IUnitWork
    {
        private readonly ApplicationDbContext _db;
        public IWareRepository wareRepository { get; private set; }
        
        public UnitWork(ApplicationDbContext db)
        {
            _db = db;
            wareRepository = new WareRepository(_db);
           
        }
    }
}
