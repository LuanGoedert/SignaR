using System;

namespace SignalRWerbService
{
    public class Stock
    {
        private decimal _price;
        public string Symbol { get; set; }
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(_price == value)
                {
                    return;
                }
                if(DayOpen == 0)
                {
                    DayOpen = _price;
                }
            }
        }

        public decimal DayOpen { get; private set; }
        public decimal Change
        {
            get
            {
                return Price - DayOpen;
            }
        }
        public double PercetnChange
        {
            get
            {
                return (double)Math.Round(Change / Price, 4);
            }
        }
    }
}
