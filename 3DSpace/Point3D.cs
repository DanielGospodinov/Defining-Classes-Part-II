using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSpace
{
    struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public static Point3D O { get { return Point3D.o; } }
            
        public override string ToString()
            {
                return String.Format("X = {0:F3}\n" + "Y = {1:F3}\n" + "Z = {2:F3}\n",this.X,this.Y,this.Z);
            }
    }
}
