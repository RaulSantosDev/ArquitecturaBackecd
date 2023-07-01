using CamaraReview.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CameraReview.Product
{
    public class ProductImpl : IProduct
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string SKU { get; set; }
        public List<Feature> Features { get; set; }



        public string GetContent()
        {
            throw new NotImplementedException();
            //return ""; Si lo usamos de esta forma nuestro test va a funcionar porque ya no regresará vacíos.
        }
    }
}
