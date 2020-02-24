using NUnit.Framework;
//using Program.cs;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {   
            Program px = new Program();
            string ans1 = px.Prefix("hello");
            Assert.That(ans1, Is.EqualTo("5,1:hello"));
        }
        [Test]

        public void Test2()
        {
            Program px1 = new Program();
            string ans2 = px1.Prefix("");
            Assert.That(ans2, Is.EqualTo( "0,0:"));
        }
        [Test]
        public void Test3()
        {
            Program px2 = new Program();
            string ans3 = px2.Prefix("what ... did you say?? ");
            Assert.That(ans3, Is.EqualTo("27,5:what ... did you say?? "));

        }

    }
}