using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214056
{
    internal class ProductTest_1214056
    {
        static void Main(string[] args)
        {
            Anime1_1214056 product1 = new Anime1_1214056("Moriarty the Patriot", "24 episode", "23 Minute");
            Anime2_1214056 product2 = new Anime2_1214056("Spy X Family", "25 episode", "24 Minute");
            Anime3_1214056 product3 = new Anime3_1214056("Black Butler", "46 episode", "24 Minute");

            /*Console.WriteLine("\"the book {0} has {1} pages\"",myBook.MyTitle, myBook.PageCount);*/
            Console.WriteLine("The first title is {0}, Has a count of {1}, and duration {2}", product1.MyTitle, product1.EpisodeCount, product1.Duration);
            Console.WriteLine("The second title is {0}, Has a count of {1}, and duration {2}", product2.MyTitle, product2.EpisodeCount, product2.Duration);
            Console.WriteLine("The last title is {0}, Has a count of {1}, and duration {2}", product3.MyTitle, product3.EpisodeCount, product3.Duration);
        }
    }
}
