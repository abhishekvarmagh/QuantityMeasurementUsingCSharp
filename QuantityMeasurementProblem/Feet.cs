// <copyright file="Feet.cs" company="BridgeLaz Solution">
// Copyright (c) BridgeLaz Solution. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    /// <summary>
    /// Feet Class.
    /// </summary>
    public class Feet
    {
        /// <summary>
        /// Get Function To Return Feet Value.
        /// </summary>
        /// <param name="feet">Store Feet Value.</param>
        /// <returns>Return Feet Value.</returns>
        public double GetFeet(double feet)
        {
            return feet;
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
