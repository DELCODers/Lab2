using System;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {



                bool keepGoing = true;
                while (keepGoing == true) 
                {
                Console.WriteLine("Would you like to make another calculation?");
                string anotherCalculation = Console.ReadLine();
                if (anotherCalculation == ("yes"))
                    Console.WriteLine("Please input the length of the room");
                    double length = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please input the width of the room");
                    double width = double.Parse(Console.ReadLine());

                double area = width * length;
                double perimeter = 2 * (width + length);
                Console.WriteLine(area);

                {
                  

                }
            }
                }

            }
        }
    
