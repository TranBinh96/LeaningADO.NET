using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Models.Domain
{
    public class NhomSanPham
    {
        public int id { get; set; }
        public string loai_san_pham { get; set; }
       /* public ICollection<SanPham> SanPhams { get; } = new List<SanPham>();*/
    }
}
