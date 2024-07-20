using AutoMapper;
using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Profiles
{
    internal class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<Review, ReviewDTO>().
               ForMember(dest => dest.ReviewId, opt => opt.MapFrom(opt => opt.ReviewId)).
               ForMember(dest => dest.StudentName, opt => opt.MapFrom(opt => opt.Student.FullName)).
                  ForMember(dest => dest.CourseName, opt => opt.MapFrom(opt => opt.Course.Title)).
                   ForMember(dest => dest.Rating, opt => opt.MapFrom(opt => opt.Rating)).
                ForMember(dest => dest.Comment, opt => opt.MapFrom(opt => opt.Comment)).
                ForMember(dest => dest.ReviewDate, opt => opt.MapFrom(src => src.ReviewDate)).
                               ForMember(dest => dest.ReOpen, opt => opt.MapFrom(opt => opt.ReOpen)).

            ReverseMap();



        }
    }
}
