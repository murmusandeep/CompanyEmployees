using AutoMapper;
using Entities;
using Shared;

namespace CompanyEmployees
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(c => c.FullAddress,
                opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            CreateMap<Employee, EmployeeDto>().ReverseMap();

            CreateMap<CompanyForCreationDto, Company>().ReverseMap();

            CreateMap<EmployeeForCreationDto, Employee>().ReverseMap();

            CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();

            CreateMap<CompanyForUpdateDto, Company>().ReverseMap();

        }
    }
}
