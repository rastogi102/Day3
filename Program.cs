using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay3
{
    internal class Program
    {
        enum Monthsofyear { Jan=1,Feb=2,Mar=3};
        static void Main(string[] args)
        {

            Console.WriteLine("First Month: \t" + (int)Monthsofyear.Jan);
            Console.WriteLine("Second Month: \t"+Monthsofyear.Feb);
            Console.ReadKey();
            //Datatypes

            //byte myByte=12;
            //sbyte mySbyte=1;
            //short mySShort=12;
            //int myInt = 12;
            //long myLong = 12;
            //double myDouble = 12.5;
            //float myFloat = 12.5F;
            //decimal myDecimal = 12;
            //char myChar = 'A';
            //string myString = "our String";
            //DateTime myDateTime = new DateTime(day:12,month:12,year:2022);
            //bool myBool = false;
            //try
            //{
            //    byte ourByte;
            //    Console.WriteLine("Enter a number");
            //    ourByte = Convert.ToByte(Console.ReadLine());
            //    Console.WriteLine("Number is" + ourByte);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("Format Exception"+ex.Message);

            //}
            //catch (OverflowException ex) 
            //{
            //    Console.WriteLine("Overflow Exception" + ex.Message);

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error!!!"+ex.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("End of Program!!!");
            //    Console.ReadKey();
            //}

        }
    }
}
