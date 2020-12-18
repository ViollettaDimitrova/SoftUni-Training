namespace Animals
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstLine;
            string secondLine;

            while((firstLine = Console.ReadLine()) != "Beast!")
            {
                secondLine = Console.ReadLine();
                string[] animalInfo = secondLine.Split().ToArray();
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo[2];

                if (firstLine == "Cat")
                {
                    Animal animal = new Cat(name, age, gender);
                }
                else if (firstLine == "Dog")
                {
                    Animal animal = new Dog(name, age, gender);
                }
                else if (firstLine == "Frog")
                {
                    Animal animal = new Frog(name, age, gender);
                }
                else if (firstLine == "Kitten")
                {
                    Animal animal = new Kitten(name, age);
                }
            }
        }
    }
}