using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Data.Reponsitories.Implements
{
    public interface IUnitWork
    {
        IKhoRepository khoRepository { get; }
        INCCRepository nccRepository { get; }
        INhomSanPhamRepository nhomSanPhamRepository { get; }
        ISanPhamRepository sanPhamRepository { get; }
        INhapKhoRepository nhapKhoRepository { get; }
        INhapKhoCTRepository nhapKhoCTRepository { get; }
        /* 
       
        IXuatKhoRepository xuatKhoRepository { get; }
        IXuatKhoCTRepository xuatKhoCTRepository { get; }*/
    }
}