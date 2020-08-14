namespace QuantityMeasurementProblem
{
    using System;

    public class Feet
    {

        public double GetFeet(double feet)
        {
            return feet;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
