using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQAAssignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            Console.WriteLine("please enter the length and width of the rectangle:");
            try
            {
                do
                {
                    length = int.Parse(Console.ReadLine());
                    width = int.Parse(Console.ReadLine());
                    if (length <= 0 || width <= 0)
                    {
                        Console.WriteLine("Please enter valid input");
                    }
                } while (length <= 0 || width <= 0);
                Rectangle rectangle = new Rectangle();
                int choice;
                do
                {
                    Console.WriteLine("\n\nPlease select one optiion from Menu");
                    Console.WriteLine("1. Get Rectangle Length");
                    Console.WriteLine("2. Change Rectangle Length");
                    Console.WriteLine("3. Get Rectangle Width");
                    Console.WriteLine("4. Change Rectangle Width");
                    Console.WriteLine("5. Get Rectangle Perimeter");
                    Console.WriteLine("6. Get Rectangle Area");
                    Console.WriteLine("7.Exit");
                    choice = int.Parse(Console.ReadLine());
                    if ((choice <= 0 || choice > 7))
                    {
                        Console.WriteLine("Invalid option Selected,Please select valid option");
                    }
                    else
                    {
                        switch (choice)
                        {
                            case 1 :
                                
                                Console.WriteLine("Length of Rectangle " + rectangle.GetLength());
                                break;
                            case 2 :
                                rectangle.SetLength(length);
                                Console.WriteLine("Changed length of Rectangle " + rectangle.GetLength());
                                break;
                            case 3 :
                                Console.WriteLine("Width of Rectangle :" + rectangle.GetWidth());
                                break;
                            case 4 :
                                rectangle.SetWidth(width);
                                Console.WriteLine("Changed Width of Rectangle :" + rectangle.GetWidth());
                                break;
                            case 5 :
                                Console.WriteLine("Perimeter of Rectangle :" + rectangle.GetPerimeter());
                                break;
                            case 6 :
                                Console.WriteLine("Area of Rectangle :" + rectangle.GetArea());
                                break;
                            case 7 :
                                Console.WriteLine("Exiting..........");
                                System.Environment.Exit(0);
                                break;
                        }
                    }
                } while ((choice >= 1 && choice <= 7));

            }catch(Exception e)
            {
                Console.WriteLine("Please enter numerics-"+e.Message);
            }
            Console.ReadLine();
        }
    }
}
