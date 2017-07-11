using System;
using System.Collections.Generic;
namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double sales = 0;

            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            
            transactions.Add(("Dylan", 4.5, 1));
            transactions.Add(("Heidi", 7.5, 1));
            transactions.Add(("Dylan", 2.5, 1));
            transactions.Add(("Dylan", 3.8, 1));
            transactions.Add(("Dylan", 4.7, 1));

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                Console.WriteLine(t.product);
                count += t.quantity;
                sales += t.amount;
             }

             Console.WriteLine(count + " items sold, for a total sales of $" + sales);
        }
    }
}
