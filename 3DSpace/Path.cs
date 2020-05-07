using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSpace
{
    class Path
    {
        private List<Point3D> points;

        public Path()
        {
            points = new List<Point3D>();
        }
        //Properties
        public int Count
        {
            get { return this.points.Count; }
        }

        public Point3D this[int index]
        {
            get { return this.points[index]; }
            set { this.points[index] = value; }
        }

        //Methods

        public void AddPoint(Point3D point)
        {
            points.Add(point);
        }

        public void AddPoints(params Point3D[] point)
        {
            this.points.AddRange(point);
        }

        public override string ToString()
        {
            return string.Join(" -> \n", this.points);
        }
    }
}
