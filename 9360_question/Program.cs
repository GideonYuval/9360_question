using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9360
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = Arr2Q(new int[] { 5, 11, 6, 9, 3, 6, 3 });
            Console.WriteLine(q);
            Console.WriteLine(IsMagic(q, 1)); //F
            Console.WriteLine(IsMagic(q, 2)); //T
            Console.WriteLine(IsMagic(q, 3)); //F
            Console.WriteLine(IsMagic(q, 7)); //F
            Console.WriteLine(q);
            Console.WriteLine(NMagic(q, 2)); //T
        }

        static Queue<int> Arr2Q(int[] arr)
        {
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < arr.Length; i++)
                q.Insert(arr[i]);
            return q;
        }

        static bool NMagic(Queue<int> q, int n) //part 2
        {
            return false;
        }


        static bool IsMagic(Queue<int> q, int m) //part 1
        {
            return false;
        }
    }
}
