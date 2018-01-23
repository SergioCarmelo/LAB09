
using NUnit.Framework;

namespace LAB09
{
    [TestFixture]
   public class MyMathTests
    {
      
        [TestCase]
        public void CompareAdd01Asserts()
        {
            var actual = new MyMath ();
            var expected = 2;
            Assert.AreEqual(expected, actual.Add(1,1));
           
        }
        [TestCase]
        public void CompareAdd02Asserts()
        {
            var actual = new MyMath();
            var expected = 4;
            Assert.AreEqual(expected, actual.Add(2, 2));

        }
        public void TrueAdd03Asserts()
        {
            var actual = new MyMath();
            Assert.IsTrue(actual.Add(2, 2)==4);

        }
        [TestCase]
        public void CompareSub01Asserts()
        {
            var actual = new MyMath();
            Assert.AreEqual(0, actual.Sub(1, 1));

        }
        [TestCase]
        public void CompareSub02Asserts()
        {
            var actual = new MyMath();
            Assert.AreEqual(0, actual.Sub(2, 2));

        }
        public void CompareSub03Asserts()
        {
            var actual = new MyMath();
            Assert.IsTrue(actual.Sub(2, 2) == 0);

        }

        public void CompareMul01Asserts()
        {
            var actual = new MyMath();
            Assert.AreEqual(0, actual.Mul(1, 1));

        }
        [TestCase]
        public void NotNullMul02Asserts()
        {
            var actual = new MyMath();
            Assert.IsNotNull(actual.Mul(2, 2));

        }
        public void CompareIntDiv01Asserts()
        {
            var actual = new MyMath();
            Assert.AreEqual(0, actual.Div(1, 1));

        }
        [TestCase]
        public void CompareDiv01Asserts()
        {
            var actual = new MyMath();
            Assert.AreEqual(1, actual.Div(0.1, 0.1));

        }
    }
}
