using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project
{
    class ComplaintService : IComplaintHandling
    {
        public void RegisterComplaint(string complaint)
        {
            Console.WriteLine($"Complaint Received: {complaint}");
        }
    }
}