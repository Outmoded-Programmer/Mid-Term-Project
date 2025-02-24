using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Term_Project
{
    class Room
    {
        public int RoomNumber { get; private set; }
        public bool IsOccupied { get; private set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            IsOccupied = false;
        }

        public virtual void AllocateRoom()
        {
            IsOccupied = true;
            Console.WriteLine($"Room {RoomNumber} allocated.");
        }
    }
}

