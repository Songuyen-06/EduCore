using EduCore.BackEnd.Application.DTOs;

namespace EduCore.Web.Services
{
    public interface IReviewService
    {
        public Task<List<ReviewDTO>> GetListReview();


    }
}
