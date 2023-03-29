using System.Diagnostics.Metrics;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a value that you would like to withdraw in $: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            
            while (amount > 0)
            {
                int banknote = ATM.Banknote(amount);
                Console.WriteLine(banknote + "$");
                amount -= banknote;
                counter++;
            }
            if (amount < 0)
            {
                Console.WriteLine("Am i joke to you? Enter a real value!");
            }
            else
            {
                if (counter == 0)
                {
                    Console.WriteLine("You're broke my friend :(");
                }
                else 
                {
                    Console.WriteLine($"You've got {counter} banknotes");
                }
            }
        }
    }
}