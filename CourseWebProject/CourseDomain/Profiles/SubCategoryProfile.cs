using AutoMapper;
using CourseDomain.DTOs;
using CourseDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Profiles
{
    public class SubCategoryProfile : Profile

    {
        public SubCategoryProfile()
        {
            CreateMap<SubCategory, SubCategoryDTO>()
                .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(opt => opt.SubCategoryId))
                 .ForMember(dest => dest.SubCategoryName, opt => opt.MapFrom(opt => opt.Name)).ReverseMap();

        }
    }
}
