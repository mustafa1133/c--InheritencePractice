using System;
using System.Collections.Generic;

namespace lab12_3Dshapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sphere x = new Sphere(7);
            // Console.WriteLine(x.Volume); // used to test the Sphere class

            // Cylinder x = new Cylinder(7,2);
            //Console.WriteLine(x.Volume); // used to test the Cylinder Class

            // Cube x = new Cube(2);
            // Console.WriteLine(x.Volume);// Used to test Cube Class

            //Cone x = new Cone(2, 3);
            //Console.WriteLine(x.Volume);// used to tezt Cone Class


            List<Sphere> shapes = new List<Sphere>();
            shapes.Add(new Sphere(7));
            shapes.Add(new Cylinder(7, 2));
            shapes.Add(new Cube(2));
            shapes.Add(new Cone(2, 3));


            foreach (Sphere sphere in shapes)
            {
                Console.WriteLine(sphere.GetMass(2));
            }
        }
    }
}
