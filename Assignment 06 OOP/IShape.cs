using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP
{
    internal interface IShape
    {
        public decimal Area { get; }

        public void DisplayShapeInfo();
    }

    internal interface ICircle : IShape
    {
        public decimal Radius { get; set; }
    }

    internal interface IRectangle : IShape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
    }

    internal class Circle : ICircle
    {
        public Circle(decimal radius)
        {
            Radius = radius;
        }
        public decimal Radius { get; set; }

        public decimal Area
        {
            get { return Radius * Radius; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Area = {Area}");
        }
    }


    internal class Rectangle : IRectangle
    {

        public Rectangle(decimal dim01, decimal dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;

        }

        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        public decimal Area
        {
            get
            {
                return Dim01 * Dim02;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($" Rectangle Area = {Area}");
        }
    }


}
