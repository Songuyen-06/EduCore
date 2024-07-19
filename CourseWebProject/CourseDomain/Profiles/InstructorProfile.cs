using AutoMapper;
using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Profiles
{
    public  class InstructorProfile:Profile

    {
        public InstructorProfile()
        {
            CreateMap<User, InstructorDTO>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(opt => opt.UserId))
                             .ForMember(dest => dest.FullName, opt => opt.MapFrom(opt => opt.FullName))
                           .ForMember(dest => dest.Email, opt => opt.MapFrom(opt => opt.Email))
                          .ForMember(dest => dest.Phone, opt => opt.MapFrom(opt => opt.Phone))

                          .ForMember(dest => dest.Password, opt => opt.MapFrom(opt => opt.Password))

                          .ForMember(dest => dest.Bio, opt => opt.MapFrom(opt => opt.Bio))
                         .ForMember(dest => dest.UrlImage, opt => opt.MapFrom(opt => opt.UrlImage))
                          .ForMember(dest => dest.Rating, opt => opt.MapFrom(opt => opt.Courses.Average(c => c.Rating)))
                            .ForMember(dest => dest.NumberStudent, opt => opt.MapFrom(opt => opt.Courses.Sum(c=>c.Enrollments.Count)))
                            .ForMember(dest => dest.NumberCourse, opt => opt.MapFrom(opt => opt.Courses.Count))
                             .ForMember(dest => dest.SubCategories , opt => opt.MapFrom(opt => opt.Courses.Select(c=>c.SubCategory).Distinct()))


                          .ReverseMap();

        }
    }
}
