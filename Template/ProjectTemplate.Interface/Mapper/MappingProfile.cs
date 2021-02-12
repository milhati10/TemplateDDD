using AutoMapper;
using $ext_projectname$.Domain.Entities;
using $ext_projectname$.Domain.ValueObjects;
using $ext_projectname$.Interface.DTO;
using System;

namespace $safeprojectname$.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>()
                .ForMember(
                    dest => dest.ID,
                    opt => opt.MapFrom(src => src.ID.ToString())
                )
                .ForMember(
                    dest => dest.FullName,
                    opt => opt.MapFrom(src => src.Name.ToString())
                )
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => src.Name.FirstName)
                )
            .ForMember(
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => src.Name.LastName)
                );

            CreateMap<CustomerDTO, Customer>()
                .ForMember(
                    dest => dest.ID,
                    opt => opt.MapFrom(src => Guid.Parse(src.ID))
                )
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => new Name(src.FirstName, src.FullName))
                );
        }
    }
}
