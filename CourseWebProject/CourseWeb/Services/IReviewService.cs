using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface IReviewService
    {
        public Task<List<ReviewDTO>> GetListReview();


    }
}
