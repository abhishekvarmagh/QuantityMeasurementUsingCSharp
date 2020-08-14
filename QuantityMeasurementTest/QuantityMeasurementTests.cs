// <copyright file="QuantityMeasurementTest.cs" company="BridgeLaz Solution">
// Copyright (c) BridgeLaz Solution. All rights reserved.
// </copyright>

namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurementProblem;

    /// <summary>
    /// Test Class.
    /// </summary>
    public class QuantityMeasurementTests
    {
        private Feet feetOne;
        private Inch inch;

        /// <summary>
        /// functions that is performed just before each test method is called.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.feetOne = new Feet();
            this.inch = new Inch();
        }

        /// <summary>
        /// Given Zero Feet and Zero Feet Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeet_ShouldReturnEqual()
        {
            double valueOne = this.feetOne.GetFeet(0.0);
            double valueTwo = this.feetOne.GetFeet(0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Perform Test For Equality Null Check.
        /// </summary>
        [Test]
        public void GivenNullForFeet_ShouldReturnFalse()
        {
            Assert.IsFalse(this.feetOne.Equals(null));
        }

        /// <summary>
        /// Perform Test For Equality Reference Check.
        /// </summary>
        [Test]
        public void GivenSameReferenceForFeet_ShouldReturnTrue()
        {
            Feet feetTwo = this.feetOne;
            Assert.IsTrue(this.feetOne.Equals(feetTwo));
        }

        /// <summary>
        /// Perform Test For Equality Type Check.
        /// </summary>
        [Test]
        public void GivenFeetObjects_WhenTypeEqual_ShouldReturnTrue()
        {
            Feet feetTwo = new Feet();
            Assert.IsTrue(this.feetOne.Equals(feetTwo));
        }

        /// <summary>
        /// Perform Test For Equality Type Check When Not Equal Should Return False.
        /// </summary>
        [Test]
        public void GivenFeetAndQuantityMeasurementTestsObject_WhenTypeNotEqual_ShouldReturnFalse()
        {
            QuantityMeasurementTests quantityMeasurementTest = new QuantityMeasurementTests();
            Assert.IsFalse(this.feetOne.Equals(quantityMeasurementTest));
        }

        /// <summary>
        /// Perform Test To Value Check For Equality.
        /// </summary>
        [Test]
        public void GivenValue_WhenEqual_ShouldReturnEqual()
        {
            double feetOne = this.feetOne.GetFeet(12.0);
            double feetTwo = this.feetOne.GetFeet(12.0);
            Assert.AreEqual(feetOne, feetTwo);
        }

        /// <summary>
        /// Given Zero Inch and Zero Inch Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroInch_ShouldReturnEqual()
        {
            double valueOne = this.inch.GetInch(0.0);
            double valueTwo = this.inch.GetInch(0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Perform Test For Equality Null Check.
        /// </summary>
        [Test]
        public void GivenNullForInch_ShouldReturnFalse()
        {
            Assert.IsFalse(this.inch.Equals(null));
        }
    }
}