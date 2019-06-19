using System;
using System.Collections.Generic;
using System.Text;

namespace lab12_3Dshapes
{
    class Cone:Cylinder
    {
        public override double Volume
        {
            get
            {
                double volume = Math.PI * Math.Pow(Length, 2) * (Height / 3);
                return volume;
            }
        }

        public Cone(double length, double height): base(length, height)
        {
        }

        public override string GetMass(double density)
        {
            double mass = density * Volume;


            string result = $"For the Cone Density is :{mass.ToString()} and the Volume is {Volume.ToString()}";
            return result;
        }
    }
}
