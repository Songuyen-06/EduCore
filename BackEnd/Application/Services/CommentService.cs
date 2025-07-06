using AutoMapper;

using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Application.Abstractions.Services;


namespace EduCore.BackEnd.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public CommentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task AddComment(AddedCommentDTO comment)
        {
            try
            {
                var c = mapper.Map<Comment>(comment);
                unitOfWork.CommentRepository.Add(c);
                unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                unitOfWork.Rollback();
            }
        }

        public async Task<CommentDTO> GetCommentById(int id)
        {

            return mapper.Map<CommentDTO>(await unitOfWork.CommentRepository.GetCommentById(id));
        }
    }
}
