using System;
using System.Collections.Generic;
using System.Text;

namespace lab12_3Dshapes
{
    class Cube:Sphere
    {

        public override double Volume
        {
            get
            {
                double volume = Math.Pow(Length, 3);
                return volume;
            }
        }

        public Cube (double length):base(length)
        {
        }

        public override string GetMass(double density)
        {
            double mass = density * Volume;


            string result = $"For the Cube Density is :{mass.ToString()} and the Volume is {Volume.ToString()}";
            return result;
        }
    }
}
