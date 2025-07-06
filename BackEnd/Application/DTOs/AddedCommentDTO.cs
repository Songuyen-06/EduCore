using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.DTOs
{

    public class AddedCommentDTO
    {
        public string Content { get; set; } = null!;
        public int UserId { get; set; }
        public int? LectureId { get; set; }
        public int? ReplyId { get; set; }

    }
}