using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

using NSubstitute;
using CameraReview.Product.Camera;
using CameraReview.Product.Lens;

namespace CameraReviewUnitTests.CameraReview.Product
{
    [TestClass]    
    public class ProductTest 
    {
        [TestMethod]
        public void CameraAndLenProduct_ShouldReturnContentThatIncludeFeatures_Success() 
        {                   
                  
            var cameraProduct = new Camera
            {
                Name = "Canon Eos",
                Type = "lente",
                CropFactor = 1
            };

            var lenProduct = new Lens
            {
                Name = "Nuevo lente",
                Valor = 9999,
                Type = "Duradero"
            };
          
            var contentCamera = cameraProduct.GetContent();

            var contentLen = lenProduct.GetContent();

            Assert.IsTrue(!string.IsNullOrWhiteSpace(contentCamera), "Should return content but obtained null or white spaces.");

            Assert.IsTrue(!string.IsNullOrWhiteSpace(contentLen), "Should return content but obtained null or white spaces.");


        }
    }
}
