using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Models.Domain
{
    public class Kho
    {
        public int id { get; set; }
        public string ten_kho { get; set; }
        public string hien_thi { get; set; }
        public string ghi_chu { get; set; }
        public string nguoi_tao { get; set; }
        public DateTime ngay_tao { get; set; }
        public DateTime cap_nhat { get; set; }
       /* public ICollection<NhapKho> NhapKhos { get; } = new List<NhapKho>();*/
    }
}
