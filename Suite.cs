using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Suite : Room
    {
        public Suite(int roomnumber, float price) : base(roomnumber: 9, price: 150f)
        {

        }
        protected override void SetPrice()
        {
            this.GetPrice();
        }
        protected override void SetFeatures()
        {
            Console.WriteLine("TV, Mini-Bar, Romantic Shower...");
        }
    }
}
