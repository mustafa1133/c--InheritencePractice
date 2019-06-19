using System;
using System.Collections.Generic;
using System.Text;

namespace lab12_3Dshapes
{
    class Cylinder: Sphere
    {
        public double Height { get; private set; }
        public override double  Volume
        {
            get
            {
                double volume = Math.PI * Math.Pow(Length, 2) * Height;
                return volume;
            }
        }


        public Cylinder(double length, double height) : base(length)
        {
            Height = height;
        }


        public override string GetMass(double density)
        {
            double mass = density * Volume;


            string result = $"For the Cylinder Density is :{mass.ToString()} and the Volume is {Volume.ToString()}";
            return result;
        }
    }
}
