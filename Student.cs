using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project
{
    class Student : User
    {
        public int RoomNumber { get; private set; }
        public Student(string name, int roomNumber)
        {
            Name = name;
            Role = "Student";
            RoomNumber = roomNumber;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Role: {Role}, Room: {RoomNumber}");
        }
    }
}