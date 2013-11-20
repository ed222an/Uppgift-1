using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTriangle
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void isIsosceles()
        {
            Triangle iso = new Triangle(1.0, 0.5, 1.0); // Testar metoden med en likbent triangel.
            Assert.IsTrue(iso.isIsosceles());

            Triangle notIso = new Triangle(99.0, 0.5, 1.0); // Testar metoden med en triangel som INTE är likbent.
            Assert.IsFalse(notIso.isIsosceles());
        }

        [TestMethod]
        public void isEquilateral()
        {
            Triangle equi = new Triangle(1.0, 1.0, 1.0); // Testar metoden med en liksidig triangel.
            Assert.IsTrue(equi.isEquilateral());

            Triangle notEqui = new Triangle(99.0, 1.0, 1.0); // Testar metoden med en triangel som INTE är liksidig.
            Assert.IsFalse(notEqui.isEquilateral());
        }

        [TestMethod]
        public void isScalene()
        {
            Triangle scal = new Triangle(1.0, 2.0, 3.0); // Testar metoden med en scalene triangel.
            Assert.IsTrue(scal.isScalene());

            Triangle notScal = new Triangle(1.0, 1.0, 1.0); // Testar metoden med en triangel som är liksidig.
            Assert.IsFalse(notScal.isScalene());

            Triangle anotherNotScal = new Triangle(2.0, 1.0, 1.0); // Testar metoden med en triangel som är likbent.
            Assert.IsFalse(anotherNotScal.isScalene());
        }

    }
}