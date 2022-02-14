using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Length = 0;
            int Width = 0;
            int response = 0;

            try
            {
               width:
                Console.WriteLine("please enter a width");
                Width = int.Parse(Console.ReadLine());
                if (Width < 1)
                {
                    Console.WriteLine("width cannot be less than zero");
                    goto width;
                }
                length:
                Console.WriteLine("please enter a Length");
                Length = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------");
                if (Length < 1)
                {
                    Console.WriteLine("length cannot be less than zero");
                    goto length;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("please try again in the menu");
                
            }
           
            
            while (response != 7)
                {
                try
                {
                    

                    Console.WriteLine("please select one of the following");
                    Console.WriteLine("1. Get Length of Rectangle");
                    Console.WriteLine("2. Set Length of Rectangle");
                    Console.WriteLine("3. Get Width of Rectangle");
                    Console.WriteLine("4. Set Width of Rectangle");
                    Console.WriteLine("5. Get Perimeter of Rectangle");
                    Console.WriteLine("6. Get Area of Rectangle");
                    Console.WriteLine("7. Exit");
                    response = int.Parse(Console.ReadLine());

                    if (response == 1)
                    {
                        try
                        {
                            if (Length == 0)
                            {
                                Rectangle rectangle = new Rectangle();
                                Length = rectangle.GetLength();
                                Console.WriteLine("The length is " + Length);
                                Console.WriteLine("press enter to continue");
                                Console.ReadKey();
                                Console.WriteLine("-----------------------------------");
                            }
                            else
                            {
                                Console.WriteLine(Length);
                            }
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                            Console.WriteLine("please enter to continue and try again");
                            Console.ReadKey();
                            Console.WriteLine("-----------------------------------");
                        }

                    }

                    else if (response == 2)
                    {
                        try
                        {
                            length:
                            Console.WriteLine("please enter a new length");
                            Length = int.Parse(Console.ReadLine());
                            if (Length < 1)
                            {
                                Console.WriteLine("Length cannot be less than zero");
                                goto length;
                            }
                            Rectangle rectangle = new Rectangle();
                            rectangle.SetLenght(Length);
                            Length = rectangle.GetLength();
                            Console.WriteLine("your new length is " + Length);
                            Console.WriteLine("please enter to continue");
                            Console.ReadKey();
                            Console.WriteLine("-----------------------------------");
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                            Console.WriteLine("please press enter to continue and try again");
                            Console.ReadKey();
                            Console.WriteLine("----------------------");
                        }


                    }

                    else if (response == 3)
                    {
                        try
                        {
                            if (Width == 0)
                            {
                                Rectangle rectangle = new Rectangle();
                                Width = rectangle.GetWidth();
                                Console.WriteLine("The rectangle width is " + Width);
                                Console.WriteLine();
                                Console.WriteLine("press enter to contiune");
                                Console.ReadKey();
                                Console.WriteLine("-----------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("The width is " + Width);
                                Console.WriteLine("press enter to contiune");
                                Console.ReadKey();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                            Console.WriteLine("please enter to continue and try again");
                            Console.ReadKey();
                            Console.WriteLine("-----------------------------------");
                        }

                    }

                    else if (response == 4)
                    {
                        try
                        {
                            width:
                            Console.WriteLine("please type in the width");
                            Width = int.Parse(Console.ReadLine());
                            if (Width < 1)
                            {
                                Console.WriteLine("Length cannot be less than zero");
                                goto width;
                            }
                            Rectangle rectangle = new Rectangle();
                            rectangle.SetWidth(Width);
                            Width = rectangle.GetWidth();
                            Console.WriteLine("your new width is " + Width);
                            Console.WriteLine("press enter key to contiune and try again");
                            Console.ReadKey();
                            Console.WriteLine("-----------------------------------");
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                            Console.WriteLine("please enter to continue and try again");
                            Console.ReadKey();
                            Console.WriteLine("-----------------------------------");
                        }


                    }

                    else if (response == 5)
                    {
                        try
                        {
                            if (Length == 0 && Width == 0)
                            {
                                Rectangle rectangle = new Rectangle();
                                int perimeter = rectangle.GetPerimeter();
                                Console.WriteLine("The perimeter of the rectangle is " + perimeter);
                                Console.WriteLine("press enter to contiune");
                                Console.ReadKey();
                                Console.WriteLine("-----------------------------------");
                            }
                            else
                            {
                                Rectangle rectangle = new Rectangle(Width, Length);
                                int perimeter = rectangle.GetPerimeter();
                                Console.WriteLine("The perimeter of the rectangle is " + perimeter);
                                Console.WriteLine("press enter to contiune");
                                Console.ReadKey();
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                            Console.WriteLine("please enter to continue and try again");
                            Console.ReadKey();
                            Console.WriteLine("-----------------------------------");

                        }



                    }

                    else if (response == 6)
                    {
                        try
                        {
                            if (Length == 0 && Width == 0)
                            {
                                Rectangle rectangle = new Rectangle();
                                int Area = rectangle.GetArea();
                                Console.WriteLine("The Area of the rectangle is " + Area);
                                Console.WriteLine("press enter to contiune");
                                Console.ReadKey();
                                Console.WriteLine("-----------------------------------");
                            }
                            else
                            {
                                Rectangle rectangle = new Rectangle(Width, Length);
                                int Area = rectangle.GetArea();
                                Console.WriteLine("The perimeter of the rectangle is " + Area);
                                Console.WriteLine("press enter to contiune");
                                Console.ReadKey();
                                Console.WriteLine("-----------------------------------");
                            }

                        }
                        catch (Exception e)
                        {

                            Console.WriteLine(e.Message);
                            Console.WriteLine("please enter to continue and try again");
                            Console.ReadKey();
                            Console.WriteLine("-----------------------------------");

                        }



                    }
                    if (response == 7)
                    {
                        Console.WriteLine("you are now exiting the app");
                        Console.WriteLine("please enter to continue");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("please type in one of the numbers for the options");
                        Console.WriteLine("please enter to continue and try again");
                        Console.ReadKey();
                        Console.WriteLine("-----------------------------------");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("please type in one of the numbers for the options");
                    Console.WriteLine("please enter to continue and try again");
                    Console.ReadKey();
                    Console.WriteLine("-----------------------------------");

                }
                    



            }
            
            
        }
    }
}
