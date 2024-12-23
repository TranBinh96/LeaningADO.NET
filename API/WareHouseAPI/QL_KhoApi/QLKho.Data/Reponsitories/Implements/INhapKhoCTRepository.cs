using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLKho.Models.Domain;

namespace QLKho.Data.Reponsitories.Implements
{
    public interface INhapKhoCTRepository
    {
        Task<IEnumerable<NhapKhoCT>> GetAll();
        Task<NhapKhoCT> Create(NhapKhoCT nhapKhoct);
        Task<NhapKhoCT> Update(NhapKhoCT nhapKhoct);
        Task<NhapKhoCT> Delete(int id);
        Task<NhapKhoCT> GetById(int id);
        Task<List<NhapKhoCT>> GetAllNhapKhoCTByNhapKhoId(string nhapKhoId);
    }
}
