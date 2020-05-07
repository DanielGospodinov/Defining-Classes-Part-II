using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Matrix<T>
    {
        private T[,] matrixArr;

        public Matrix(int row,int col, params T[] elements)
        {
            if(row * col != elements.Length)
            {
                throw new ArgumentException("Negative matrix!");
            }

            int count = 0;
            this.matrixArr = new T[row, col];

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    matrixArr[x, y] = elements[count];
                    count++;
                }
            }
        }
        public T[,] MatrixArr
        {
            get { return this.matrixArr; }
            set { this.matrixArr = value; }
        }

        public T this[int row,int col]
        {
            get { return this.matrixArr[row, col]; }
            set { this.matrixArr[row, col] = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Matrix:");
            result.AppendLine();

            for (int i = 0; i < this.matrixArr.GetLength(0); i++)
            {
                for (int x = 0; x < this.matrixArr.GetLength(1); x++)
                {
                    result.AppendFormat("{0}| ", this.matrixArr[i, x]);
                }

                result.AppendLine();
            }
            return result.ToString();
        }
    }

}
