using CamaraReview.Product;
using CamaraReview.Review;
using System;
using System.Collections.Generic;
using System.Text;

namespace CameraReview.Review.BodyReview
{
    public class Reviews : IReview
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Autor { get; set; }
        public IProduct Product { get; set; }

        public string GetContent()
        {
            return $"Title: {this.Title}\nContent: {Content}\n";
            //return "";
        }
    }
}
