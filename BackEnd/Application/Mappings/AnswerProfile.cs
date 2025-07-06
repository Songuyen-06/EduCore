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

    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {
            CreateMap<Answer, AnswerDTO>()
            .ForMember(dest => dest.AnswerId, opt => opt.MapFrom(src => src.AnswerId))
            .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Text))
            .ForMember(dest => dest.IsCorrect, opt => opt.MapFrom(src => src.IsCorrect)).ReverseMap();
        }
    }
}