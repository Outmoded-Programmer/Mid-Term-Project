using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project
{
    class Attendance
    {

        private Dictionary<string, bool> records = new Dictionary<string, bool>();

        public void MarkAttendance(string studentName, bool isPresent)
        {
            records[studentName] = isPresent;
            Console.WriteLine($"Attendance: {studentName} - {(isPresent ? "Present" : "Absent")}");
        }
    }
}

