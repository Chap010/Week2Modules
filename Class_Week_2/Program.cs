using System;
using System.Linq;

namespace Class_Week_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hey Boss Please Enter Your Name So We Can Proceed: ");
            string bossName = Console.ReadLine();
            DateTime covid19Start = new DateTime(2019, 12, 31);
            DateTime covid19Ending = DateTime.Now;
            int pandemicDays = DateTime.Compare(covid19Start, covid19Ending);
            Console.WriteLine("Comparing covid dates from start to present and the value is " + pandemicDays);
            Console.WriteLine("Hey " + bossName + " the pandemic started on " + covid19Start + " and todays date is " + covid19Ending.ToString("MMMM/f/yyyy") + " and the pandemic still active. ");



            DateTime fecha1 = new DateTime(1954, 01, 01);
            DateTime fecha2 = new DateTime(1998, 01, 01);

            if (fecha1 >= fecha2)

            {
                Console.WriteLine("01/01/1998 is not the greater date!");
            }


            else if (fecha1 <= fecha2)
            {
                Console.WriteLine("01/01/1998 is the greater date!");
            }


            int fechasFormula = 1998 - 1954;
            Console.WriteLine("The Difference Between The Two Dates Is " + fechasFormula + " Years.");
            // _ = Console.ReadLine();//



            ///////////////////  Second Dates ////////////////////////////

            DateTime fecha3 = new DateTime(1998, 01, 01);
            DateTime fecha4 = new DateTime(2010, 05, 10);

            if (fecha3 >= fecha4)

            {
                Console.WriteLine("01/01/1998 is not the greater date!");
            }


            else if (fecha3 <= fecha4)
            {
                Console.WriteLine("05/10/2010 is the greater date!");
            }


            int fechasFormula2 = 2010 - 1998;
            Console.WriteLine("The Difference Between Yhe Two Dates Is " + fechasFormula2 + " Years.");



            //////////////   Looping /////////////

            int num = 1;
            while (num <= 250)

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(num);
                
                num++;
            }

            
            int[] num2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 15, 16, 17, 18, 19, 20 };
            int endingNum = 250;
            for (int suma = 1; suma == endingNum; suma++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Number = " + num2[suma]);
            }
            


        }

    }      

}









