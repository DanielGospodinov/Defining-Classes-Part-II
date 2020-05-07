using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSpace
{
    class Program
    {
        static void Main(string[] args)
        {

            Point3D startPoint = Point3D.O;
            Console.WriteLine(startPoint);
            Path listOfPoints = new Path();

            Point3D points = new Point3D();
            points.X = 4563.567;
            points.Y = 43.087;
            points.Z = -3.230;

            Console.WriteLine(points);

            Point3D points2 = new Point3D();
            points2.X = 547.221;
            points2.Y = 33.045;
            points2.Z = 43.208;

            Console.WriteLine(points2);

            listOfPoints.AddPoints(points, points2);

            Distance.DistanceResult(points, points2);
            Distance.ShowDistance();
           
            PathStorage.SavePath(listOfPoints);

            PathStorage.LoadFromFile();

            Console.WriteLine(PathStorage.LoadFromFile());
            //PathStorage.ClearFile();
        }
    }
}
