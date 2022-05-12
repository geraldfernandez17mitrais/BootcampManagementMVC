using AutoMapper;
using BootcampManagementMVC.BL.ViewModels.BootcampGroups;
using BootcampManagementMVC.Domain.Models;

namespace BootcampManagementMVC.BL.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Dto:
            //CreateMap<BootcampGroupAndTotalMemberDto, BootcampGroup>();

            // BootcampGroup:
            CreateMap<BootcampGroupVM, BootcampGroup>().ReverseMap();
            //CreateMap<BootcampGroupPostDto, BootcampGroup>();

            // UserBootcamp:
            //CreateMap<UserBootcampDto, UserBootcamp>().ReverseMap();
            //CreateMap<UserBootcampPostDto, UserBootcamp>();
        }
    }
}
