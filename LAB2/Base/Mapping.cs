using AutoMapper;
using LAB2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Base
{
    public class Mapping : Profile
    {
        public void Create()
        {
            CreateMap<Client, ClientViewModel>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.DayOfBirth, opt => opt.MapFrom(src => src.DayOfBirth))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));

            CreateMap<ClientViewModel, Client>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.DayOfBirth, opt => opt.MapFrom(src => src.DayOfBirth))
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));

            CreateMap<Policy, PolicyViewModel>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
            .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
            .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
            .ForMember(dest => dest.PremiumAmount, opt => opt.MapFrom(src => src.PremiumAmount))
            .ForMember(dest => dest.CoverageAmount, opt => opt.MapFrom(src => src.CoverageAmount));

            CreateMap<PolicyViewModel, Policy>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type))
            .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
            .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
            .ForMember(dest => dest.PremiumAmount, opt => opt.MapFrom(src => src.PremiumAmount))
            .ForMember(dest => dest.CoverageAmount, opt => opt.MapFrom(src => src.CoverageAmount));

            CreateMap<DataModel, DataViewModel>()
            .ForMember(dest => dest.Clients, opt => opt.MapFrom(src => src.Clients))
            .ForMember(dest => dest.Policies, opt => opt.MapFrom(src => src.Policies))
            .ReverseMap();
        }
    }

    public class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Mapping>();
            });

            return config.CreateMapper();
        }
    }
}
