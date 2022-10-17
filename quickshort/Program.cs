using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuickSort
{
    class program
    {
        private int[] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;

        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of element in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20) 
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 element\n");
            }
            Console.WriteLine("\n===============");
            Console.WriteLine("enter array elements");
            Console.WriteLine("\n===============");

            for(int i =0;i<arr.Length;i++)
            {
                Console.Write("<"+(i+1)+">");
                string s1 = Console.ReadLine();
                arr[i]=Int32.Parse(s1);
            }
        }
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low,int high)
        {
            int pivot,i,j;
            if(low>high)
                return;

            i = low + 1;
            j = high;

            pivot = arr[low];
            while(i<=j)
            {
                while ((arr[i]<= pivot) && (i<= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;
                if(1 < j)
                {
                    swap(i,j);
                }
            }
        }
    }
}