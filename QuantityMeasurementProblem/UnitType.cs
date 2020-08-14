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

        public double value;

        public UnitType(double value)
        {
            this.value = value;
        }
    }
}
