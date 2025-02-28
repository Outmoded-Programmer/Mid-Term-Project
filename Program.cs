using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your role (Admin/Student): ");
            string role = Console.ReadLine();
            Admin admin = new Admin(name: "Shahzad", password: "123");
            if (role.ToLower() == "admin")
            {
                Console.Write("Enter your Password: ");
                string adminPassword = Console.ReadLine();
                if(adminPassword != admin.Password) {
                    Console.WriteLine("Wrong Password");
                    return;
                }
            }

            if (role.ToLower() == "admin")
            {
                Console.WriteLine($"Welcome Admin:{admin.Name}");

                Attendance attendance = new Attendance();
                 
                while (true)
                {
                    Console.WriteLine("\nAdmin Panel");
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. Remove Student");
                    Console.WriteLine("3. List Students");
                    Console.WriteLine("4. Attendence");
                    Console.WriteLine("5. Exit");
                    Console.Write("Choose an option: ");

                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter student name: ");
                            string studentName = Console.ReadLine();
                            Console.Write("Enter room number: ");
                            int roomNumber = int.Parse(Console.ReadLine());
                            admin.AddStudent(studentName, roomNumber);
                            break;
                        case "2":
                            Console.Write("Enter student name to remove: ");
                            string removeName = Console.ReadLine();
                            admin.RemoveStudent(removeName);
                            break;
                        case "3":
                            admin.ListStudents();
                            break;
                        case "4":
                            Console.WriteLine("Enter student name for attendence mark");
                            string attendenceName = Console.ReadLine();
                            Console.WriteLine("Is the student present? (true/ false):");
                            bool isPresent = Convert.ToBoolean(Console.ReadLine());
                            attendance.MarkAttendance(attendenceName, isPresent);
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Invalid option, please try again.");
                            break;
                    }
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("\nStudent Panel");
                    Console.WriteLine("1. Process Payment");
                    Console.WriteLine("2. Register Complaint");
                    Console.WriteLine("3. Exit");
                    Console.Write("Choose an option: ");

                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            IPayment payment = new FeePayment();
                            Console.WriteLine("Enter the payment to be proccessed");
                            double pay = Convert.ToDouble(Console.ReadLine());
                            payment.ProcessPayment(pay);
                            break;
                        case "2":
                            IComplaintHandling complaintService = new ComplaintService();
                            Console.Write("Enter your complaint: ");
                            string complaint = Console.ReadLine();
                            complaintService.RegisterComplaint(complaint);
                            break;
  
                        case "4":
                            return;
                        default:
                            Console.WriteLine("Invalid option, please try again.");
                            break;
                    }
                }
            }
        }
    }
}
