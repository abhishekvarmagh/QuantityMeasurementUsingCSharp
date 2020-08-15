// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    /// <summary>
    /// Length Class.
    /// </summary>
    public class QuantityMeasurement
    {
        public double UnitConversion(UnitType units, double value)
        {
            return value * units.value;
        }

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
        /// Overiding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
