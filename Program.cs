using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDeneme
{
    
    public class Program
    {
        public static void Main()
        {
            int[] arr = { 5, 4, 3, 2, 1 }; // Initialize an array of integers

            QuickSort(arr, 0, arr.Length - 1); // Sort the array using QuickSort algorithm

            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " "); // Print the sorted array
            }
            Console.ReadKey();
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right); // Get the pivot index

                QuickSort(arr, left, pivotIndex - 1); // Recursively sort the left partition
                QuickSort(arr, pivotIndex + 1, right); // Recursively sort the right partition
            }
        }

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right]; // Choose the rightmost element as the pivot
            int i = left - 1; // Initialize the left index

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j); // Swap the elements at i and j
                }
            }

            Swap(arr, i + 1, right); // Swap the pivot element with the element at i+1
            return i + 1; // Return the index of the pivot element
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

}
