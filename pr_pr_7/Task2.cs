using System;
using System.Collections.Generic;
using System.Text;

namespace pr_pr_7
{
    class Task2
    {
    }

    public interface IMeasurable
    {
        double Perimeter();
        double Area();
    }
    public interface ICircumcircleIncircle
    {
        double R { get; } // радіус описаного кола
        double r { get; } // радіус вписаного кола
    }    public class Square : IMeasurable, IComparable
    {
        private double side;

        public double Perimeter()
        {
            return 4 * side;
        }

        public double Area()
        {
            return side * side;
        }

        public int CompareTo(object obj)
        {
            return Perimeter() > ((Square)obj).Perimeter() ? 1 : Perimeter() < ((Square)obj).Perimeter() ? -1 : 0;
        }
    }    public interface Room
    {
        double getArea();
        int getAmOfWindows();
    }    public class ClassRoom : Room, IComparable
    {
        private int amOfWindows;
        private double wallLength;
        private int windows;
        public double getArea()
        {
            return Math.Pow(wallLength, 2);
        }
        public int CompareTo(object o)
        {
            return getArea() > ((ClassRoom)o).getArea() ? 1 : ((ClassRoom)o).getArea() > getArea() ? -1 : 0;
        }
        public int getAmOfWindows()
        {
            return windows;
        }
    }    public class MyRoom : Room, IComparable
    {
        private double wallLength;
        private int windows;
        public double getArea()
        {
            return Math.Pow(wallLength, 2);
        }
        public int CompareTo(object o)
        {
            return getArea() > ((MyRoom)o).getArea() ? 1 : ((MyRoom)o).getArea() > getArea() ? -1 : 0;
        }
        public int getAmOfWindows()
        {
            return windows;
        }
    }    public class IComparerImpl : IComparer<Room>
    {
        public int Compare(Room room1, Room room2)
        {
            return room1.getArea() > room2.getArea() ? 1 : room2.getArea() > room1.getArea() ? -1 : 0;
        }
    }
}