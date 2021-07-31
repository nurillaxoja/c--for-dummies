using MathRoutines;
using System;

namespace Chapter20
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort obj = new Sort();
            obj.SomeMethod();
            Paint.PaintColor black = new Paint.PaintColor(0, 0, 0);
            black.Paint();
            Paint.PaintColor.StaticPaint();
        }
    }
}
namespace MathRoutines
{
    class Sort
    {
        public void SomeMethod()
        {
            Console.WriteLine("MathRoutines.Sort.Somemethod");
        }
    }
}
namespace Paint
{
    public class PaintColor
    {
        public PaintColor(int nRed, int nGreen , int nBlue)
        {
            Console.WriteLine("Paint.PaintColor.PaintColor");
        }
        public void Paint() { Console.WriteLine("Paint.PaintColor.Paint"); }
        public static void StaticPaint() { Console.WriteLine("Paint.PaintColor.StaticPaint"); }
    }
}