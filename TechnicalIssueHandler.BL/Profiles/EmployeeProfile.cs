using AutoMapper;
using TechnicalIssueHandler.BL.ViewModels.EmployeeVMs;
using TechnicalIssueHandler.Core.Entities;

namespace TechnicalIssueHandler.BL.Profiles;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<EmployeeCreateVM, Employee>()
            .ForMember(x => x.ImageUrl, y => y.MapFrom(z => "~/images/" + z.Image.FileName))
            .ReverseMap();
        CreateMap<EmployeeGetVM, Employee>()
            .ForMember(x => x.DesignationId, y => y.MapFrom(z => z.DesignationName))
            .ReverseMap();
    }
}