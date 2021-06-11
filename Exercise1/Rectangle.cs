using System;
namespace Exercise1
{
   class Rectangle
    {
        double length = 1;
        double width = 1;
        double area = 1;
        double perimeter = 1;
        
        public void GetData()
        {
        again:
            Console.WriteLine("enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width");
            width = Convert.ToInt32(Console.ReadLine());
            if (length <0 || length > 20 || width<0 || width>20 )
            {
                Console.WriteLine("please enter length and width between 0 and 20");
                goto again;
            }
        }

        public double GetArea()
        {
            area = length * width;
            return area;
        }

        public double GetPerimeter()
        {
            perimeter = 2 * (length * width);
            return perimeter;
        }
        public void Display()
        {
            Console.WriteLine($"The width of the rectangle is {width}");
            Console.WriteLine($"The length of the rectangle is {length}");
            Console.WriteLine($"The area of the rectangle is {area}");
            Console.WriteLine($"The perimeter of the rectangle is {perimeter}");
        }
    }
}
