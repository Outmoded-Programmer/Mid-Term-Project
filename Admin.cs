using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project
{
    class Admin : User
    {
        public string Password { get; set; }
        private readonly List<Student> students = new List<Student>();

        public Admin(string name , string password)
        {
            Name = name;
            Role = "Admin";
            Password = password;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Admin: {Name}, Role: {Role}");
        }

        public void AddStudent(string studentName, int roomNumber)
        {
            int studentInRoom = 0;
            foreach(var student in students)
            {
                if(student.RoomNumber == roomNumber)
                {
                    studentInRoom ++;
                }
            }
            if (studentInRoom >= 2)
            {
                Console.WriteLine($"The room is occupied can not add {studentName} in room {roomNumber}");
            }
            else
            {
                students.Add(new Student(studentName, roomNumber));
                Console.WriteLine($"Student {studentName} added to Room {roomNumber}.");
            }
        }

        public void RemoveStudent(string studentName)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Name == studentName)
                {
                    students.RemoveAt(i);
                    Console.WriteLine($"Student {studentName} removed.");
                    return;
                }
            }
            Console.WriteLine($"Student {studentName} not found.");
        }

        public void ListStudents()
        {
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                student.DisplayInfo();
            }
        }
    }

}