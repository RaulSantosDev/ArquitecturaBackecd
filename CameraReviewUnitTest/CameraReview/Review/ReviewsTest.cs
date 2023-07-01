using CameraReview.Review.BodyReview;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CameraReviewUnitTests.CameraReview.Review
{
    [TestClass]
    public class ReviewsTest
    {
        [TestMethod]
        public void Review_ShouldReturnContentThat_Success()
        {
            var reviewTest = new Reviews
            {
              Title = "Reseña",
              Content = "lipsun dorime"
            };

            var contentReview = reviewTest.GetContent();

            Assert.IsTrue(!string.IsNullOrWhiteSpace(contentReview), "Should return content but obtained null or white spaces.");
        }
    }
}
