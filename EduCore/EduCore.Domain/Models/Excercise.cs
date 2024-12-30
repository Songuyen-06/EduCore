using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Domain.Models
{
    public partial class Exercise
    {
        public int ExerciseId { get; set; }

        public int LectureId { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public string? ExerciseUrl { get; set; } // URL của bài tập trên Google Drive

        public virtual Lecture Lecture { get; set; } = null!;
    }

}
