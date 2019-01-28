using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            var objRectangle = new Rectangle();
            

            Console.WriteLine("Enter length of rectange :"); // Prompt
            bool validLength = false;
            while (!validLength) // Loop indefinitely
            {
               
                string line = Console.ReadLine(); // Get string from user
                int value;
                if (int.TryParse(line, out value)) // Try to parse the string as an integer
                {
                    if (value < 1)
                    {
                        Console.Write("Length should be greater than 0");
                        validLength = false;
                    }
                    else
                    {
                        validLength = true;
                        objRectangle.SetLength(value);
                    }
                }
                else
                {
                    Console.Write("Length should be number");
                }
               
            }

            Console.WriteLine("Enter width of rectange :"); // Prompt
            bool validWidth = false;
            while (!validWidth) // Loop indefinitely
            {

                string line = Console.ReadLine(); // Get string from user
                int value;
                if (int.TryParse(line, out value)) // Try to parse the string as an integer
                {
                    if (value < 1)
                    {
                        Console.Write("Width should be greater than 0");
                        validWidth = false;
                    }
                    else
                    {
                        validWidth = true;
                        objRectangle.SetWidth(value);
                    }
                }
                else
                {
                    Console.Write("Width should be number");
                }

            }
            while (isRunning)
            {
                Console.Write("Please type corresponding number to avail functionality\n");
                Console.Write("1. Get Rectangle Length\n");
                Console.Write("2. Change Rectangle Length\n");

                Console.Write("3. Get Rectangle Width\n");
                Console.Write("4. Change Rectangle Width\n");

                Console.Write("5. Get Rectangle Perimeter\n");
                Console.Write("6. Get Rectangle Area\n");
                Console.Write("7. Exit\n");
                string enteredValue = Console.ReadLine();

                int selectedValue;
                if (int.TryParse(enteredValue, out selectedValue)) // Try to parse the string as an integer
                {
                    if (selectedValue < 1 || selectedValue > 7)
                    {
                        Console.Write("Please enter number between 1 to 7\n");
                        isRunning = true;
                    }
                    else
                    {
                        switch (selectedValue)
                        {
                            case 1:
                                Console.Write($"The rectangle length is - {objRectangle.GetLength()}\n");
                                break;
                            case 2:
                                Console.WriteLine("Enter length of rectange :"); // Prompt
                                bool validNewLength = false;
                                while (!validNewLength) // Loop indefinitely
                                {

                                    string line = Console.ReadLine(); // Get string from user
                                    int value;
                                    if (int.TryParse(line, out value)) // Try to parse the string as an integer
                                    {
                                        if (value < 1)
                                        {
                                            Console.Write("Length should be greater than 0");
                                            validNewLength = false;
                                        }
                                        else
                                        {
                                            validNewLength = true;
                                            objRectangle.SetLength(value);
                                        }
                                    }
                                    else
                                    {
                                        Console.Write("Length should be number");
                                    }
                                }
                                break;
                            case 3:
                                Console.Write($"The rectangle width is - {objRectangle.GetWidth()}\n");
                                break;

                            case 4:
                                Console.WriteLine("Enter width of rectange :"); // Prompt
                                bool validNewWidth = false;
                                while (!validNewWidth) // Loop indefinitely
                                {

                                    string line = Console.ReadLine(); // Get string from user
                                    int value;
                                    if (int.TryParse(line, out value)) // Try to parse the string as an integer
                                    {
                                        if (value < 1)
                                        {
                                            Console.Write("Width should be greater than 0");
                                            validNewWidth = false;
                                        }
                                        else
                                        {
                                            validNewWidth = true;
                                            objRectangle.SetWidth(value);
                                        }
                                    }
                                    else
                                    {
                                        Console.Write("Width should be number");
                                    }
                                }
                                break;

                            case 5:
                                Console.Write($"The rectangle Perimeter is - {objRectangle.GetPerimeter()}\n");
                                break;

                            case 6:
                                Console.Write($"The rectangle Area is - {objRectangle.GetArea()}\n");
                                break;
                            case 7:
                                isRunning = false;
                                break;
                        }
                    }
                }
                else
                {
                    Console.Write("Please select correct option\n");
                }



                


            }
           

        }
    }
}
