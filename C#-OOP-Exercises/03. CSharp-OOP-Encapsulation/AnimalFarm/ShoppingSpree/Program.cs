namespace EncapsulationTask3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            try
            {
                List<Person> people = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => new
                    {
                        Name = p.Split('=')[0],
                        Money = decimal.Parse(p.Split('=')[1])
                    })
                    .Select(x => new Person(x.Name, x.Money))
                    .ToList();

                List<Product> products = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => new
                    {
                        Name = p.Split('=')[0],
                        Cost = decimal.Parse(p.Split('=')[1])
                    })
                    .Select(x => new Product(x.Name, x.Cost))
                    .ToList();

                string input = Console.ReadLine();

                while(input != "END")
                {
                    string[] inputInfo = input.Split();

                    string name = inputInfo[0];
                    string product = inputInfo[1];

                    Person person = people.FirstOrDefault(x => x.Name == name);
                    Product product1 = products.FirstOrDefault(x => x.Name == product);
                    person.AddToBag(product1);
                    input = Console.ReadLine();
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}