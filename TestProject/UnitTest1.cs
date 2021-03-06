using NUnit.Framework;
using Project_E;
namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Tett_Task1()
        {
            Assert.AreEqual(0, Task1.Solve2(0));
            var n = 1000;
            Assert.AreEqual(Task1.Solve(n), Task1.Solve2(n));
        }


        [Test]
        public void Tett_Task2()
        {
            Assert.AreEqual(0, Task2.Solver(0));
            var n = 10;
            Assert.AreEqual(10, Task2.Solver(n));
        } 
        
        [Test]
        public void Tett_Task3()
        {
             var n = 37;
            Assert.AreEqual(37, Task3.Solve(n));
            Assert.AreEqual(37, Task3.Solve2(n));
        }

        [Test]
        public void Tett_Task4()
        { 
            Assert.AreEqual(9009, Task4.Solve(2));
        }
    }
}