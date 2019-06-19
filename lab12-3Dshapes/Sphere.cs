using System;
using System.Collections.Generic;
using System.Text;

namespace lab12_3Dshapes
{
    class Sphere
    {
        public double Length { get; private set; }

        public virtual double Volume
        {
            get
            {
                double volume= (4 *(Math.PI) * Math.Pow(Length,3)) /3;
                return volume;
            }

        }


        public Sphere(double length)
        {
            Length = length;
        }


        public virtual string GetMass(double density)
        {
            double mass = density * Volume;


            string result = $"For the Sphere Density is :{mass.ToString()} and the Volume is {Volume.ToString()}";
            return result;
        }
    }
}
