using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many numbers would be there in the array");
            int ln = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[ln];
            Console.WriteLine("Please start giving input after this line");

            int mx=0, mn=0;

            for (int i = 0; i<ln; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                arr[i] = n;
                if (i == 0)
                {
                    mx = n;
                    mn = n;
                }
                if (mx < n)
                {
                    mx = n;
                }
                if (mn > n)
                {
                    mn = n;
                }
            }

            Console.WriteLine("Max number in the array is "+mx);
            Console.WriteLine("Min number in the array is "+mn);

            Console.WriteLine("Do you want to sort this array too, Enter 1 for yes and any number for no");
            int c = Convert.ToInt32(Console.ReadLine());

            if(c != 1)
            {
                return;
            }
            int temp;
            
            for(int i = 0; i < ln; i++)
            {
                for(int j = i; j < ln; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array is ");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
