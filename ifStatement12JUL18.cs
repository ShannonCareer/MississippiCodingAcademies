using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement20180712 {
    class Program  {
        static void Main(string[] args)  {
            //DECLARE VARIABLES
            double test1 = 0.0;
            double test2 = 0.0;
            double test3 = 0.0;
            double avg = 0.0;
     
            //USER INPUT
            Console.WriteLine("Please enter test 1 score: ");
            test1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter test 2 score: ");
            test2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter test 3 score: ");
            test3 = Convert.ToDouble(Console.ReadLine());

            avg = (test1 + test2 + test3) / 3;

            //IF STATEMENTS
            if (avg >= 60) {//then
                Console.WriteLine("You passed. ");
            }else{
                Console.WriteLine("You failed. ");
            }//end if

            Convert.To

            Console.ReadKey();
        }
    }
}
