using MovieApp.Context;
using MovieApp.Interface;
using MovieApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Service
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly InstrukcjaDbContext context;
        public ReviewRepository(InstrukcjaDbContext _context)
        {
            context = _context;
        }
        public Review Delete(int reviewId)
        {
            Review review = context.Reviews.Find(reviewId);
            if (review != null)
            {
                context.Reviews.Remove(review);
                context.SaveChanges();
            }
            return review;
        }
        public Review Get(int reviewId)
        {
            return context.Reviews.Find(reviewId);
        }
        public IEnumerable<Review> GetAll()
        {
            return context.Reviews;
        }
        public Review Post(Review newReview)
        {
            context.Reviews.Add(newReview);
            context.SaveChanges();
            return newReview;
        }
        public Review Put(Review updatedReview)
        {
            var review = context.Reviews.Attach(updatedReview);
            review.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return updatedReview;
        }
    }
}
