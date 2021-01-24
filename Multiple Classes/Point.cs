using System;

namespace Multiple_Classes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Show()
        {
            Console.WriteLine($"Point(X) = {X}");
            Console.WriteLine($"Point(Y) = {Y}");
        }
    }
}
