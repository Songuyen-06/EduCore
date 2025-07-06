﻿using AutoMapper;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Mappings
{
    public class SubCategoryProfile : Profile

    {
        public SubCategoryProfile()
        {
            CreateMap<SubCategory, SubCategoryDTO>()
                .ForMember(dest => dest.SubCategoryId, opt => opt.MapFrom(opt => opt.SubCategoryId))
                 .ForMember(dest => dest.SubCategoryName, opt => opt.MapFrom(opt => opt.Name)).ReverseMap();

            CreateMap<SubCategory, SubCategoryDetailDTO >()
                .IncludeBase<SubCategory, SubCategoryDTO>()
              .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(opt => opt.Category.CategoryId))
               .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(opt => opt.Category.Name))
                        .ReverseMap();
        }
    }
}
