using AutoMapper;
using BootcampManagementMVC.BL.Dtos.BootcampGroups;
using BootcampManagementMVC.BL.Dtos.UserBootcamps;
using BootcampManagementMVC.Domain.Models;

namespace BootcampManagementMVC.BL.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // BootcampGroup:
            CreateMap<BootcampGroupDto, BootcampGroup>();
            CreateMap<BootcampGroup, BootcampGroupDto>()
                .ForMember(dest => dest.SyllabusId, opt => opt.MapFrom(src => src.Syllabus.Id));
            CreateMap<BootcampGroupAndTotalMemberDto, BootcampGroup>();
            CreateMap<BootcampGroupPostDto, BootcampGroup>();
            CreateMap<BootcampGroupPutDto, BootcampGroup>();
            CreateMap<BootcampGroupDto, BootcampGroupPutDto>();

            // UserBootcamp:
            CreateMap<UserBootcampDto, UserBootcamp>().ReverseMap();
        }
    }
}