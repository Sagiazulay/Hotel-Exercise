using Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public static class Reception
    {
        private const int NUMBER_OF_ROOMS = 10;
        private static int NumberOfGuests;
        private static Room[] rooms;
        private static RoomService roomService = new RoomService();

        static Reception()
        {
            rooms =  new Room[NUMBER_OF_ROOMS];
            for (int i = 0; i < NUMBER_OF_ROOMS - 1; i++)
            {
                if(i % 3 == 0)
                    rooms[i] = new RoomForTwo(i, 100);
                else if (i % 2 == 0)
                    rooms[i] = new FamilyRoom(i, 100);
                else
                    rooms[i] = new Suite(i, 100);
            }
        }
        public static void CheckIn(Guest g)
        {
            for (int i = 0; i < NUMBER_OF_ROOMS-1; i++)
            {
                if (rooms[i].GetGuest() == null)
                {
                    //SendRoomService(rooms[i]);
                    rooms[i].SetGuest(g);
                    NumberOfGuests++;
                    return;
                }
            }
            Console.WriteLine("Sorry No Rooms Available");
        }
        public static void CheckOut(Room room)
        {
            room.SetGuest(null);
            NumberOfGuests--;
        }
        public static bool IsRoomFree(Room room)
        {
            if (room.GetGuest() == null)
            {
                return false;
            }
            return true;
        }
        private static void SendRoomService(Room room)
        {
            roomService.CleanRoom(room);
        }

    }
}
