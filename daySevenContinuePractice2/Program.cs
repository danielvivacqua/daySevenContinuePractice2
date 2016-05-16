using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daySevenContinuePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an even number");//asks user for even number
            int firstNumber = int.Parse(Console.ReadLine());//get input from user and parsed it to int
            
            while (firstNumber % 2 != 0)
                {
                    Console.WriteLine("You did not follow directions. Please enter an even number: ");
                    firstNumber = int.Parse(Console.ReadLine());// ask again for even number, parse
                }
                
            Console.WriteLine("How high should I count?"); // prompts for count limit
            int countLimit = int.Parse(Console.ReadLine()); // gets high number to count to
            int sum = 0; //initialize sum to zero OR ELSE!!!

            for (int counter = firstNumber; counter <= countLimit; counter += 2)
              {
                 if (counter % 6 == 0)
                    {
                        continue;// loops back up to beginninig
                    }
                 sum += counter;
              }
             Console.WriteLine("sum = " + sum);
            }
        }
    }

