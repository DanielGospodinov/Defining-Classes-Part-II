using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSpace
{
    static class Distance
    {
        private static double distanceX;
        private static double distanceY;
        private static double distanceZ;

        public static void DistanceResult(Point3D A, Point3D B)
        {
            distanceX = A.X - B.X;
            distanceY = A.Y - B.Y;
            distanceZ = A.Z - B.Z;
        }

        public static void ShowDistance()
        {
            Console.WriteLine("distanceX : {0}", distanceX);
            Console.WriteLine("distanceY : {0}", distanceY);
            Console.WriteLine("distanceZ : {0}", distanceZ);
        }
    }
}
