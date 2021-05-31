using System;
using System.Collections.Generic;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                int[] myArray = new int[20];
                myArray[0] = 1;
                myArray[1] = 2;
                myArray[2] = 3;
                myArray[3] = 4;
                myArray[4] = 5;
                myArray[5] = 6;
                myArray[6] = 7;
                myArray[7] = 8;
                myArray[8] = 9;
                myArray[9] = 10;
                myArray[10] = 11;
                myArray[11] = 12;
                myArray[12] = 13;
                myArray[13] = 14;
                myArray[14] = 15;
                myArray[15] = 16;
                myArray[16] = 17;
                myArray[17] = 18;
                myArray[18] = 19;
                myArray[19] = 20;

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);
                }

                List<string> mylista = new List<string>();
                mylista.Add("1");
                mylista.Add("2");
                mylista.Add("3");
                mylista.Add("4");
                mylista.Add("5");
                mylista.Add("6");
                mylista.Add("7");
                mylista.Add("8");
                mylista.Add("9");
                mylista.Add("10");
                mylista.Add("11");
                mylista.Add("12");
                mylista.Add("13");
                mylista.Add("14");
                mylista.Add("15");
                mylista.Add("16");
                mylista.Add("17");
                mylista.Add("18");
                mylista.Add("19");
                mylista.Add("20");
                foreach (var item in mylista)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }

}

