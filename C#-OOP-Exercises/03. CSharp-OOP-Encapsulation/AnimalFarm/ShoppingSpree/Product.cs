namespace EncapsulationTask3
{
    using System;

    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return cost;
            }

            private set
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }

                this.cost = value;
            }
        }
    }
}