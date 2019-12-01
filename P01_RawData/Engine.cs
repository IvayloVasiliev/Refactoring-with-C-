using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            Power = power;
            Speed = speed;
        }

        public int Power { get => power; set => power = value; }
        public int Speed { get => speed; set => speed = value; }
    }
}
