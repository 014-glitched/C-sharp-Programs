using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // SUM OF ALL ELEMENTS OF ARRAY

            {
                int sum = 0;
                int[] arr = { 1, 2, 3, 4, 5 };
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine(sum);
                Console.ReadLine();
            }



            // AVERAGE OF ALL ELEMENTS OF ARRAY

            {
                int sum = 0;
                int[] arr = { 1, 2, 3, 4 };
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                double avg = (sum * 1.0) / arr.Length;
                Console.WriteLine(avg);
                Console.ReadLine();
            }


            // LARGEST ELEMENT IN ARRAY


            {
                int[] arr = { 5, 8, 44, 67, 12, 90 };
                int max = arr[0];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                Console.WriteLine(max);
                Console.ReadLine();
            }



            //  NUMBER OF EVEN AND ODD IN ARRAY

            {
                int[] arr = { 5, 8, 44, 67, 12, 90 };
                int max = arr[0];
                int even = 0, odd = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if ((arr[i] & 1) == 1)
                    {
                        odd++;
                    }
                    else { even++; }
                }
                Console.WriteLine("Number of odd numbers = " + odd + " and even numbers = " + even);
                Console.ReadLine();
            }


            // REVERSE OF AN ARRAY

            {
                int[] arr = { 5, 8, 44, 67, 12, 90 };
                int l = 0, r = arr.Length - 1;
                while (l < r)
                {
                    int temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                    l++;
                    r--;
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                    Console.ReadLine();
                }

            }

            // MULTIPLY ARRAY BY A SPECIFIC FACTOR


            {
                int[] arr = { 5, 8, 44, 67, 12, 90 };
                int mult = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i] * mult;
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                    Console.ReadLine();
                }
            }


            // SEARCHING A SPECIFIC VALUE


            {
                int[] arr = { 5, 8, 44, 67, 12, 90 };
                int search = Convert.ToInt32(Console.ReadLine());
                int index = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == search)
                    {
                        index = i; break;
                    }

                }
                Console.WriteLine(index);
                Console.ReadLine();
            }



            // SECOND SMALLEST ELEMENT IN ARRAY

            {
                int[] arr = { 5, 8, 44, 67, 12, 7 };
                int min = arr[0], min1 = arr[arr.Length - 1];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                Console.WriteLine(min);
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] != min)
                    {
                        if (arr[j] < min1)
                        {
                            min1 = arr[j];
                        }
                    }
                }
                Console.WriteLine(min1);
                Console.ReadLine();
            }
        }


            //REMOVE DUPLICATES FROM ARRAY
            static void removedup(int[] arr)
            {
                int[] un = arr.Distinct().ToArray();
                foreach (int num in un)
                {
                    Console.WriteLine(num);
                }
                removedup(arr);
                Console.ReadLine();
            }


        // INTERSECTION OF TWO ARRAYS
        static void CommonInBoth(int[] arr)
        {
            int[] second = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (second[j] == arr[i])
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
            }
            CommonInBoth(arr);
            Console.ReadLine();
        }
    }

}
    

