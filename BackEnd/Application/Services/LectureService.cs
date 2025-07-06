using AutoMapper;

using EduCore.BackEnd.Application.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Application.Abstractions.Services;

namespace EduCore.BackEnd.Application.Services
{
    public class LectureService : ILectureService
    {
        public readonly IUnitOfWork unitOfWork;
        public IMapper mapper;
        public LectureService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }
        public async Task<LectureDetailDTO> GetLectureDetailById(int id)
        {
            var repliedComment = await unitOfWork.CommentRepository.GetListRepliedCommentByLectureId(id);
            var lecture = await unitOfWork.LectureRepository.GetLectureDetailById(id);
            lecture.Comments = repliedComment;
            return mapper.Map<LectureDetailDTO>(lecture);
        }

       
    }
}
