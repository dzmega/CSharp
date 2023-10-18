using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAutorennen
{
    public class Figur
    {
        private ConsoleColor color;
        private int x;
        private int y;
        private int speed;

        public Figur()
        {

        }

        public Figur(ConsoleColor color, int x, int y, int speed)
        {
            this.Color = color;
            this.X = x;
            this.Y = y;
            this.Speed = speed;
        }

        public ConsoleColor Color { get => color; set => color = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Speed { get => speed; set => speed = value; }
    }
}
