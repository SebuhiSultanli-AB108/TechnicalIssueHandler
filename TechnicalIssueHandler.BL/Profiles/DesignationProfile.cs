using AutoMapper;
using TechnicalIssueHandler.BL.ViewModels.DesigantionVMs;
using TechnicalIssueHandler.Core.Entities;

namespace TechnicalIssueHandler.BL.Profiles;

public class DesignationProfile : Profile
{
    public DesignationProfile()
    {
        CreateMap<DesignationCreateVM, Designation>().ReverseMap();
        CreateMap<DesignationGetVM, Designation>().ReverseMap();
    }
}