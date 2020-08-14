// <copyright file="UnitType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    public class UnitType
    {
        public static readonly UnitType Feet = new UnitType(12);

        public static readonly UnitType Inch = new UnitType(1);

        public static readonly UnitType Yard = new UnitType(36);

        public int value;

        public UnitType(int value)
        {
            this.value = value;
        }
    }
}
