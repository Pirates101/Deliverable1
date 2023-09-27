internal class Program
{
    private static void Main(string[] args)
    {
        int soda = 100;
        int chips = 40;
        int candy = 60;

        Console.Write("How many soda sold today: ");
        int sodaSold = int.Parse(Console.ReadLine());
        soda -= sodaSold;

        if (40 >= soda)
        {
            Console.WriteLine("{0} {1} {2}", "Soda need to be restocked there are", soda, "left");

        }
        else if (-0 < soda)
        {
            Console.WriteLine("That value is too high, stock not adjusted");
        }
        else if (40 < soda)
        {
            Console.WriteLine("{0} {1} {2}", "Soda does not need to be restocked,there are", soda, "left");


        }
        Console.Write("How many chips sold today: ");
        int chipsSold = int.Parse(Console.ReadLine());
        chips -= chipsSold;

        if (20 >= chips)
        {
            Console.WriteLine("{0} {1} {2}", "Chips need to be restocked there are", chips, "left");

        }
        else if (0 > chips)
        {
            Console.WriteLine("That value is too high, stock not adjusted");
        }
        else if (20 < chips)
        {
            Console.WriteLine("{0} {1} {2}", "Chips does not need to be restocked,there are", chips, "left");
        }

            Console.Write("How many candy sold today: ");

            int candySold = int.Parse(Console.ReadLine());
            candy -= candySold;

            if (40 >= candy)
            {
                Console.WriteLine("{0} {1} {2}", "Candy need to be restocked there are", candy, "left");

            }
            else if (-0 > candy)
            {
                Console.WriteLine("That value is too high, stock not adjusted");
            }
            else if (40 < candy)
            {
                Console.WriteLine("{0} {1} {2}", "Candy does not need to be restocked,there are", candy, "left");


            }

        Console.WriteLine("{0} {1} {2} {3} {4} {5}", "Soda:", soda, "Chips:", chips, "Candy:", candy);
        
    }
}