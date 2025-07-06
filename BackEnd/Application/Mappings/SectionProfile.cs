using AutoMapper;
using AutoMapper.Features;
using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Linq;

namespace EduCore.BackEnd.Application.Mappings
{
    public class SectionProfile : Profile
    {
        public SectionProfile()
        {
            CreateMap<Section, SectionDTO>()
                .ForMember(dest => dest.SectionId, opt => opt.MapFrom(src => src.SectionId))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.LectureNumber, opt => opt.MapFrom(src => src.Lectures.Count))
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => CalculateTotalDuration(src.Lectures.ToList())))
                .ForMember(dest => dest.Lectures, opt => opt.MapFrom(src => src.Lectures))
                .ReverseMap();
        }

        private string CalculateTotalDuration(List<Lecture> lectures)
        {
            TimeSpan totalDuration = TimeSpan.Zero;
            foreach (var l in lectures)
            {             
                
                    totalDuration += l.Duration.Value;
                
            }
            return totalDuration.ToString(@"hh\:mm");
        }
    }
}
