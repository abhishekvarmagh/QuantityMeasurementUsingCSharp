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

        private QuantityMeasurement quantityMeasurement;

        /// <summary>
        /// functions that is performed just before each test method is called.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement();
        }

        /// <summary>
        /// Given Zero Feet and Zero Feet Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeet_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Feet, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Feet, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Perform Test For Equality Null Check.
        /// </summary>
        [Test]
        public void GivenNullForFeet_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Perform Test For Equality Reference Check.
        /// </summary>
        [Test]
        public void GivenSameReferenceForFeet_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = this.quantityMeasurement;
            Assert.IsTrue(this.quantityMeasurement.Equals(quantityMeasurement));
        }

        /// <summary>
        /// Perform Test For Equality Type Check.
        /// </summary>
        [Test]
        public void GivenFeetObjects_WhenTypeEqual_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            Assert.IsTrue(this.quantityMeasurement.Equals(quantityMeasurement));
        }

        /// <summary>
        /// Perform Test For Equality Type Check When Not Equal Should Return False.
        /// </summary>
        [Test]
        public void GivenFeetAndQuantityMeasurementTestsObject_WhenTypeNotEqual_ShouldReturnFalse()
        {
            QuantityMeasurementTests quantityMeasurementTest = new QuantityMeasurementTests();
            Assert.IsFalse(this.quantityMeasurement.Equals(quantityMeasurementTest));
        }

        /// <summary>
        /// Perform Test To Value Check For Equality.
        /// </summary>
        [Test]
        public void GivenValue_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Feet, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Feet, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Zero Inch and Zero Inch Should Return Equal.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroInch_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Inch, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Inch, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Perform Test For Equality Null Check.
        /// </summary>
        [Test]
        public void GivenNullForInch_ShouldReturnFalse()
        {
            Assert.IsFalse(this.quantityMeasurement.Equals(null));
        }

        /// <summary>
        /// Perform Test For Equality Reference Check.
        /// </summary>
        [Test]
        public void GivenSameReferenceForInch_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = this.quantityMeasurement;
            Assert.IsTrue(this.quantityMeasurement.Equals(quantityMeasurement));
        }

        /// <summary>
        /// Perform Test For Equality Type Check.
        /// </summary>
        [Test]
        public void GivenInchObjects_WhenTypeEqual_ShouldReturnTrue()
        {
            QuantityMeasurement quantityMeasurement = new QuantityMeasurement();
            Assert.IsTrue(this.quantityMeasurement.Equals(quantityMeasurement));
        }

        /// <summary>
        /// Perform Test For Equality Type Check When Not Equal Should Return False.
        /// </summary>
        [Test]
        public void GivenInchAndQuantityMeasurementTestsObject_WhenTypeNotEqual_ShouldReturnFalse()
        {
            QuantityMeasurementTests quantityMeasurementTest = new QuantityMeasurementTests();
            Assert.IsFalse(this.quantityMeasurement.Equals(quantityMeasurementTest));
        }

        /// <summary>
        /// Perform Test To Value Check For Equality.
        /// </summary>
        [Test]
        public void GivenValues_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Inch, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Inch, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }



        /// <summary>
        /// Comparsion Check Given Zero Inch And Zero Feet Should Return True.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroFeet_WhenZero_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Feet, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Inch, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given One Inch And One Feet Should Return False.
        /// </summary>
        [Test]
        public void GivenOneInchAndOneFeet_WhenEqualInLength_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Inch, 1.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Feet, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given Zero Feet And Zero Inch Should Return False.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneFeet_WhenEqualInLength_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Feet, 1.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Inch, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given One Feet And Twelve Inch Should Return True.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwelveInch_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Feet, 1.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Inch, 12.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given Twelve Inch And One Feet Should Return True.
        /// </summary>
        [Test]
        public void GivenTwelveInchAndOneFeet_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Inch, 12.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Feet, 1.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Zero Yard and Zero Yard Should Return False.
        /// </summary>
        [Test]
        public void GivenZeroYardAndZeroYard_WhenEqual_ShouldReturnEqual()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Yard, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Yard, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Zero Yard and One Yard Should Return False.
        /// </summary>
        [Test]
        public void GivenTwoDifferentYardValues__ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Yard, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Yard, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given Zero Feet And Zero Yard Should Return True.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroYard_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Feet, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Yard, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given One Feet And One Yard Should Return False.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneYard_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Feet, 1.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Yard, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given Zero Inch And Zero Yard Should Return True.
        /// </summary>
        [Test]
        public void GivenZeroInchAndZeroYard_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Inch, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Yard, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given One Inch And One Yard Should Return False.
        /// </summary>
        [Test]
        public void GivenOneInchAndOneYard_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Inch, 1.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Yard, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given Thirty Six Feet And One Yard Should Return True.
        /// </summary>
        [Test]
        public void GivenThirtySixInchAndOneYard_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Inch, 36.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Yard, 1.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Comparsion Check Given One Yard And Three Feet Should Return True.
        /// </summary>
        [Test]
        public void GivenThirtyOneYardAndThreeFeet_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Yard, 1.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Feet, 3.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Zero Centimeter and Zero Centimeter Should Return False.
        /// </summary>
        [Test]
        public void GivenZeroCentimeterAndZeroCentimeter_WhenEqual_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Cm, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Cm, 0.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Zero Centimeter and One Centimeter Should Return False.
        /// </summary>
        [Test]
        public void GivenZeroCentimeterAndOneCentimeter_WhenNotEqual_ShouldReturnFalse()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Cm, 0.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Cm, 1.0);
            Assert.AreNotEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Two Inch and Five Centimeter Should Return True.
        /// </summary>
        [Test]
        public void GivenTwoInchAndFiveCentimeter_ShouldReturnTrue()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Inch, 2.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Cm, 5.0);
            Assert.AreEqual(valueOne, valueTwo);
        }

        /// <summary>
        /// Given Two Inch and Two Inch When Added Should Return Four Inch.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoInch_WhenAdded_ShouldReturnFourInch()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Inch, 2.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Inch, 2.0);
            Assert.AreEqual(4.0, this.quantityMeasurement.UnitAddition(valueOne, valueTwo));
        }

        /// <summary>
        /// Given One Feet and Two Inch When Added Should Return Fourteen Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetAndTwoInch_WhenAdded_ShouldReturnFourInch()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Feet, 1.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Inch, 2.0);
            Assert.AreEqual(14.0, this.quantityMeasurement.UnitAddition(valueOne, valueTwo));
        }

        /// <summary>
        /// Given One Feet and One Feet When Added Should Return Twenty Four Inch.
        /// </summary>
        [Test]
        public void GivenOneFeetAndOneFeet_WhenAdded_ShouldReturnTwentyFourInch()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Feet, 1.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Feet, 1.0);
            Assert.AreEqual(24.0, this.quantityMeasurement.UnitAddition(valueOne, valueTwo));
        }

        /// <summary>
        /// Given Two Inch and Two Point Five Centimeter When Added Should Return Three Inch.
        /// </summary>
        [Test]
        public void GivenTwoInchAndTwoPointFiveCentimeter_WhenAdded_ShouldReturnThreeInch()
        {
            double valueOne = this.quantityMeasurement.UnitConversion(UnitType.Inch, 2.0);
            double valueTwo = this.quantityMeasurement.UnitConversion(UnitType.Cm, 2.5);
            Assert.AreEqual(3.0, this.quantityMeasurement.UnitAddition(valueOne, valueTwo));
        }
    }
}