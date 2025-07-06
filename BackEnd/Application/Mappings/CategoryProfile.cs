using AutoMapper;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Mappings
{
    public class CategoryProfile : Profile

    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>()
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(opt => opt.CategoryId))
                             .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(opt => opt.Name))
                          .ForMember(dest => dest.SubCategories, opt => opt.MapFrom(opt => opt.SubCategories))
                          .ReverseMap();
                           

        }
    }
}
