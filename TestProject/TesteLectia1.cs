using ConsoleApp1.Lectia1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class TesteLectia1
    {
        [TestMethod]
        public void TestShowFullName()
        {
            Assert.AreEqual(Lectia1.GetFullName("Alex", "Pop"), "AlexPop");
        }

        [TestMethod]
        public void TestShowFullName_JustLetters()
        {
            Assert.AreEqual(Lectia1.GetFullName("A", "B"), "AB");
        }

        [TestMethod]
        public void TestShowFullName_SpacesIncluded()
        {
            Assert.AreEqual(Lectia1.GetFullName("X ", "Y"), "X Y");
        }

        [TestMethod]
        public void TestAriaCerc()
        {
            Assert.AreEqual(Lectia1.AriaCerc(2.5), 2.5 * 3.14 * 2.5);
        }
        [TestMethod]
        public void TestAriaCerc_Intreg()
        {
            Assert.AreEqual(Lectia1.AriaCerc(5), 5 * 3.14 * 5);
        }

        [TestMethod]
        public void TestWacky()
        {
            Assert.AreEqual(Lectia1.Wacky(8, 7), 54);
        }
        [TestMethod]
        public void TestWacky2()
        {
            Assert.AreEqual(Lectia1.Wacky(8, 3), 18);
        }

        [TestMethod]
        public void Bisect_EndOfCenturyButDivisibleWith400()
        {   
            Assert.IsTrue(Lectia1.Bisect(2000));
        }
        [TestMethod]
        public void Bisect_EndOfCenturyButNotDivisibleWith400()
        {
            Assert.IsFalse(Lectia1.Bisect(1900));
        }

        [TestMethod]
        public void Bisect_NotBisect()
        {
            Assert.IsFalse(Lectia1.Bisect(2001));
        }

        [TestMethod]
        public void Bisect_NotEndOfCentury_DivisibleWith4() 
        {
            Assert.IsTrue(Lectia1.Bisect(2016));
        }

        [TestMethod]
        public void GetUSGrade_10() 
        {
            Assert.AreEqual(Lectia1.GetUSGrade(10), "A");
        }

        [TestMethod]
        public void GetUSGrade_9()
        {
            Assert.AreEqual(Lectia1.GetUSGrade(9), "B");
        }
        [TestMethod]
        public void GetUSGrade_8()
        {
            Assert.AreEqual(Lectia1.GetUSGrade(8), "B");
        }
        [TestMethod]
        public void GetUSGrade_7()
        {
            Assert.AreEqual(Lectia1.GetUSGrade(7), "C");
        }
        [TestMethod]
        public void GetUSGrade_6()
        {
            Assert.AreEqual(Lectia1.GetUSGrade(6), "D");
        }
        [TestMethod]
        public void GetUSGrade_5()
        {
            Assert.AreEqual(Lectia1.GetUSGrade(6), "D");
        }
        [TestMethod]
        public void GetUSGrade_4()
        {
            Assert.AreEqual(Lectia1.GetUSGrade(6), "F");
        }
        [TestMethod]
        public void GetUSGrade_3()
        {
            Assert.AreEqual(Lectia1.GetUSGrade(6), "F");
        }
        [TestMethod]
        public void GetUSGrade_2()
        {
            Assert.AreEqual(Lectia1.GetUSGrade(6), "F");
        }
        [TestMethod]
        public void GetUSGrade_1()
        {
            Assert.AreEqual(Lectia1.GetUSGrade(6), "F");
        }
    }
}