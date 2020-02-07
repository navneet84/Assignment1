using System;

namespace Rectangle
{
    class Program : Rectangle
    {
        static void Main(string[] args)
        {

            Rectangle rec = new Rectangle();
            int l;
            int w;
            bool r = true;
            while (r)
            {
                try
                {

                    Console.WriteLine("\n Welcome");
                    Console.WriteLine("Select one option from list");
                    Console.WriteLine("1. Get Rectangle Length");
                    Console.WriteLine("2. Change Rectangle Length");
                    Console.WriteLine("3. Get Rectangle Width");
                    Console.WriteLine("4. Change Rectangle Width");
                    Console.WriteLine("5. Get Rectangle Perimeter");
                    Console.WriteLine("6. Get Rectangle Area");
                    Console.WriteLine("7. Exit \n");

                    int input = int.Parse(Console.ReadLine());


                    switch (input)
                    {

                        case 1:

                            Console.WriteLine(rec.GetLength());

                            break;


                        case 2:
                            try
                            {

                                Console.WriteLine("1. Enter the Length of Rectangle");
                                l = int.Parse(Console.ReadLine());

                                if (l <= 0)
                                {
                                    Console.WriteLine("Wrong input");

                                }

                                rec.SetLength(l);


                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Wrong Input");
                            }

                            break;

                        case 3:
                            Console.WriteLine(rec.GetWidth());


                            break;


                        case 4:
                            try
                            {

                                Console.WriteLine("2. Enter Rectangle's Width");
                                w = int.Parse(Console.ReadLine());

                                if (w <= 0)
                                {
                                    Console.WriteLine("Enter Valid Value");
                                }

                                rec.SetWidth(w);

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Wrong Input");
                            }

                            break;


                        case 5:
                            Console.WriteLine("Perimeter " + rec.GetPerimeter());
                            break;


                        case 6:
                            Console.WriteLine("Area " + rec.GetArea());
                            break;


                        case 7:
                            Console.WriteLine("Please Visit Again ");
                            Environment.Exit(0);
                            r = false;
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong Input");
                };

            }


        }

    }
}
