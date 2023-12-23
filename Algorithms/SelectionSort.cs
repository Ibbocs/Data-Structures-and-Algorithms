using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SelectionSort
    {
        //1 9 8 3 4 0
        public int[] SelectionSortForNumber(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
         
                //j=i+1 cunki array getdikce balacalasir ve gereksiz donmesin deye yaziriq bunu
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                    //currentIndex++;
                }

                //swap
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
                //tem'i array[minIndex] kimi goturub terse swap da elemek olar
            }

            return array;
        }

        public string[] SelectionSortForString(string text)
        {
            string[] array = text.Split(',', ' ', '-', '.');
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    //bu reqemler girilende xeta vere biler
                    //if (int.Parse(array[j]) < int.Parse(array[minIndex]))
                    //{
                    //    minIndex = j;
                    //}

                    if (string.Compare(array[j], array[minIndex], StringComparison.Ordinal) < 0)
                    {
                        minIndex = j;
                    }
                }

                //swap
                string temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
                //tem'i array[minIndex] kimi goturub terse swap da elemek olar
            }

            return array;
        }

        public char[] SelectionSortForChar(string text)
        {
            // Giriş metnini char dizisine çevirme
            //istesen string array eleyib splitleyib(, . - ), sora char cevirersen dongu ile
            char[] array = text.ToCharArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    // Elemanları ASCII değerlerine göre karşılaştırma, küçükten büyüğe sıralama
                    if ((int)array[j] < (int)array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap işlemi
                char temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }

            return array;
        }
    }
}
