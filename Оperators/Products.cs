using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оperators
{
    class Products
    {
        public Products(double bread, double milk, double meal)
        {
            this.Bread = bread;
            this.Milk = milk;
            this.Meal = meal;
        }
        public double Bread
        { get; set; }

        public double Milk
        { get; set; }
        public double Meal
        { get; set; }

        public static Products operator +(Products p1, Products p2)
        {
            double totalBread = p1.Bread + p2.Bread;
            double totalMilk = p1.Milk + p2.Milk;
            double totalMeal = p1.Meal + p2.Meal;

            return new Products(totalBread, totalMilk, totalMeal);
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Bread = {0:F}lv\nMilk = {1:F}lv\nMeal = {2:F}lv", this.Bread, this.Milk, this.Meal);
            
            return result.ToString();
        }
    }
}
