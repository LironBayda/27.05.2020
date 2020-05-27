using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2_q1
{
    class Program
    {
        const int MAX_ARR_SIZE = 10;
        const int ELEMENT_VALUE = 10;
       static Random gen = new Random();
        private static int Measure(int[] a, int[] b)
        {
            int weight = FindWeight(a,b);

            return WeightTOZeroOrPlusMinusOne(weight);


        }

        private static int WeightTOZeroOrPlusMinusOne(int weight)
        {
            if (weight!=0)
                return weight/Math.Abs(weight);

            return weight;
        }

        /// <summary>
        /// calculate the weight of the arrays. start with weight equal to zero and increase/decrease 
        /// the weight according the elements
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int FindWeight( int[] a, int[] b)
        {
            int weight = 0;
            for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
            {
                if (a[i] > b[i])
                    weight++;
                else if (a[i] < b[i])
                    weight--;

            }
            return weight;
        }

        static void Main(string[] args)
        {
            //get random size for arrays
             int sizeA = GetRandomSize();
             int sizeB = GetRandomSize();

            //create arrays
            int[] a= new int [sizeA];
            int[] b = new int[sizeB];

            //fill the arrays with random numbers
            FillWithRandomNumbers(a);
            FillWithRandomNumbers(b);

            //get arrays weight
            int weight = Measure(a, b);

            //print arrays
            printArr(a);
            printArr(b);
            
            //print who weighted more
            printResult(a, b, weight);

        }

        private static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            
            }
            Console.WriteLine();

        }

        private static void printResult(int[] a, int[] b, int weight)
        {
            switch (weight)
            {
                case 0:
                    Console.WriteLine("a weight is equal to b weight ");
                    break;

                case 1:
                    Console.WriteLine($"a weight is bigger to b weight ");
                    break;

                case -1:
                    Console.WriteLine($"a weight is smaller to b weight ");
                    break;

            }

            Console.ReadLine();
        }

        private static void FillWithRandomNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = gen.Next(1, ELEMENT_VALUE + 1);
            
            }
        }

        private static   int GetRandomSize()
        {
            return gen.Next(1, MAX_ARR_SIZE);
        }
    }
}
