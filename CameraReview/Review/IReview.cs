using System;
using System.Collections.Generic;
using System.Text;

using CamaraReview.Product;

namespace CamaraReview.Review
{
    public interface IReview
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public List<string> Autor { get; set; }

        public IProduct Product { get; set; }
    }
}
