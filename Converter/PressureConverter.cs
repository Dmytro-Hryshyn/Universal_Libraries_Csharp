using System.Collections;

namespace ModernUiDesign.Controls.Converter
{
    public class PressureConverter : IConverter
    {


        public decimal FromUnitValue { get; }

        public string FromUnitName { get; }

        public string ToUnitName { get; }

        public string ResultString { get; }

        public PressureConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
        {
            FromUnitValue = fromUnitValue;
            FromUnitName = fromUnitName;
            ToUnitName = toUnitName;
            ResultString = $"{FromUnitName}-{ToUnitName}";
        }

        public enum PressureUnit
        {
            Bar,
            Pascal,
            PSI,
            Atmosphere,
            Torr
        }

        public string GetUnswer()
        {
            Hashtable pressureHashtable = new Hashtable();
            //Bar to enother unit
            pressureHashtable.Add($"{PressureUnit.Bar}-{PressureUnit.Pascal}", FromUnitValue * 100000);
            pressureHashtable.Add($"{PressureUnit.Bar}-{PressureUnit.PSI}", FromUnitValue * 14.504m);
            pressureHashtable.Add($"{PressureUnit.Bar}-{PressureUnit.Atmosphere}", FromUnitValue / 1.013m);
            pressureHashtable.Add($"{PressureUnit.Bar}-{PressureUnit.Torr}", FromUnitValue * 750);

            //Pascal to enother unit
            pressureHashtable.Add($"{PressureUnit.Pascal}-{PressureUnit.Bar}", FromUnitValue / 100000);
            pressureHashtable.Add($"{PressureUnit.Pascal}-{PressureUnit.PSI}", FromUnitValue / 6895);
            pressureHashtable.Add($"{PressureUnit.Pascal}-{PressureUnit.Atmosphere}", FromUnitValue / 101325);
            pressureHashtable.Add($"{PressureUnit.Pascal}-{PressureUnit.Torr}", FromUnitValue / 133);

            //PSI to enother unit
            pressureHashtable.Add($"{PressureUnit.PSI}-{PressureUnit.Bar}", FromUnitValue / 14.504m);
            pressureHashtable.Add($"{PressureUnit.PSI}-{PressureUnit.Pascal}", FromUnitValue * 6895);
            pressureHashtable.Add($"{PressureUnit.PSI}-{PressureUnit.Atmosphere}", FromUnitValue / 14.696m);
            pressureHashtable.Add($"{PressureUnit.PSI}-{PressureUnit.Torr}", FromUnitValue * 51.715m);

            //Atmospher to another unit
            pressureHashtable.Add($"{PressureUnit.Atmosphere}-{PressureUnit.Bar}", FromUnitValue * 1.013m);
            pressureHashtable.Add($"{PressureUnit.Atmosphere}-{PressureUnit.Pascal}", FromUnitValue * 101325);
            pressureHashtable.Add($"{PressureUnit.Atmosphere}-{PressureUnit.Pascal}", FromUnitValue * 14.696m);
            pressureHashtable.Add($"{PressureUnit.Atmosphere}-{PressureUnit.Torr}", FromUnitValue * 51.715m);

            //Torr to enither unit
            pressureHashtable.Add($"{PressureUnit.Torr}-{PressureUnit.Bar}", FromUnitValue / 750);
            pressureHashtable.Add($"{PressureUnit.Torr}-{PressureUnit.Pascal}", FromUnitValue * 133);
            pressureHashtable.Add($"{PressureUnit.Torr}-{PressureUnit.PSI}", FromUnitValue / 51.715m);
            pressureHashtable.Add($"{PressureUnit.Torr}-{PressureUnit.Atmosphere}", FromUnitValue / 760);


            if (pressureHashtable.ContainsKey(ResultString))
            {
                return pressureHashtable[ResultString].ToString();
            }
            else
            {
                return "0.error";
            }

        }

        public decimal GetUnswer(ErrorCall error, string errorText)
        {
            Hashtable pressureHashtable = new Hashtable();
            //Bar to enother unit
            pressureHashtable.Add($"{PressureUnit.Bar}-{PressureUnit.Pascal}", FromUnitValue * 100000);
            pressureHashtable.Add($"{PressureUnit.Bar}-{PressureUnit.PSI}", FromUnitValue * 14.504m);
            pressureHashtable.Add($"{PressureUnit.Bar}-{PressureUnit.Atmosphere}", FromUnitValue / 1.013m);
            pressureHashtable.Add($"{PressureUnit.Bar}-{PressureUnit.Torr}", FromUnitValue * 750);

            //Pascal to enother unit
            pressureHashtable.Add($"{PressureUnit.Pascal}-{PressureUnit.Bar}", FromUnitValue / 100000);
            pressureHashtable.Add($"{PressureUnit.Pascal}-{PressureUnit.PSI}", FromUnitValue / 6895);
            pressureHashtable.Add($"{PressureUnit.Pascal}-{PressureUnit.Atmosphere}", FromUnitValue / 101325);
            pressureHashtable.Add($"{PressureUnit.Pascal}-{PressureUnit.Torr}", FromUnitValue / 133);

            //PSI to enother unit
            pressureHashtable.Add($"{PressureUnit.PSI}-{PressureUnit.Bar}", FromUnitValue / 14.504m);
            pressureHashtable.Add($"{PressureUnit.PSI}-{PressureUnit.Pascal}", FromUnitValue * 6895);
            pressureHashtable.Add($"{PressureUnit.PSI}-{PressureUnit.Atmosphere}", FromUnitValue / 14.696m);
            pressureHashtable.Add($"{PressureUnit.PSI}-{PressureUnit.Torr}", FromUnitValue * 51.715m);

            //Atmospher to another unit
            pressureHashtable.Add($"{PressureUnit.Atmosphere}-{PressureUnit.Bar}", FromUnitValue * 1.013m);
            pressureHashtable.Add($"{PressureUnit.Atmosphere}-{PressureUnit.Pascal}", FromUnitValue * 101325);
            pressureHashtable.Add($"{PressureUnit.Atmosphere}-{PressureUnit.PSI}", FromUnitValue * 14.696m);
            pressureHashtable.Add($"{PressureUnit.Atmosphere}-{PressureUnit.Torr}", FromUnitValue * 760);

            //Torr to enither unit
            pressureHashtable.Add($"{PressureUnit.Torr}-{PressureUnit.Bar}", FromUnitValue / 750);
            pressureHashtable.Add($"{PressureUnit.Torr}-{PressureUnit.Pascal}", FromUnitValue * 133.322m);
            pressureHashtable.Add($"{PressureUnit.Torr}-{PressureUnit.PSI}", FromUnitValue / 51.715m);
            pressureHashtable.Add($"{PressureUnit.Torr}-{PressureUnit.Atmosphere}", FromUnitValue / 760);


            if (pressureHashtable.ContainsKey(ResultString))
            {
                return (decimal)pressureHashtable[ResultString];
            }
            else
            {
                error?.Invoke(errorText);
                return 0;
            }

        }

    }
}
