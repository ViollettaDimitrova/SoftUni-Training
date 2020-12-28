namespace Telephony
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            var numbers = new List<string>(Console.ReadLine().Split());

            foreach (var number in numbers)
            {
                Console.WriteLine(smartphone.Call(number));
            }

            var URLs = new List<string>(Console.ReadLine().Split());

            foreach (var URL in URLs)
            {
                Console.WriteLine(smartphone.Browse(URL));
            }
        }
    }
}