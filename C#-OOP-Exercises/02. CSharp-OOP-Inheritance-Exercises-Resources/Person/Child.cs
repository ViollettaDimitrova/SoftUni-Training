namespace Person
{
    using System;

    class Child : Person
    {
        private int age;

        public Child(string name, int age)
            : base(name, age)
        {

        }

        public override int Age
        {
            get => base.Age;
            set
            {
                if(value > 15)
                {
                    throw new ArgumentException("Invalid age!");
                }
                base.Age = value;
            }
        }
    }
}