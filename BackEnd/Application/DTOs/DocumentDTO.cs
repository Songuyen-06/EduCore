using EduCore.BackEnd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Application.DTOs
{
    public  class DocumentDTO
    {
        public int DocumentId { get; set; }
        public string Title { get; set; } = null!;
        public string? Url { get; set; }
        public DateTime? CreateDate { get; set; }

    }
}
