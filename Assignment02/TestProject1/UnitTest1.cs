//using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
