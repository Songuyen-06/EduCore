using CourseDomain;
using CourseDomain.DTOs;
using CourseDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public interface IReviewService
    {
        Task<List<ReviewDTO>> GetListReviewByCourseIdAndFilterByAll(int courseId, bool isNewest, int rating);


        Task<List<ReviewDTO>> GetListReviewByCourseIdAndFilterByRating(int courseId, int rating);

        Task<List<ReviewDTO>> GetListReviewByCourseId(int courseId);

        Task<List<ReviewDTO>> GetListReviewByCourseIdAndFilterByDate(int courseId, bool isNewest);
        Task<List<ReviewDTO>> GetListReview();

    }
}
