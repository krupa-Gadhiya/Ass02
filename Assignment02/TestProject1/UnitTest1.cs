using NUnit.Framework;
using Assignment02;

namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
         [Test]
        public void GetTriangle_AllPosive_IncludeZero()
        {
            int t1 = 0;
            int t2 = 12;
            int t3 = 22;

            string expected = "Does not form a triangle";
            var actual = TriangleSolver.Analyze(t1,t2,t3);
             Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Get_Triangle_AllPositiveValue()
        {
            int t1 = 2;
            int t2 = 22;
            int t3 = 21;

            string expected = "Scalene triangle";
            string actual = TriangleSolver.Analyze(t1, t2, t3);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Get_Triangle_AllNagativeNumber()
        {
            int t1 = -2;
            int t2 = -2;
            int t3 = -2;

            string expected = "Does not form a triangle";
            string actual = TriangleSolver.Analyze(t1, t2, t3);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Get_Triangle_TwoSameValue_OneDifferent()

        {
            int t1 = 1;
            int t2 = 1;
            int t3 = 2;

            string expected = "Does not form a triangle";
            string actual = TriangleSolver.Analyze(t1, t2, t3);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Get_Triangle_twoSameValue()

        {
            int t1 = 99;
            int t2 = 99;
            int t3 = 2;

            string expected = "Isosceles triangle";
            string actual = TriangleSolver.Analyze(t1, t2, t3);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Get_Triangle_AllSameValue()

        {
            int t1 = 11;
            int t2 = 11;
            int t3 = 11;

            string expected = "Equilateral triangle";
            string actual = TriangleSolver.Analyze(t1, t2, t3);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Get_Triangle_twoPositiveValue_oneNagativeValue()
        {
            int t1 = 26;
            int t2 = 22;
            int t3 = -9;

            string expected = "Does not form a triangle";
            string actual = TriangleSolver.Analyze(t1, t2, t3);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void GetTriangle_TwoNagativeOnePositiveVale()
        {
            int t1 = -30;
            int t2 = -30;
            int t3 = 20;

            string expected = "Does not form a triangle";
            string actual = TriangleSolver.Analyze(t1, t2, t3);
            Assert.AreEqual(expected, actual);

        }
    }
}
