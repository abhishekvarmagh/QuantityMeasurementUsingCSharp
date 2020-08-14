// <copyright file="QuantityMeasurementTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
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

        private QuantityMeasurement quantityMeasurementOne;
        private QuantityMeasurement quantityMeasurementTwo;

        /// <summary>
        /// functions that is performed just before each test method is called.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurementOne = new QuantityMeasurement();
            this.quantityMeasurementTwo = new QuantityMeasurement();
        }

        /// <summary>
        /// Given Zero Feet and Zero Feet Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeet_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Feet, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Feet, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Perform Test For Equality Null Check.
        /// </summary>
        [Test]
        public void GivenNullForFeet_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurementOne.Equals(null));
        }

        /// <summary>
        /// Perform Test For Equality Reference Check.
        /// </summary>
        [Test]
        public void GivenSameReferenceForFeet_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = this.quantityMeasurementOne;
            Assert.IsTrue(this.quantityMeasurementOne.Equals(quantityMeasurement));
        }

        /// <summary>
        /// Perform Test For Equality Type Check.
        /// </summary>
        [Test]
        public void GivenFeetObjects_WhenTypeEqual_ShouldReturnTrue()
        {
            Assert.IsTrue(this.quantityMeasurementOne.Equals(this.quantityMeasurementTwo));
        }

        /// <summary>
        /// Perform Test For Equality Type Check When Not Equal Should Return False.
        /// </summary>
        [Test]
        public void GivenFeetAndQuantityMeasurementTestsObject_WhenTypeNotEqual_ShouldReturnFalse()
        {
            QuantityMeasurementTests quantityMeasurementTest = new QuantityMeasurementTests();
            Assert.IsFalse(this.quantityMeasurementOne.Equals(quantityMeasurementTest));
        }

        /// <summary>
        /// Perform Test To Value Check For Equality.
        /// </summary>
        [Test]
        public void GivenValue_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Feet, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Feet, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Zero Inch and Zero Inch Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroInch_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Inch, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Inch, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Perform Test For Equality Null Check.
        /// </summary>
        [Test]
        public void GivenNullForInch_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurementOne.Equals(null));
        }

        /// <summary>
        /// Perform Test For Equality Reference Check.
        /// </summary>
        [Test]
        public void GivenSameReferenceForInch_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = this.quantityMeasurementOne;
            Assert.IsTrue(this.quantityMeasurementOne.Equals(quantityMeasurement));
        }

        /// <summary>
        /// Perform Test For Equality Type Check.
        /// </summary>
        [Test]
        public void GivenInchObjects_WhenTypeEqual_ShouldReturnTrue()
        {
            Assert.IsTrue(this.quantityMeasurementOne.Equals(this.quantityMeasurementTwo));
        }

        /// <summary>
        /// Perform Test For Equality Type Check When Not Equal Should Return False.
        /// </summary>
        [Test]
        public void GivenInchAndQuantityMeasurementTestsObject_WhenTypeNotEqual_ShouldReturnFalse()
        {
            QuantityMeasurementTests quantityMeasurementTest = new QuantityMeasurementTests();
            Assert.IsFalse(this.quantityMeasurementOne.Equals(quantityMeasurementTest));
        }

        /// <summary>
        /// Perform Test To Value Check For Equality.
        /// </summary>
        [Test]
        public void GivenValues_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Inch, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Inch, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }
    }
}