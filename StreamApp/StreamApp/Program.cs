using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are now watching on Essential subscription");
            Subscription package = new EssentialSubscription();

            Stream getSubscribed = package.AddSubscription("Podcast");
            Stream stream1 = new Stream(new Podcast());
            getSubscribed = package.AddSubscription("News");
            Stream stream2 = new Stream(new News());
            getSubscribed = package.AddSubscription("Videos");
            Stream stream5 = new Stream(new Videos());  

            Console.WriteLine();

            Console.WriteLine("You are now watching on Delux Subcription");
            package = new DeluxeSubscription();
            getSubscribed = package.AddSubscription("Movies");
            Stream stream3 = new Stream(new Movies());
            getSubscribed = package.AddSubscription("Sports");
            Stream stream4 = new Stream(new Sports());
            getSubscribed = package.AddSubscription("Videos");
            Stream stream6 = new Stream(new Videos());


            Console.WriteLine();
            Console.WriteLine("Streaming on Essential Subscription");
            stream1.watch();
            stream2.watch();
            stream5.watch();

            Console.WriteLine();
            Console.WriteLine("Streaming on Deluxe Subscription");
            stream3.watch();
            stream4.watch();
            stream6.watch();    


            Console.ReadLine();
        }
    }
}
