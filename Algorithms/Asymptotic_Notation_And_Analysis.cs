using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace Algorithms
{
    public class Asymptotic_Notation_And_Analysis
    {
        //Asymptotic notation is a way to describe the running time or space complexity of an algorithm based on the input size.It is commonly used in complexity analysis to describe how an algorithm performs as the size of the input grows. The three most commonly used notations are Big O, Omega, and Theta.
        //--input size gore algoritmanin time ve space complexitsin analis edib, daha performansli algoitma yazmaq...

        //1.	Big O notation(O) : This notation provides an upper bound on the growth rate of an algorithm’s running time or space usage.It represents the worst-case scenario. If an algorithm’s running time is O(n), then it means that the running time of the algorithm increases linearly with the input size n or less.
        //--worst case yeni upper bound olur. Inputa gore time ve ya space usage en ust limiti. Time ve ya space input(n) qeder ve ya azalimi qeder artar.

        //2.	Omega notation (Ω): This notation provides a lower bound on the growth rate of an algorithm’s running time or space usage. It represents the best-case scenario. If an algorithm’s running time is Ω(n), then it means that the running time of the algorithm increases linearly with the input size n or more.
        //--best case yeni lower bound olur. Inputa gore time ve ya space usage en asagi limiti. Time ve ya space input(n) qeder ve ya artimi qeder artar.

        //3.	Theta notation (Θ): This notation provides both an upper and lower bound on the growth rate of an algorithm’s running time or space usage. It represents the average-case scenario. If an algorithm’s running time is Θ(n), then it means that the running time of the algorithm increases linearly with the input size n.
        //--average case yeni upper ve lowwer arasi. Inputa gore time ve ya space usage orta limiti. Time ve ya space input(n) qeder artar.

        //Esasen Big(o) isledilir, cunki bad case budur. Asymptotic notation tam deqiq istifade oluna time ve space arasdirmi, input size gore olana baxir, hansi ki boyuk input size olanda performansli algoritma yazaq.

    }


    public class Asymptotic_Notations_And_How_To_Calculate_Them
    {
        //In mathematics, asymptotic analysis, also known as asymptotics, is a method of describing the limiting behavior of a function.In computing, asymptotic analysis of an algorithm refers to defining the mathematical boundation of its run-time performance based on the input size.

    }



    public class Worst_Average_And_Best_Case_Analysis_Of_Algorithms
    {
        //1. Worst Case Analysis: 
        //Most of the time, we do worst-case analyses to analyze algorithms.In the worst analysis, we guarantee an upper bound on the running time of an algorithm which is good information. 

        //2. Average Case Analysis
        //The average case analysis is not easy to do in most practical cases and it is rarely done. In the average case analysis, we must know (or predict) the mathematical distribution of all possible inputs. 

        //3. Best Case Analysis
        //The Best Case analysis is bogus.Guaranteeing a lower bound on an algorithm doesn’t provide any information as in the worst case, an algorithm may take years to run.



        //Linear search algorithm:
        // Linearly search x in arr[]. If x is present then
        // return the index, otherwise return -1
        static int search(int[] arr, int n, int x)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        /* Driver's code*/
        public static void Main()
        {
            int[] arr = { 1, 10, 30, 15 };
            int x = 30;
            int n = arr.Length;

            // Function call
            Console.WriteLine(x + " is present at index "
                            + search(arr, n, x));
            //OutPut: 30 is present at index 2
        }

        //Time Complexity Analysis: (In Big-O notation)

        //Best Case: O(1), This will take place if the element to be searched is on the first index of the given list.So, the number of comparisons, in this case, is 1.
        //Average Case: O(n), This will take place if the element to be searched is on the middle index of the given list.
        //Worst Case: O(n), This will take place if:
        //The element to be searched is on the last index
        //The element to be searched is not present on the list
    }

}
