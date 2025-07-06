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
    internal class StudentCourseProfile : Profile

    {
        public StudentCourseProfile()
        {
            CreateMap<StudentCourse, StudentCourseDTO>().
               ForMember(dest => dest.UserId, opt => opt.MapFrom(opt => opt.UserId)).
               ForMember(dest => dest.CourseId, opt => opt.MapFrom(opt => opt.CourseId)).
                              ForMember(dest => dest.IsInCart, opt => opt.MapFrom(opt => opt.IsInCart)).
            ReverseMap();



        }

    }
}
