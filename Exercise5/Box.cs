using System;
namespace Exercise5
{
    public class Box
    {
        int length;
        int height;
        int width;
        int volume;

        public Box()
        {
            GetWidth();
            GetHeight();
            GetLength();
            getVolume();

            Console.WriteLine($"The volume of the box is {volume}");
        }
        public void GetWidth()
        {
            Console.WriteLine("Enter width of box => ");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public void GetHeight()
        {
            Console.WriteLine("Enter height of box = > ");
            height = Convert.ToInt32(Console.ReadLine());
        }
        public void GetLength()
        {
            Console.WriteLine("Enter lenght of box => ");
            length = Convert.ToInt32(Console.ReadLine());
        }
        public double getVolume()
        {
            int volume = length * width * height;
            return volume;
        }

    }
}
