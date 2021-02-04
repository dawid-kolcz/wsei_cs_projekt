using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPFLib.Model;
using WPFLib.DAL;

namespace WPFTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RecipeBookContext context = new RecipeBookContext();

            var pt = new ProductType { Name = "Owoc" };

            context.ProductTypes.Add(pt);
            context.SaveChanges();

            var fromDb = context.ProductTypes.Find(1);

            Assert.AreEqual(pt.Name, fromDb.Name);
        }
    }
}
