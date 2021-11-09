using System;

    public class Class1
    {
	    public Class1()
	    {
		    public static void Main(string[] args)
            {
			    int number;
			    Program program = new Program();
			    number = program.Randomchik();
                for (int i = 0; i < 100; i++)
                {
                    if (i == 5)
                    {
                        Console.WriteLine("You lose");
                        return;
                    }

                    Console.WriteLine("Input number");
                    int x = Convert.ToInt32(Console.ReadLine());

                    if (x == number)
                    {
                        Console.WriteLine("You Win!");
                        return;
                    }
                    else if (x < number)
                    {
                        Console.WriteLine("твое число меньше заданого");
                    }

                    else if (x > number)
                    {
                        Console.WriteLine("твое число больше заданого");
                    }

                    Console.ReadKey();
                }
            }

	    }
    }
