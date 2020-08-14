// <copyright file="Inch.cs" company="BridgeLabz Solution">
// Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    /// <summary>
    /// Inch Class.
    /// </summary>
    public class Inch
    {
        /// <summary>
        /// Get Function To Return Inch Value.
        /// </summary>
        /// <param name="inch">Store Inch Value.</param>
        /// <returns>Return Inch Value.</returns>
        public double GetInch(double inch)
        {
            return inch;
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
