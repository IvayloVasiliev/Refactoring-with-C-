﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Cargo
    {
        private int weight;
        private string type;

        public Cargo(string type, int weight)
        {
            Weight = weight;
            Type = type; 
        }

        public string Type { get => type; set => type = value; }
        public int Weight { get => weight; set => weight = value; }
    }
}
