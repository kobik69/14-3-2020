using System;

namespace _14_3_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            Point3D p3 = new Point3D(1, 3, 55);
            p3.ToString();
            Console.WriteLine(p3.x); 
            Console.WriteLine(p3.y); 
            Console.WriteLine(p3.z);
          

            Console.ReadKey();

        }
         public class Point
        {
            public int x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public class Point3D : Point
        {
            public int z;
            public Point3D(int x, int y, int z) : base(x, y)
            {
                this.z = z;
            }
        }

    }


}

