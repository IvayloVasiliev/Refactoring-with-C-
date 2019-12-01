using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Department
    {
        private string name;
        private List<Room> rooms;

        public Department(string name)
        {
            Name = name;
            rooms = new List<Room>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Room> Rooms { get => rooms; set => rooms = value; }


    }
}
