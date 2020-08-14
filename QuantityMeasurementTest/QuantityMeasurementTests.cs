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



        /// <summary>
        /// Comparsion Check Given Zero Inch And Zero Feet Should Return True.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroFeet_WhenZero_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Feet, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Inch, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given One Inch And One Feet Should Return False.
        /// </summary>
        [Test]
        public void GivenOneInchAndOneFeet_WhenEqualInLength_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Inch, 1.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Feet, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given Zero Feet And Zero Inch Should Return False.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneFeet_WhenEqualInLength_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Feet, 1.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Inch, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given One Feet And Twelve Inch Should Return True.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwelveInch_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Feet, 1.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Inch, 12.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given Twelve Inch And One Feet Should Return True.
        /// </summary>
        [Test]
        public void GivenTwelveInchAndOneFeet_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Inch, 12.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Feet, 1.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Zero Yard and Zero Yard Should Return False.
        /// </summary>
        [Test]
        public void GivenZeroYardAndZeroYard_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Yard, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Yard, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Zero Yard and One Yard Should Return False.
        /// </summary>
        [Test]
        public void GivenTwoDifferentYardValues__ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Yard, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Yard, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given Zero Feet And Zero Yard Should Return True.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroYard_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Feet, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Yard, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given One Feet And One Yard Should Return False.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneYard_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Feet, 1.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Yard, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given Zero Inch And Zero Yard Should Return True.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroYard_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Inch, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Yard, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given One Inch And One Yard Should Return False.
        /// </summary>
        [Test]
        public void GivenOneInchAndOneYard_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Inch, 1.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Yard, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given Thirty Six Feet And One Yard Should Return True.
        /// </summary>
        [Test]
        public void GivenThirtySixInchAndOneYard_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Inch, 36.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Yard, 1.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given One Yard And Three Feet Should Return True.
        /// </summary>
        [Test]
        public void GivenThirtyOneYardAndThreeFeet_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Yard, 1.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Feet, 3.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Zero Centimeter and Zero Centimeter Should Return False.
        /// </summary>
        [Test]
        public void GivenZeroCentimeterAndZeroCentimeter_WhenEqual_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Cm, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Cm, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Zero Centimeter and One Centimeter Should Return False.
        /// </summary>
        [Test]
        public void GivenZeroCentimeterAndOneCentimeter_WhenNotEqual_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Cm, 0.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Cm, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Two Inch and Five Centimeter Should Return True.
        /// </summary>
        [Test]
        public void GivenTwoInchAndFiveCentimeter_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurementOne.UnitConversion(UnitType.Inch, 2.0);
            double valueTwo = this.quantityMeasurementTwo.UnitConversion(UnitType.Cm, 5.0);
            Assert.AreEqual(valueOne, valueTwo);
        }
    }
}