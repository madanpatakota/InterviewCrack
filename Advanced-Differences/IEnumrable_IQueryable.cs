using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperienceCandidates.Differences
{

    //Diff 

  
    internal class IEnumrable_IQueryable_Program
    {
        static void Main()
        {
            /*********************IEnumrable********************/
            //Represents an in-memory collection.
            //Immediate execution: The query is executed, and data is loaded into memory immediately.


            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            // Filtering numbers greater than 3
            IEnumerable<int> filteredNumbers = numbers.Where(x => x > 3);

            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }


            /*********************IQueryable********************/

            //Represents a query that can be executed against a data source (like a database).
            //Deferred execution: Query is translated into a command (like SQL) and executed only when needed.

            //using (var dbContext = new MyDbContext())
            //{
            //    Querying a database table
            //    IQueryable<Product> products = dbContext.Products.Where(p => p.Price > 100);

            //    foreach (var product in products)
            //    {
            //        Console.WriteLine(product.Name + " - " + product.Price);
            //    }
            //}

        }

    }
}
