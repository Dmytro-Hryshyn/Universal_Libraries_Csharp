using Forms.UnitConverter;
using System;
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
            ResultString = FromUnitName + "-" + toUnitName;
        }

      public  enum SpeedUnits
        {
            Mile_per_hour,
            Kilometre_per_hour,
            Feet_per_second,
            Metre_per_second,
            Knot
        }

        public string GetUnswer()
        {
            Hashtable speedTable = new Hashtable();
            //Mile per hour to enother Unit

            speedTable.Add($"{SpeedUnits.Mile_per_hour}-{SpeedUnits.Feet_per_second}",      FromUnitValue * 1.467m);
            speedTable.Add($"{SpeedUnits.Mile_per_hour}-{SpeedUnits.Metre_per_second}",     FromUnitValue / 2.237m);
            speedTable.Add($"{SpeedUnits.Mile_per_hour}-{SpeedUnits.Kilometre_per_hour}",   FromUnitValue * 1.609m);
            speedTable.Add($"{SpeedUnits.Mile_per_hour}-{SpeedUnits.Knot}",                 FromUnitValue / 1.151m);

            //Feet per second to another Unit
            speedTable.Add($"{SpeedUnits.Feet_per_second}-{SpeedUnits.Mile_per_hour}",      FromUnitValue / 1.467m);
            speedTable.Add($"{SpeedUnits.Feet_per_second}-{SpeedUnits.Metre_per_second}",   FromUnitValue / 3.281m);
            speedTable.Add($"{SpeedUnits.Feet_per_second}-{SpeedUnits.Kilometre_per_hour}", FromUnitValue * 1.097m);
            speedTable.Add($"{SpeedUnits.Feet_per_second}-{SpeedUnits.Knot}",               FromUnitValue / 1.688m);

            //Metre per second to enother Unit
            speedTable.Add($"{SpeedUnits.Metre_per_second}-{SpeedUnits.Mile_per_hour}",      FromUnitValue * 2.237m);
            speedTable.Add($"{SpeedUnits.Metre_per_second}-{SpeedUnits.Feet_per_second}",    FromUnitValue * 3.281m);
            speedTable.Add($"{SpeedUnits.Metre_per_second}-{SpeedUnits.Kilometre_per_hour}", FromUnitValue * 3.6m);
            speedTable.Add($"{SpeedUnits.Metre_per_second}-{SpeedUnits.Knot}",               FromUnitValue * 1.944m);


            //Kilometre per hour to enother Unit
            speedTable.Add($"{SpeedUnits.Kilometre_per_hour}-{SpeedUnits.Mile_per_hour}",    FromUnitValue / 1.609m);
            speedTable.Add($"{SpeedUnits.Kilometre_per_hour}-{SpeedUnits.Feet_per_second}",  FromUnitValue / 1.097m);
            speedTable.Add($"{SpeedUnits.Kilometre_per_hour}-{SpeedUnits.Metre_per_second}", FromUnitValue / 3.6m);
            speedTable.Add($"{SpeedUnits.Kilometre_per_hour}-{SpeedUnits.Knot}",             FromUnitValue / 1.852m);

            //Knot to enother Unit
            speedTable.Add($"{SpeedUnits.Knot}-{SpeedUnits.Mile_per_hour}",                  FromUnitValue * 1.151m);
            speedTable.Add($"{SpeedUnits.Knot}-{SpeedUnits.Feet_per_second}",                FromUnitValue * 1.688m);
            speedTable.Add($"{SpeedUnits.Knot}-{SpeedUnits.Metre_per_second}",               FromUnitValue / 1.944m);
            speedTable.Add($"{SpeedUnits.Knot}-{SpeedUnits.Kilometre_per_hour}",             FromUnitValue * 1.852m);


            if (speedTable.ContainsKey(ResultString))
            {
               return speedTable[ResultString].ToString();
            }
            else
            {
                return "0.error";
            }

          
                     

        }
    }
}
