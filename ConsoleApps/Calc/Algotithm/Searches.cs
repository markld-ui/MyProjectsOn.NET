using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationAlgorithm
{
    class MyAlgorithms
    {
        /// <summary>
        /// Speed of work is O(N)
        /// For an unordered array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        static int SearchSimple(int[] a, int x)
        {
            int L = a.Length;
            int i = 0;
            // с проверкой выхода за границу массива
            while (i < L && a[i] != x)
                i++;
            // если элемент найден, возвращаем его индекс
            if (i < L)
                return i;
            // если элемент не найден, возвращаем -1 
            else
                return -1;
        }

        /// <summary>
        /// Speed of work is O(N)
        /// For an unordered array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        static int SerachWithBarrier(int[] a, int x)
        {
            int L = a.Length;
            Array.Resize(ref a, ++L);
            a[L - 1] = x;
            int i = 0;

            // с проверкой выхода за границу массива
            while (a[i] != x)
                i++;
            if (i < L-1)
                return i;
            else
                return -1;
        }
        /// <summary>
        /// Speed of work is O(log2(N))
        /// For an ordered array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        static int SearchBinary(int[] a, int x)
        {
            int m, left = 0;
            int right = a.Length - 1;

            do
            {
                m = (left + right) / 2;
                if (x > a[m])
                {
                    left = m + 1;
                }
                else
                {
                    right = m - 1;
                }
            }
            while ((a[m] != x) && (left <= right));
            if (a[m] == x)
                return m;
            else
                return -1;
        }

        /// <summary>
        /// Speed of work is O(N^2)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public void SortSelection(int[] a)
        {
            int N = a.Length;
            int min = 0, imin = 0, i;
            for (i = 0; i < N - 1; i++)
            {
                min = a[i]; imin = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j]; imin = j;
                    }
                }
                if (i != imin)
                {
                    a[imin] = a[i];
                    a[i] = min;
                }
            }
        }

        /// <summary>
        /// Speed of work is O(N^2)
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public void SortInsertion(int[] a)
        {
            int tmp;
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                tmp = a[i];
                int j = i - 1;

                while (j >= 0 && tmp < a[j])
                    a[j + 1] = a[j--];

                a[j + 1] = tmp;
            }
        }

        /// <summary>
        /// Speed of work is O(N^2)
        /// </summary>
        /// <param name="a"></param>
        public void SortBinaryInsertion(int[] a)
        {
            int N = a.Length;
            for (int i = 0; i <= N; i++)
            {
                int tmp = a[i], left = 1, right = i - 1;
                while(left <= right)
                {
                    int m = (left + right) / 2;
                    if (tmp < a[m])
                        right = m - 1;
                    else
                        left = m + 1;
                }
                for (int j = i-1; j > left; j--)
                {
                    a[j + 1] = a[j];
                }
                a[left] = tmp;
            }
        }


        /// <summary>
        /// Speed of work is O(N^2)
        /// </summary>
        /// <param name="a"></param>
        public void SortBubl(int[] a)
        {
            int N = a.Length;

            for (int i = 1; i < N; i++)
            {
                for (int j = N - 1; j >= i; j--)
                {
                    if (a[j-1] > a[j])
                    {
                        int t = a[j-1];
                        a[j - 1] = a[j];
                        a[j] = t;
                    }
                }
            }
        }


        /// <summary>
        /// Speed of work is O(N^2)
        /// </summary>
        /// <param name="a"></param>
        public void SortShaker(int[] a)
        {
            int left = 1, right = a.Length - 1, last = right;
            do
            {
                for (int j = right; j >= left; j--)
                {
                    if (a[j - 1] > a[j])
                    {
                        int t = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = t;
                        last = j;
                    }
                }
                right = last - 1;
            }
            while (left < right);
        }

        /// <summary>
        /// Speed of work is O(N)
        /// stepk = stepk-1*3/5
        /// </summary>
        /// <param name="a"></param>
        public void SortShell(int[] a)
        {
            int N = a.Length;
            int step = N / 2; //The first step
            while (step > 1)
            {
                int k = step;
                for (int i = k + 1; i < N; i++)
                {
                    int tmp = a[i]; int j = i - k;
                    while ((j > 0) && (tmp < a[j]))
                    {
                        a[j + k] = a[j];
                        j = j - k;
                    }
                    a[j + k] = tmp;
                }
                step = 3 * step / 5;
            }

        }


    }
}
