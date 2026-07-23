namespace Task_Session1_535
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Islam's Carpet Cleaning Service");
            Console.WriteLine("Price per small carpet : $25");
            Console.WriteLine("Price per large carpet : $35");
            Console.WriteLine("Tax : 6%");
            Console.WriteLine("Enter the number of small carpets:");
            int numberOfSmallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of large carpets:");
            int numberOfLargeCarpets = Convert.ToInt32(Console.ReadLine());
            int Cost = numberOfSmallCarpets*25 + numberOfLargeCarpets*35;
            Console.WriteLine($"Cost = ${Cost}");
            double Tax = Cost * 0.06;
            Console.WriteLine($"Tax = ${Tax}");
            double Total = Cost + Tax;
            Console.WriteLine($"Total = ${Total}");
            
        }
    }
}
