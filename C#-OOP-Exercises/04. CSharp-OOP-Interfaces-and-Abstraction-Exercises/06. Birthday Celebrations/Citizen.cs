namespace BirthdayCelebrations
{
    public class Citizen : Identifiable, IBirthable
    {
        public Citizen(string name, int age, string Id, string birthDate)
            : base(Id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = Id;
            this.BirthDate = birthDate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string ID { get; private set; }

        public string BirthDate { get; private set; }
    }
}