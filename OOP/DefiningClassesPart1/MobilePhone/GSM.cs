using System;
using System.Collections.Generic;

namespace MobilePhone
{
    class GSM
    {
        //Fields and Properties - Start.
        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length >= 0)
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private string manufacturer;
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length >= 0)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value == null || value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private string owner;
        public string Owner
        {
            get { return owner; }
            set
            {
                if (value == null || value.Length >= 0)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        private Battery battery;
        internal Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        private Display display;
        internal Display Display
        {
            get { return display; }
            set { display = value; }
        }

        static private GSM iphone4S = new GSM("Iphone 4S", "Apple", 500, "Evlogi",
            new Battery("7V801S", 66.3, 10.3, BatteryType.NiCd), new Display(8, 65000));
        static public GSM Iphone4S
        {
            get { return iphone4S; }
        }

        public List<Call> CallHistory
        {
            get;
            private set;
        }
        //Fields and Properties - End.

        //Constructors - Start.
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0m, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, null, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null)
        {
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }
        //Constructors - End.

        //Methods.
        public void AddCall(Call call)
        {
            List<Call> tmp = new List<Call>();
            if (CallHistory != null)
            {
                tmp.AddRange(CallHistory);
            }

            tmp.Add(call);
            this.CallHistory = tmp;
        }

        public void DeleteCall(int index)
        {
            List<Call> tmp = new List<Call>();
            if (CallHistory != null)
            {
                tmp.AddRange(CallHistory);
            }
            tmp.RemoveAt(index);
            this.CallHistory = tmp;
        }

        public void ClearHistory()
        {
            CallHistory = null;
        }

        public decimal CalculatePrice(decimal ppm)
        {
            long duration = 0;
            foreach (var call in CallHistory)
            {
                duration += call.Duration;
            }

            //Convert to minutes.
            decimal durationInMinutes = Math.Round((decimal)duration / 60, 2);

            return Math.Round(durationInMinutes * ppm, 2);
        }

        //Override ToString().
        public override string ToString()
        {
            return string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattery: {4}\nDisplay: {5}",
                model, manufacturer, price, owner, battery, display);
        }
    }
}
