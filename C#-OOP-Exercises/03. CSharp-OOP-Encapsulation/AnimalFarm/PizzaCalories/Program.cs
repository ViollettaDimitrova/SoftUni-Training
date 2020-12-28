namespace PizzaCalories
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string pizzaName = Console.ReadLine();

            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            string flourType = input[1];
            string bakingTechnique = input[2];
            double weight = double.Parse(input[3]);

            Dough dough = new Dough(flourType, bakingTechnique, weight);

            Pizza pizza = new Pizza(pizzaName, dough);

            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] toppingInput = command
                    .Split()
                    .ToArray();

                string toppingType = toppingInput[1];
                double toppingWeight = double.Parse(toppingInput[2]);

                Topping topping = new Topping(toppingType, toppingWeight);

                pizza.AddTopping(topping);

                command = Console.ReadLine();
            }

            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:F2} Calories.");
        }
    }
}
