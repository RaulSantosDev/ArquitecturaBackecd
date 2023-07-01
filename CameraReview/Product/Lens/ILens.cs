using System;
using System.Collections.Generic;
using System.Text;

namespace CamaraReview.Product.Lens
{
    public interface ILens : IProduct
    {
        public int Valor { get; set; }

        public string Type { get; set; }

        public int Material { get; set; }
    }
}
