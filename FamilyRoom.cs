using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class FamilyRoom : Room
    {
        public FamilyRoom(int roomnumber, float price) : base(roomnumber: 5, price: 100f) 
        {

        }
        protected override void SetFeatures()
        {
            Console.WriteLine("Fridge, Kitchen, 4 Beds..");
        }
        protected override void SetPrice()
        {
            base.SetPrice();
        }
    }
}
