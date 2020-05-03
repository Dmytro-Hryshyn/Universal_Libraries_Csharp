using System.Collections;

namespace ModernUiDesign
{


    public class SpeedConverter : IConverter
    {
        public decimal FromUnitValue { get; private set; }

        public string FromUnitName { get; private set; }

        public string ToUnitName { get; private set; }

        public string ResultString { get; private set; }

        public SpeedConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
        {
            FromUnitValue = fromUnitValue;
            FromUnitName = fromUnitName;
            ToUnitName = toUnitName;
            ResultString = FromUnitName + "_" + toUnitName;
        }

        // Mile per hour
        // Feet per second
        // Kilometre per hour
        // Knot

        public string GetUnswer()
        {
            Hashtable speedTable = new Hashtable();
            //Mile per hour to enother Unit
            speedTable.Add("Mile per hour_Feet per second", FromUnitValue * 1.467m);
            speedTable.Add("Mile per hour_Metre per second", FromUnitValue / 2.237m);
            speedTable.Add("Mile per hour_Kilometre per hour", FromUnitValue * 1.609m);
            speedTable.Add("Mile per hour_Knot", FromUnitValue / 1.151m);

            //Feet per second to another Unit
            speedTable.Add("Feet per second_Mile per hour", FromUnitValue / 1.467m);
            speedTable.Add("Feet per second_Metre per second", FromUnitValue / 3.281m);
            speedTable.Add("Feet per second_Kilometre per hour", FromUnitValue * 1.097m);
            speedTable.Add("Feet per second_Knot", FromUnitValue / 1.688m);

            //Metre per second to enother Unit
            speedTable.Add("Metre per second_Mile per hour", FromUnitValue * 2.237m);
            speedTable.Add("Metre per second_Feet per second", FromUnitValue * 3.281m);
            speedTable.Add("Metre per second_Kilometre per hour", FromUnitValue * 3.6m);
            speedTable.Add("Metre per second_Knot", FromUnitValue * 1.944m);

            //Kilometre per hour to enother Unit
            speedTable.Add("Kilometre per hour_Mile per hour", FromUnitValue / 1.609m);
            speedTable.Add("Kilometre per hour_Feet per second", FromUnitValue / 1.097m);
            speedTable.Add("Kilometre per hour_Metre per second", FromUnitValue / 3.6m);
            speedTable.Add("Kilometre per hour_Knot", FromUnitValue / 1.852m);

            //Knot to enother Unit
            speedTable.Add("Knot_Mile per hour", FromUnitValue * 1.151m);
            speedTable.Add("Knot_Feet per second", FromUnitValue * 1.688m);
            speedTable.Add("Knot_Metre per second", FromUnitValue / 1.944m);
            speedTable.Add("Knot_Kilometre per hour", FromUnitValue * 1.852m);


            //Chek is hash table contains a key
            if (speedTable.ContainsKey(ResultString))
            {
                return speedTable[ResultString].ToString();
            }
            else
            {
                return "0";
            }


        }

    }

}
