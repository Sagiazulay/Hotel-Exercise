using Clients;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public abstract class Room
    {
        protected int _roomNumber;
        protected float _price;
        protected Guest _guest;
        protected bool _isClean;
        protected string _features;

        public Room(int roomnumber, float price)
        {
            this._roomNumber = roomnumber;
            this._price = price;
            SetPrice();
            SetFeatures();
        }
        internal void SetGuest (Guest guest)
        {
            this._guest = guest;
        }
        protected virtual void SetPrice()
        {
            
            _price = 50;
        }
        protected abstract void SetFeatures();

        public int GetRoomNumber()
        {
            return _roomNumber;
        }
        public float GetPrice()
        {
            return _price;
        }
        public Guest GetGuest()
        {
            return _guest;
        }
        public void SetClean(bool isClean)
        {
            this._isClean = isClean;
        }
        public bool IsClean()
        {
            return _isClean;
        }
        public string GetFeatured()
        {
            return $"Bed";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
