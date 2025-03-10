using AutoMapper;
using ODS.DataEntry.Modules.WellMaster.Domain.WellMaster;

namespace ODS.DataEntry.Modules.WellMaster.Application.DTO
{
    public class WellMasterAutoMapperProfile : Profile
    {
        public WellMasterAutoMapperProfile()
        {
            CreateMap<WellMasterEntity, WellMasterDto>()
                .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => AutoMapperResolver.FullNameResolver(src.CreatedBy)))
                .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => AutoMapperResolver.FullNameResolver(src.UpdatedBy)));

            CreateMap<WellMasterDto, WellMasterEntity>();
        }
    }
}
