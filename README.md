# 27.05.2020

part 1

 //1.
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Power2(ref x);
            Console.WriteLine($"power 2 of your number is {x}");
            Console.ReadLine();
        }
        private static void Power2(ref int  i)
        {
            i = i * 2;
        }*/
        //2. yes- because array pass to function like ref 
        //3. no because we create new array and it "known" only in the function where it was created
        //4.
        /*static void Main(string[] args)
        {
            int[] a, b;
            InitializeArrays(out a,out b);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadLine();
        }
        private static void InitializeArrays(out int[] a,out int[] b)
        {
            Random r = new Random();
            a = new int[10];
            b = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(101);
                b[i] = r.Next(101);
            }
        }*/

        //5.we use params when we want to pass several element to function without creating array
        
        6.
        namespace Simon
{
 public partial class Form1 : Form
 {
        int[] a;
        private void PrintArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        private void InitializeArrays()
        {
            Random r = new Random();
            a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(101);
            }
        }
 }
}

