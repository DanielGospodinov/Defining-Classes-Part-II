using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3DSpace
{
    static class PathStorage
    {
        public static void SavePath(Path point)
        {
            string path = "../../PointsStorage.txt";

            StreamWriter writer = new StreamWriter(path);

            using (writer)
            {
              
                writer.Write(point);

            }
        }

        public static void ClearFile()
        {
            string filePath = "../../PointsStorage.txt";
            File.WriteAllText(filePath, "");
        }

        public static Path LoadFromFile()
        {
            string filePath = "../../PointsStorage.txt";

            Path path = new Path();

            StreamReader reader = new StreamReader(filePath);

            using (reader)
            {
                string[] onePointStr = reader.ReadToEnd().Split(new string[] { " ->" }, StringSplitOptions.None);
                double[] CoordinatePoints = new double[3];

                for (int i = 0; i < onePointStr.Length; i++)
                {
                    List<string> coordiantes = new List<string>();
                    coordiantes.AddRange(onePointStr[i].Split('\n'));
                    coordiantes.Remove("");
                    coordiantes.Remove(" ");

                    for (int x = 0; x < 3; x++)
                    {
                        CoordinatePoints[x] = double.Parse(String.Format(coordiantes[x].Substring(coordiantes[x].IndexOf('=')+1)));
                        
                    }
                    path.AddPoint(new Point3D(CoordinatePoints[0], CoordinatePoints[1], CoordinatePoints[2]));
 
                }
                           
            }

            return path;
        }

    }
}
