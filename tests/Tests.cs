using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using CircleSphereProject;

namespace CircleSphereProject.Tests
{
    [TestClass()]
    public class Tests
    {
        [TestMethod()]
        public void TestConstructor()
        {
            try
            {
                Geometry geometry = new Geometry(3.5);
            }
            catch (Exception e)
            {
                Assert.Fail("A Geometry konstruktor hibás dob");
            }
        }
        [TestMethod()]
        public void TestToString()
        {
            {
                Geometry geometry = new Geometry(4.67);
                var culture = System.Globalization.CultureInfo.CurrentCulture;
                string expected = "";
                if (culture.ToString() == "hu-HU")
                    expected = "A kör sugara:4,67";
                else
                    expected = "A kör sugara:4.67";
                string actual = geometry.ToString();
                Assert.AreEqual(expected, actual, "A ToString metódus nem megfelelően működik!");
            }
        }
        [TestMethod()]
        public void TestCircleArea()
        {
            Geometry geometry = new Geometry(4.67);
            double expected = 68.515;
            double actual = geometry.CircleArea;
            Assert.AreEqual(expected, actual, 0.001, "A kör területét nem jól határozza meg");
        }

        [TestMethod()]
        public void TestSphereVolume()
        {
            Geometry geometry = new Geometry(4.67);
            double expected = 426.618;
            double actual = geometry.SphereVolume;
            Assert.AreEqual(expected, actual, 0.001, "A gömb térfogatátnem jól határozza meg");
        }
    }
}
