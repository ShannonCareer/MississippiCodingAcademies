using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfThenStatement
{
    class Program
    {

        static void Main(string[] args)
        { /* 
            
            There's no prompt informing user to enter Roman numberals
            
             */
            //DECLARE VARIABLES
            string usernum = "";
            string rom1 = "";
            string rom2 = "";
            string rom3 = "";
            string rom4 = "";
            string rom5 = "";
            string rom6 = "";
            string rom7 = "";
            string rom8 = "";
            string rom9 = "";
            string rom10 = "";

            //USER INPUT
            Console.Write("Please enter your number: ");
            usernum = Convert.ToString(Console.ReadLine());
            rom1 = "I";
            rom2 = "II";
            rom3 = "III";
            rom4 = "IV";
            rom5 = "V";
            rom6 = "VI";
            rom7 = "VII";
            rom8 = "VIII";
            rom9 = "XI";
            rom10 = "X";

            //CONSOLE OUTPUT 
            if (usernum == rom1)
            {//then
                Console.WriteLine("The converted # is: " + rom1);
            }
            else
            {
                Console.WriteLine("Input Invalid ");
            }//end if

            if (usernum == rom2)
            {//then
                Console.WriteLine("The converted # is: " + rom2);
            }
            else
            {

                if (usernum == rom3)
                {//then
                    Console.WriteLine("The converted # is: " + rom3);
                }
                else
                {
                    Console.WriteLine("Input Invalid ");
                }//end if

                if (usernum == rom4)
                {//then
                    Console.WriteLine("The converted # is: " + rom4);
                }
                else
                {
                    Console.WriteLine("Input Invalid ");
                }//end if
                if (usernum == rom5)
                {//then
                    Console.WriteLine("The converted # is: " + rom5);
                }
                else
                {
                    Console.WriteLine("Input Invalid ");
                }//end if

                if (usernum == rom6)
                {//then
                    Console.WriteLine("The converted # is: " + rom6);
                }
                else
                {
                    Console.WriteLine("Input Invalid ");
                }//end if

                if (usernum == rom7)
                {//then
                    Console.WriteLine("The converted # is: " + rom7);
                }
                else
                {
                    Console.WriteLine("Input Invalid ");
                }//end if

                if (usernum == rom8)
                {//then
                    Console.WriteLine("The converted # is: " + rom8);
                }
                else
                {
                    Console.WriteLine("Input Invalid ");
                }//end if

                if (usernum == rom9)
                {//then
                    Console.WriteLine("The converted # is: " + rom9);
                }
                else
                {
                    Console.WriteLine("Input Invalid ");
                }//end if

                if (usernum == rom10)
                {//then
                    Console.WriteLine("The converted # is: " + rom10);
                }
                else
                {
                    Console.WriteLine("Input Invalid ");

                    
                }//end if
                Console.ReadKey();
            }
        }
    }
}
