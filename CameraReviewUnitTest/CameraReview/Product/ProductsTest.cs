using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

using NSubstitute;
using CameraReview.Product;
using CameraReview.Product.Camera;

namespace CameraReviewUnitTests.CameraReview.Product
{
    

    [TestClass]    
    public class ProductTest 
    {
        [TestMethod]
        public void CameraProduct_ShouldReturnContentThatIncludeFeatures_Success() 
        {

            //setup --> 
            //var product = Substitute.For<IProduct>(); 
            var type = "FullFrame";

            //var cameraProduct = Substitute.For<ICamera>(); //Recordemos que el substitute.For hace la simulación de un objeto para que nuestro test funcione pero lo ideal es crear una instancia de nuestro objeto para que pueda funcionar como haremos mas abajo.

            var cameraProduct = new Camera
            {
                Name = "Canon Eos",
                Type = "lente",
                CropFactor = 1
            };

            //exec -->
            var content = cameraProduct.GetContent();

            //assert -->
            //Assert.IsNotNull(content);

            Assert.IsTrue(!string.IsNullOrWhiteSpace(content), "Should return content but obtained null or white spaces.");
            //Assert.IsTrue(content.Contains(Type));


        }
    }
}
