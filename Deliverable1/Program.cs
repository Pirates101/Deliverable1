internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("How many soda sold today: ");
        int soda = int.Parse(Console.ReadLine());

        Console.Write("How many chips sold today: ");
        int chips = int.Parse(Console.ReadLine());

        Console.Write("How many candy sold today: ");
        int candy = int.Parse(Console.ReadLine());

        if (40 >= 100 - soda)
        {
            Console.WriteLine("Soda need to be restocked, there are");
            Console.WriteLine(100 - soda);
            Console.WriteLine("left");
        }
        else if (soda > 100)
        {
            Console.WriteLine("That value is too high, stock not adjusted");
        }
        else if (40 < 100 - soda)
        {
            Console.WriteLine("Soda does not need to be restocked,there are");
            Console.WriteLine(100 - soda);
            Console.WriteLine("left");

        }
        if (20 >= 40 - chips)
        {
            Console.WriteLine("Chips need to be restocked, there are");
            Console.WriteLine(40 - chips);
            Console.WriteLine("left");
        }
        else if (soda > 100)
        {
            Console.WriteLine("That value is too high, stock not adjusted");
        }
        else if (20 < 40 - chips)
        {
            Console.WriteLine("Chips does not need to be restocked,there are");
            Console.WriteLine(40 - chips);
            Console.WriteLine("left");

        }
        if (40 >= 60 - soda)
        {
            Console.WriteLine("Candy need to be restocked, there are");
            Console.WriteLine(60 - candy);
            Console.WriteLine("left");
        }
        else if (candy > 60)
        {
            Console.WriteLine("That value is too high, stock not adjusted");
        }
        else if (40 < 60 - candy)
        {
            Console.WriteLine("Candy does not need to be restocked,there are");
            Console.WriteLine(60 - candy);
            Console.WriteLine("left");

        }
    }
}