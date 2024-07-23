using AutoMapper;
using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Profiles
{
    internal class LectureProfile : Profile
    {

        public LectureProfile()
        {
            CreateMap<Lecture, LectureDTO>().
                ForMember(dest => dest.LectureId, opt => opt.MapFrom(opt => opt.LectureId)).
                                ForMember(dest => dest.Title, opt => opt.MapFrom(opt => opt.Title)).
                ForMember(dest => dest.Content, opt => opt.MapFrom(opt => opt.Content)).
                                ForMember(dest => dest.VideoUrl, opt => opt.MapFrom(opt => opt.VideoUrl)).
                ForMember(dest => dest.Duration, opt => opt.MapFrom(opt => opt.Duration));


            ;

        }

    }
}
