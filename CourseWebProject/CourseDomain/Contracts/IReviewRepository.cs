﻿


using CourseDomain;
using CourseDomain.Models;

namespace CourseDomain
{
    public interface IReviewRepository : IGenericRepository<Review>
    {
        public IQueryable<Review> GetListReviewByCourseIdAndFilterByAll(int courseId, bool isNewest, int rating);

        public IQueryable<Review> GetListReviewByCourseIdAndFilterByDate(int courseId, bool isNewest);
        public IQueryable<Review> GetListReviewByCourseIdAndFilterByRating(int courseId, decimal rating);
        public IQueryable<Review> GetListReviewByCourseId(int courseId);
        public IQueryable<Review> GetListReviewByInclude();


    }
}
