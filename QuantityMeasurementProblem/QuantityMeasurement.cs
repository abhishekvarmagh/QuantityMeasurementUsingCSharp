// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    /// <summary>
    /// Quantity Measurement Class.
    /// </summary>
    public class QuantityMeasurement
    {
        /// <summary>
        /// Get Unit Converted Value.
        /// </summary>
        /// <param name="units">Unit Type.</param>
        /// <param name="value">Value To Be Converted.</param>
        /// <returns>Return Value Which Is Converted.</returns>
        public double UnitConversion(UnitType units, double value)
        {
            return units == UnitType.Celsius ? (value * units.value) + 32 : value * units.value;
        }

        /// <summary>
        /// Get Addition Of Converted Value.
        /// </summary>
        /// <param name="valueOne">Converted Value One.</param>
        /// <param name="valueTwo">Converted Value Two.</param>
        /// <returns>Added Converted Value.</returns>
        public double UnitAddition(double valueOne, double valueTwo)
        {
            return valueOne + valueTwo;
        }

        /// <summary>
        /// Method For Equality Check.
        /// </summary>
        /// <param name="obj">Reference Of Object.</param>
        /// <returns>True Or False.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            if (this.GetType() == obj.GetType())
            {
                return true;
            }

            return base.Equals(obj);
        }

        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
