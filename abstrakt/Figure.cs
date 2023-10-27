using abstrakt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace abstrakt
{
    internal abstract class Figure
    {

        public abstract int CalcArea();
       
    }
    internal class Square: Figure
    {
        private int side;

        public Square(int side)
        {
            Side = side;
        }

        public int Side { get { return side; } 
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Enter a non negative int");
                }
                else
                {
                    side = value;
                }

            } 
        }

        

        public override int CalcArea() 
        { 
            if (Side <= 0) 
            {
                return -1;
            }
            return Side * Side;
        }
    }
    internal class Rectangle : Figure
    {
        private int lenght;
        private int width;

        public Rectangle(int lenght, int width)
        {
            Lenght = lenght;
            Width = width;
        }

        public int Lenght {  get { return lenght;} 
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Enter a non negative integer");
                }
                else
                {
                    lenght = value;
                }
            } 
        } 
        public int Width { get { return width; } 
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Enter a non negative integer");
                }
                else
                {
                   width = value;
                }
            } 
        }

        public override int CalcArea()
        {
            if (Width <= 0 || Lenght <=0)
            {
                return -2;
            }
            return Lenght * Width;
        }
    }
}


