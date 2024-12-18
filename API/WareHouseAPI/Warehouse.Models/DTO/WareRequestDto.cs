using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Models.DTO
{
    public class WareRequestDto
    {
        public string WareName { get; set; }
        public string Display { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
