using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project
{
    class DeluxeRoom : Room
    {
        public DeluxeRoom(int roomNumber) : base(roomNumber) { }

        public override void AllocateRoom()
        {
            base.AllocateRoom();
            Console.WriteLine("Deluxe amenities included.");
        }
    }
}