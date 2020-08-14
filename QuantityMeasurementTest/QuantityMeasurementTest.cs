namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurementProblem;
    public class Tests
    {

        Feet feet;

        [SetUp]
        public void Setup()
        {
            feet = new Feet();
        }

        [Test]
        public void givenZeroFeetAndZeroFeet_ShouldReturnEqual()
        {
            double value1 = feet.GetFeet(0.0);
            double value2 = feet.GetFeet(0.0);
            Assert.AreEqual(value1, value2);
        }

        [Test]
        public void givenReferenceForFeet_ShouldReturnEqual()
        {
            Assert.IsFalse(feet.Equals(null));
        }
    }
}