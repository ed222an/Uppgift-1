using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTriangle
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void testisIsoscelesWithIsoscelesValues() // Testar metoden med en likbent triangel.
        {
            Triangle iso = new Triangle(1.0, 0.5, 1.0);
            Assert.IsTrue(iso.isIsosceles());
        }

        [TestMethod]
        public void testisIsoscelesWithScaleneValues() // Testar metoden med en triangel som INTE är likbent.
        {
            Triangle notIso = new Triangle(99.0, 0.5, 1.0);
            Assert.IsFalse(notIso.isIsosceles());
        }

        [TestMethod]
        public void testisIsoscelesWithEquilateralValues() // Testar metoden med en triangel som INTE är likbent.
        {
            Triangle anotherNotIso = new Triangle(1.0, 1.0, 1.0);
            Assert.IsFalse(anotherNotIso.isIsosceles());
        }

        [TestMethod]
        public void testisEquilateralWithEquilateralValues() // Testar metoden med en liksidig triangel.
        {
            Triangle equi = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(equi.isEquilateral());
        }

        [TestMethod]
        public void testisEquilateralWithIsoscelesValues() // Testar metoden med en triangel som INTE är liksidig.
        {
            Triangle notEqui = new Triangle(1.0, 0.5, 1.0);
            Assert.IsFalse(notEqui.isEquilateral());
        }

        [TestMethod]
        public void testisEquilateralWithScaleneValues() // Testar metoden med en triangel som INTE är liksidig.
        {
            Triangle anotherNotEqui = new Triangle(1.0, 2.0, 3.0);
            Assert.IsFalse(anotherNotEqui.isEquilateral());
        }

        [TestMethod]
        public void testisScaleneWithScaleneValues() // Testar metoden med en scalene triangel.
        {
            Triangle scal = new Triangle(1.0, 2.0, 3.0);
            Assert.IsTrue(scal.isScalene());
        }

        [TestMethod]
        public void testisScaleneWithIsocelesValues() // Testar metoden med en triangel som är likbent.
        {
            Triangle anotherNotScal = new Triangle(1.0, 2.0, 2.0);
            Assert.IsFalse(anotherNotScal.isScalene());
        }

        [TestMethod]
        public void testisScaleneWithEquilateralValues() // Testar metoden med en triangel som är liksidig.
        {
            Triangle notScal = new Triangle(1.0, 1.0, 1.0);
            Assert.IsFalse(notScal.isScalene());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testNegativeValuesInConstructor() // Testar konstruktorn med negativa värden.
        {
            Triangle negativeValues = new Triangle(-1.0, -0.5, -1.0);
        }

        [TestMethod]
        public void testWithThreePoint() // Testar med tre points.
        {
            Point a = new Point(1, 2);
            Point b = new Point(2, 3);
            Point c = new Point(4, 5);

            Triangle tri = new Triangle(a, b, c);
            Assert.IsTrue(tri.isScalene());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testWithTwoPoint() // Testar med två points.
        {
            Point a = new Point(1, 2);
            Point b = new Point(2, 3);

            Triangle tri = new Triangle(new Point[] { a, b});
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testWithFourPoint() // Testar med fyra points.
        {
            Point a = new Point(1, 2);
            Point b = new Point(2, 3);
            Point c = new Point(1, 2);
            Point d = new Point(2, 3);

            Triangle tri = new Triangle(new Point[] { a, b, c, d });
        }
    }
}