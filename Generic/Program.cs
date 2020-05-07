using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                GenericList<int> list = new GenericList<int>();

                list.Add(5);
                list.Add(6);
                list.Add(2);
                list.Add(8);
                list.Add(9);

                Console.WriteLine("After Adding:");
                Console.WriteLine(list.ToString());

                Console.WriteLine("\n Showing element:");
                list.Show(2);

                Console.WriteLine("\n After Removing:");
                list.RemoveAt(3);
                Console.WriteLine(list.ToString());

                Console.WriteLine("\nAfter Inserting:");
                list.Insert(66, 2);
                Console.WriteLine(list.ToString());

                Console.WriteLine();
                list.Min();
                list.Max();
                Console.WriteLine();

                ///////////////////////////////////////

                GenericList<string> listString = new GenericList<string>();
                listString.Add("Pipi");
                listString.Add("Mimi");
                listString.Add("Kiki");
                listString.Add("Riki");

                Console.WriteLine("After Adding:");
                Console.WriteLine(listString);

                Console.WriteLine();
                listString.Min();
                listString.Max();

                Console.WriteLine("\n Show element:");
                listString.Show(1);

                Console.WriteLine("\n AfterRemoving");
                listString.RemoveAt(3);
                Console.WriteLine(listString);

                listString.Insert("Hihi", 10);
                Console.WriteLine(listString);

            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End GenericList!");
            }

            try
            {
                Matrix<object> matrix = new Matrix<object>(2, 2, 100, "five", 5.2, 7.2);
                Console.WriteLine();
                Console.WriteLine(matrix);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End Matrix");
            }
        }
    }
}
