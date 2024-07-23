﻿using AutoMapper;
using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Profiles
{
    public class InstructorProfile : Profile

    {
        public InstructorProfile()
        {
            CreateMap<User, InstructorDTO>()
                         .IncludeBase<User, UserDTO>()
                          .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => src.Courses.Any(c => c.Rating.HasValue)? Math.Round(src.Courses.Average(c => c.Rating.GetValueOrDefault()), 1) : 0))
                            .ForMember(dest => dest.NumberStudent, opt => opt.MapFrom(opt => opt.Courses.Sum(c => c.Enrollments.Count)))
                            .ForMember(dest => dest.NumberCourse, opt => opt.MapFrom(opt => opt.Courses.Count))
                             .ForMember(dest => dest.SubCategoryDetails, opt => opt.MapFrom(opt => opt.Courses.Select(c => c.SubCategory).Distinct()))
                          .ReverseMap();

            CreateMap<User,InstructorDetailDTO>()
                .IncludeBase<User, InstructorDTO>()
                 .ForMember(dest => dest.Courses, opt => opt.MapFrom(opt => opt.Courses))
                   .ForMember(dest => dest.Reviews, opt => opt.MapFrom(opt => opt.Courses.SelectMany(c=>c.Reviews)))
                     .ReverseMap();

          

        }
       
    }
}
