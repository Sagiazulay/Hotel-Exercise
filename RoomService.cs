using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class RoomService
    {
        internal void CleanRoom(Room room)
        {
            room.SetClean(true);
            Console.WriteLine($"Cleaning The Room, Cleaned Also The {room.GetFeatured()}");
        }
       //internal void CleanRoom(RoomForTwo forTwo)
       //{
       //    forTwo.SetClean(true);
       //    Console.WriteLine($"Cleaning The Room For Two, Cleaned Also The {forTwo.GetFeatured()}");
       //}
       //internal void CleanRoom(FamilyRoom familyRoom)
       //{
       //    Console.WriteLine($"Cleaning The Family Room, Cleaned Also The {familyRoom.GetFeatured()}");
       //}
       //internal void CleanRoom(Suite suite)
       //{
       //    Console.WriteLine($"Cleaning The Suite, Cleaned Also The {suite.GetFeatured()}");
       //}
    }
}
