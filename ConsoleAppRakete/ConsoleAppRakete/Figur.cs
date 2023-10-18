using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRakete
{
    public class Figur
    {
        private ConsoleColor color;
        private int speed;
        private int x;
        private int y;

        public Figur()
        {

        }

        public Figur(ConsoleColor color, int speed, int x, int y)
        {
            this.color = color;
            this.speed = speed;
            this.x = x;
            this.y = y;
        }

        public ConsoleColor Color { get => color; set => color = value; }
        public int Speed { get => speed; set => speed = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
