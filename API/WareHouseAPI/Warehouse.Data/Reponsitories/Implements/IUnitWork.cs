using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Data.Reponsitories.Implements
{
    public interface IUnitWork
    {
        IWareRepository wareRepository { get; }
    }
}
