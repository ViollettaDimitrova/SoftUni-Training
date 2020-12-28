namespace BirthdayCelebrations

{
    public class Robot : Identifiable
    {
        public Robot(string model, string Id)
            : base(Id)
        {
            this.Model = model;
        }

        public string Model { get; private set; }
    }
}