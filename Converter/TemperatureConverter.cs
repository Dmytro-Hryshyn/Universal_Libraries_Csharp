using System;
using System.Collections;


namespace ModernUiDesign.Controls.Converter
{
    public delegate void ErrorCall(string errormess);

    public class TemperatureConverter : IConverter
    {

        public decimal FromUnitValue { get; }
        public string FromUnitName { get; }
        public string ToUnitName { get; }
        public string ResultString { get; }

        public enum TemperatureUnit
        {
            Celsius,
            Fahrenheit,
            Kelvin,

        }

        public TemperatureConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
        {
            FromUnitValue = fromUnitValue;
            FromUnitName = fromUnitName;
            ToUnitName = toUnitName;
            ResultString = $"{fromUnitName}-{toUnitName}";
        }

        public string GetUnswer()
        {
            throw new NotImplementedException();
        }
        public string GetUnswer(ErrorCall error, string errormess)
        {
            Hashtable TemperatureHash = new Hashtable();

            //Celsius to enother Unit
            TemperatureHash.Add($"{TemperatureUnit.Celsius}-{TemperatureUnit.Fahrenheit}", (FromUnitValue * 9 / 5) + 32);
            TemperatureHash.Add($"{TemperatureUnit.Celsius}-{TemperatureUnit.Kelvin}", FromUnitValue + 273.15m);

            //Kelvin to enother Unit
            TemperatureHash.Add($"{TemperatureUnit.Kelvin}-{TemperatureUnit.Celsius}", FromUnitValue - 273.15m);
            TemperatureHash.Add($"{TemperatureUnit.Kelvin}-{TemperatureUnit.Fahrenheit}", (FromUnitValue - 273.15m) * 9 / 5 + 32);

            //Fahrenheit to another Unit
            TemperatureHash.Add($"{TemperatureUnit.Fahrenheit}-{TemperatureUnit.Celsius}", (FromUnitValue - 32)*5/9);
            TemperatureHash.Add($"{TemperatureUnit.Fahrenheit}-{TemperatureUnit.Kelvin}", (FromUnitValue - 32) * 5/9 + 273.15m);


            if (TemperatureHash.ContainsKey(ResultString))
            {
                return TemperatureHash[ResultString].ToString();
            }
            else
            {
                error?.Invoke(errormess);
                return string.Empty;
            }
        }
    }


}

