using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project
{
    class Admin : User
    {
        private List<Student> students = new List<Student>();

        public Admin(string name)
        {
            Name = name;
            Role = "Admin";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Admin: {Name}, Role: {Role}");
        }

        public void AddStudent(string studentName, int roomNumber)
        {
            students.Add(new Student(studentName, roomNumber));
            Console.WriteLine($"Student {studentName} added to Room {roomNumber}.");
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