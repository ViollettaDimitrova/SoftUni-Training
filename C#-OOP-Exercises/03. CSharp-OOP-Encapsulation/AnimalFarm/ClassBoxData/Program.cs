namespace Task1
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal length = decimal.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                decimal height = decimal.Parse(Console.ReadLine());

                Box box = new Box(height, width, length);
                Console.WriteLine(box.SurfaceArea());
                Console.WriteLine(box.LateralSurfaceArea());
                Console.WriteLine(box.Volume());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}