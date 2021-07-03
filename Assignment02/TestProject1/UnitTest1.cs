//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assignment02;


namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //TriangleSolver TS = new TriangleSolver();
            //Assert.AreEqual("equql", math.Analyze());
            int  ac = new TriangleSolver(2,2,2);
           // string result = "equal";
            Assert.AreEqual("equal" ,TriangleSolver.Analyze());

           // int result= TriangleSolver.Analyze(2, 2, 2);
            Assert.That(result,Is.EqualTo())

        }
    }
}
