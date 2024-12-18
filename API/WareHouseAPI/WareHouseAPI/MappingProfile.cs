using AutoMapper;
using Warehouse.Models.Domain;
using Warehouse.Models.DTO;

namespace WareHouseAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Ware, WareDto>();
            CreateMap<WareRequestDto, Ware>();
        }
    }
}
