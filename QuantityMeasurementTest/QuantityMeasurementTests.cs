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

        /// <summary>
        /// functions that is performed just before each test method is called.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.feetOne = new Feet();
        }

        /// <summary>
        /// Given Zero Feet and Zero Feet Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeet_ShouldReturnEqual()
        {
            double value1 = this.feetOne.GetFeet(0.0);
            double value2 = this.feetOne.GetFeet(0.0);
            Assert.AreEqual(value1, value2);
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
    }
}