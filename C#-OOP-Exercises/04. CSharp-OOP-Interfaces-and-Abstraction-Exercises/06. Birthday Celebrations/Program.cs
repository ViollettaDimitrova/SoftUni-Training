namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IBirthable>();

            var command = Console.ReadLine();

            while (command != "End")
            {
                string[] input = command.Split().ToArray();

                if (input[0] == "Citizen")
                {
                    list.Add(new Citizen(input[1], int.Parse(input[2]), input[3], input[4]));
                }
                else if (input[0] == "Pet")
                {
                    list.Add(new Pet(input[1], input[2]));
                }

                command = Console.ReadLine();
            }

            string birthYear = Console.ReadLine();

            list
                .Where(x => x.BirthDate.EndsWith(birthYear))
                .Select(x => x.BirthDate)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}