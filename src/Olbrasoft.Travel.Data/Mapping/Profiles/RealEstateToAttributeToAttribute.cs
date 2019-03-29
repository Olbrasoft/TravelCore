﻿using System.Linq;
using AutoMapper;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.Transfer.Objects.Accommodation;

namespace Olbrasoft.Travel.Data.Mapping.Profiles
{
    public class RealEstateToAttributeToAttribute : Profile
    {
        public RealEstateToAttributeToAttribute()
        {
            CreateMap<PropertyToAttribute, AttributeDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.AttributeId))
                .ForMember(d => d.TypId, opt => opt.MapFrom(src => src.Attribute.TypeId))
                .ForMember(d => d.SubTypeId, opt => opt.MapFrom(src => src.Attribute.SubtypeId))
                .ForMember(d => d.Text, opt => opt.MapFrom(src => src.Text))
                .ForMember(d => d.Description, opt => opt.MapFrom(src => src.Attribute.LocalizedAttributes.FirstOrDefault().Description))
                .ForMember(d => d.Ban, opt => opt.MapFrom(src => src.Attribute.Ban))
                ;
        }
    }
}