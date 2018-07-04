using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seatingarray
{
    class Program
    {
        static int[][] a;
        static int[][] m;
        static int[][] w;
        static Dictionary<IntPtr, int> arrangement = new Dictionary<IntPtr,int>();
        static int count = 1;
       
        static void Main(string[] args)
        {
            exaample e= new exaample();
            e.method();


        }

        static void aisle(int[,] a, int m, int n, bool first = false, bool last = false)
        {
            if (first)
            {
                arrangement.Add((IntPtr)a[m,n - 1], count++);
            }

            else if (last)
            {
                arrangement.Add((IntPtr)a[m,0], count++);
            }
            else
            {
                arrangement.Add((IntPtr)a[m,0], count++);
                arrangement.Add((IntPtr)a[m,n - 1], count++);
            }
        }


        static void window(int[,] a, int m, int n, bool first = false, bool last = false)
        {
            if (first)
            {
                arrangement.Add((IntPtr)a[m,0], count++);
            }

            else if (last)
            {
                arrangement.Add((IntPtr)a[0,n-1], count++);
            }
        }

        static void middle(int[,] a, int m, int n, bool first = false, bool last = false)
        {
            for (int i = 1; i < n; i++)
            {
                arrangement.Add((IntPtr)a[m,i], count++);
            }
        }


        static void method()
        {
            int row1 = 2;
            int col1 = 3;

            int row2 = 3;
            int col2 = 4;

            int row3 = 3;
            int col3 = 2;

            int row4 = 4;
            int col4 = 3;

            int[,] array1 = new int[2, 3];
            int[,] array2 = new int[3, 4];
            int[,] array3 = new int[3, 2];
            int[,] array4 = new int[4, 3];

            for (int i = 0; i < array4.Length; i++)
            {
                if (i <= array1.Length)
                    aisle(array1, i, 3, true, false);
                if (i <= array2.Length)
                    aisle(array2, i, 4);
                if (i <= array3.Length)
                    aisle(array3, i, 2);
                if (i <= array4.Length)
                    aisle(array4, i, 3, false, true);
            }
            for (int i = 0; i < array4.Length; i++)
            {
                if (i <= array1.Length)
                    window(array1, i, 3, true, false);

                if (i <= array4.Length)
                    window(array4, i, 3, false, true);
            }
            for (int i = 0; i < array4.Length; i++)
            {
                if (i <= array1.Length)
                    middle(array1, i, 3, true, false);
                if (i <= array2.Length)
                    middle(array2, i, 4);
                if (i <= array3.Length)
                    middle(array3, i, 2);
                if (i <= array4.Length)
                    middle(array4, i, 3, false, true);
            }
        }
    }
}
