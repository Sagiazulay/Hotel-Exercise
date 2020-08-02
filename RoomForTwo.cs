using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class RoomForTwo : Room
    {
        public RoomForTwo(int roomnumber, float price) : base(roomnumber: 7, price: 1000f) 
        {
        }
        protected override void SetFeatures()
        {
            Console.WriteLine("TV, One Bed...");
        }
    }
}
