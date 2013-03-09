using System;
namespace MobilePhone
{

    public enum BatteryType
    {
        Unknown, LiIon, NiMH, NiCd
    }

    class Battery
    {
        //Fields and Properties - Start.
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double hoursIdle;
        public double HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (value >= 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }

        private double hoursTalk;
        public double HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value >= 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }

        private BatteryType type;
        public BatteryType Type
        {
            get { return type; }
            set { type = value; }
        }
        //Fields and Properties - End.


        //Constructors - Start.
        public Battery(string model)
            : this(model, 0.0, 0.0, BatteryType.Unknown)
        {
        }

        public Battery(string model, double hoursIdle)
            : this(model, hoursIdle, 0.0, BatteryType.Unknown)
        {
        }

        public Battery(string model, double hoursIdle, double hoursTalk)
            : this(model, hoursIdle, hoursTalk, BatteryType.Unknown)
        {
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }
        //Constructors - End.

        public override string ToString()
        {
            return string.Format("\n\tBattery Model: {0}\n\tHours Idle: {1}\n\tTalk Hours: {2}\n\tBattery Type: {3}",
                model, hoursIdle, hoursTalk, type);
        }
    }
}
