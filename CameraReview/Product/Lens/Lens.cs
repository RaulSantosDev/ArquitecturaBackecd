using System;
using System.Collections.Generic;
using System.Text;
using CamaraReview.Product;
using CamaraReview.Product.Lens;


namespace CameraReview.Product.Lens
{
    public class Lens : ILens
    {
        public int Valor { get; set; }
        public string Type { get; set; }
        public int Material { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string SKU { get; set; }
        public List<Feature> Features { get; set; }

        public string GetContent()
        {
            return $"Name: {this.Name}\nValor: {Valor}\nMaterial: {Material}";
            //return ""; // Si usamos este nuestro test fallará
        }

    }
}
