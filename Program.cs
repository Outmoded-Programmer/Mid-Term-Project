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

            if (role.ToLower() == "admin")
            {
                Admin admin = new Admin("Muhammad Shahzad");
                while (true)
                {
                    Console.WriteLine("\nAdmin Panel");
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. Remove Student");
                    Console.WriteLine("3. List Students");
                    Console.WriteLine("4. Exit");
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
                            payment.ProcessPayment(5000);
                            break;
                        case "2":
                            IComplaintHandling complaintService = new ComplaintService();
                            Console.Write("Enter your complaint: ");
                            string complaint = Console.ReadLine();
                            complaintService.RegisterComplaint(complaint);
                            break;
                        case "3":
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
