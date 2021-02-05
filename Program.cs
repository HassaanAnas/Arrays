using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");

            // decalring array size
            const int SIZE = 25;

            // introducing int element value 
            int[] ElementValue = new int[SIZE];

            // for loop for iteration until the condition is  met
            for(int i = 0 ; i < ElementValue.Length; i++)
            {
                ElementValue[i] = i+1;
            }

            // for loop for printing the iterations 
            for (int i = 0; i < ElementValue.Length; i++)
            {
                Console.WriteLine("Element Value = " + ElementValue[i]);
            }


        }
    }
}
