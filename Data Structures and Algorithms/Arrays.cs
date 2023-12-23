using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms
{
    internal class Arrays
    {
        //salam =>malas

        public string ReverseArray(string input)
        {
            //var data = input[input.Length];

            char[] newString = new char[input.Length];

            for (int i = input.Length - 1; i >= 0; i--)
            {
                newString[input.Length - 1 - i] = input[i];
            }

            return newString.ToString();
        }

        //3 2 1 56 1000 167

        public int[] MinMaxOfArray(int[] ayyar)
        {
            int[] respons = new int[2];
            respons[0] = ayyar[0];
            respons[1] = ayyar[0];

            for (int i = 0; i < ayyar.Length; i++)
            {
                int myNumber = ayyar[i];


                if (respons[0] > ayyar[i])
                {
                    respons[0] = myNumber;
                }

                if(respons[1] < ayyar[i])
                {
                    respons[1] = myNumber;
                }
            }

            return respons;
        }

        public int PeekArray(int[] array, int x)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == x)
                {
                    index = i;
                    break;
                }

            }

            return index;
            
        }

        public int[] Sort(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        public int[] Sort2(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > array[i+1])
                {
                    int temp = array[i];
                    array[i] = array[i+1];
                    array[i+1] = temp;
                }
            }

            return array;
        }

        public int KthElement(int[] array, int k)
        {
            int myindex = array[0];

            if (array.Length>k)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == k)
                    {
                        myindex = array[i];
                    }
                }

                for (int i = 0; i < myindex; i++)
                {
                    k = k * k;

                }
            }
            

            return k;
        }

        public void Rota(int[] array)
        {
            Console.WriteLine(array[array.Length-1]);

            for (int i = 0; i < array.Length-2; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
