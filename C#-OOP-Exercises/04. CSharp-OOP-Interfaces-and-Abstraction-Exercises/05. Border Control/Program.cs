namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Identifiable> rebellions = new List<Identifiable>();

            while(command != "End")
            {
                string[] incomers = command.Split().ToArray();

                if(incomers.Length == 3)
                {
                    string name = incomers[0];
                    int age = int.Parse(incomers[1]);
                    string ID = incomers[2];

                    var citizen = new Citizen(name, age, ID);

                    rebellions.Add(citizen);
                }
                else
                {
                    string model = incomers[0];
                    string ID = incomers[1];

                    var robot = new Robot(model, ID);

                    rebellions.Add(robot);
                }

                command = Console.ReadLine();
            }

            var fakeID = Console.ReadLine();

            foreach (var rebellion in rebellions)
            {
                if (rebellion.CheckForFakeID(fakeID))
                {
                    Console.WriteLine(rebellion.Id);
                }
            }
        }
    }
}