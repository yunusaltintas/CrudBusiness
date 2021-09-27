using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserCRUD.DATA.DTOs;
using UserCRUD.DATA.Entities;

namespace UserCRUD.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Geo, GeoDTO>().ReverseMap();
            CreateMap<Address, AddressDTO>()
                .ForMember(dest => dest.GeoDto, opt => opt.MapFrom(src => src.Geo))
                .ReverseMap();
            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.CompanyDto, opt=>opt.MapFrom(src=>src.Company))
                .ForMember(dest => dest.AddressDto, opt => opt.MapFrom(src => src.Address))
                .ReverseMap();
             
        }
    }
}
