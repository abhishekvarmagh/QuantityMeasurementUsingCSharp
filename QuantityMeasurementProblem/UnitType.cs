// <copyright file="UnitType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    /// <summary>
    /// Unit Type Class.
    /// </summary>
    public class UnitType
    {
        /// <summary>
        /// Lenght Unit Of Feet Type.
        /// </summary>
        public static readonly UnitType Feet = new UnitType(12.0);

        /// <summary>
        /// Lenght Unit of Inch Type.
        /// </summary>
        public static readonly UnitType Inch = new UnitType(1.0);

        /// <summary>
        /// Lenght Unit Of Yard Type.
        /// </summary>
        public static readonly UnitType Yard = new UnitType(36.0);

        /// <summary>
        /// Lenght Unit of Centimeter Type.
        /// </summary>
        public static readonly UnitType Cm = new UnitType(0.4);

        /// <summary>
        /// Volume Unit Of Litre Type.
        /// </summary>
        public static readonly UnitType Litre = new UnitType(1.0);

        /// <summary>
        /// Volume Unit Of Gallon Type.
        /// </summary>
        public static readonly UnitType Gallon = new UnitType(3.78);

        /// <summary>
        /// Volume Unit Of Millilitre Type.
        /// </summary>
        public static readonly UnitType Millilitre = new UnitType(0.001);

        /// <summary>
        /// Weight Unit Of Kilogram Type.
        /// </summary>
        public static readonly UnitType Kilogram = new UnitType(1.0);

        /// <summary>
        /// Weight Unit Of Gram Type.
        /// </summary>
        public static readonly UnitType Gram = new UnitType(0.001);

        /// <summary>
        /// Weight Unit Of Tonne Type.
        /// </summary>
        public static readonly UnitType Tonne = new UnitType(1000.0);

        /// <summary>
        /// Temperature Unit Of Celsius Type.
        /// </summary>
        public static readonly UnitType Celsius = new UnitType(1.8);

        /// <summary>
        /// Temperature Unit Of Fahrehneit Type.
        /// </summary>
        public static readonly UnitType Fahrehneit = new UnitType(1.0);

        /// <summary>
        /// Conversion Value.
        /// </summary>
        public double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitType"/> class.
        /// Initializing Conversion Value.
        /// </summary>
        /// <param name="value">Base Unit Of Conversion.</param>
        public UnitType(double value)
        {
            this.value = value;
        }
    }
}
