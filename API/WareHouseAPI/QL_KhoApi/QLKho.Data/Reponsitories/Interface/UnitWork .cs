using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.Data.Data;
using QLKho.Data.Reponsitories.Implements;

namespace QLKho.Data.Reponsitories.Interface
{
    public class UnitWork : IUnitWork
    {
        private readonly ApplicationDbContext _db;
        public IKhoRepository khoRepository { get; private set; }
        public INCCRepository nccRepository { get; private set; }
        public INhomSanPhamRepository nhomSanPhamRepository { get; private set; }
        public ISanPhamRepository sanPhamRepository { get; private set; }
        public INhapKhoRepository nhapKhoRepository { get; private set; }
        public INhapKhoCTRepository nhapKhoCTRepository { get; private set; }
        /*
       
       
        public IXuatKhoRepository xuatKhoRepository { get; private set; }
        public IXuatKhoCTRepository xuatKhoCTRepository { get; private set; }*/
        public UnitWork(ApplicationDbContext db)
        {
            _db = db;
            khoRepository = new KhoRepository(_db);
            nccRepository = new NCCRepository(_db);
            nhomSanPhamRepository = new NhomSanPhamRepository(_db);
            nhapKhoRepository = new NhapKhoRepository(_db);
            nhapKhoCTRepository = new NhapKhoCTRepository(_db);
            sanPhamRepository = new SanPhamRepository(_db);
            /* 
             xuatKhoRepository = new XuatKhoRepository(_db);
             xuatKhoCTRepository = new XuatKhoCTRepository(_db);*/
        }
    }
}
