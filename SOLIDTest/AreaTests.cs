using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.LSP;

namespace SOLIDTest
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void Rectangle()
        {
            var myRectangle = new RectangleLsp() {Height = 2, Width = 3};
            var result = myRectangle.Area();
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Square()
        {
            var mySquare = new SquareLsp() {Sides = 3};
            var result = mySquare.Area();
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void RectangleFromSquare()
        {
            var shapes = new List<Shape>
            {
                new RectangleLsp() {Height = 4, Width = 6},
                new SquareLsp() {Sides = 3}
            };

            var areas = shapes.Select(shape => shape.Area()).ToList();
            Assert.AreEqual(24, areas[0]);
            Assert.AreEqual(9, areas[1]);
        }
    }
}
