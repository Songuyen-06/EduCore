using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.Abstractions.Services
{
    public interface ICommentService
    {
        public Task AddComment(AddedCommentDTO comment);
        public Task<CommentDTO> GetCommentById(int id);
    }
}
