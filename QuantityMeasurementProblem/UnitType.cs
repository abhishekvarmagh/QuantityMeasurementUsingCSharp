// <copyright file="UnitType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    public class UnitType
    {
        public static readonly UnitType Feet = new UnitType(12.0);

        public static readonly UnitType Inch = new UnitType(1.0);

        public static readonly UnitType Yard = new UnitType(36.0);

        public static readonly UnitType Cm = new UnitType(0.4);

        public static readonly UnitType Litre = new UnitType(1.0);

        public static readonly UnitType Gallon = new UnitType(3.78);

        public static readonly UnitType Millilitre = new UnitType(0.001);

        public static readonly UnitType Kilogram = new UnitType(1.0);

        public static readonly UnitType Gram = new UnitType(0.001);

        public static readonly UnitType Tonne = new UnitType(1000.0);

        public double value;

        public UnitType(double value)
        {
            this.value = value;
        }
    }
}
