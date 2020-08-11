using System.Collections.Generic;

namespace Unit.Converter
{

    public class TemperatureConverter : BaseConverter, IConverter
    {

        public enum TemperatureUnit
        {
            Celsius,
            Fahrenheit,
            Kelvin,
        }

        public TemperatureConverter(decimal fromUnitValue, string fromUnit, string toUnit)
        {
            FromUnitValue = fromUnitValue;
            FromUnit = fromUnit;
            ToUnit = toUnit;
            FromUnit_ToUnit = $"{fromUnit}-{toUnit}";
        }

        public decimal ConvertUnit()
        {
            var keyValuePairs = CreateDictinary();
            decimal keyisMatched = 0;
            keyValuePairs.TryGetValue(FromUnit_ToUnit, out keyisMatched);
            return keyisMatched;
        }

        public Dictionary<string, decimal> CreateDictinary()
        {
            Dictionary<string, decimal> TemperatureDictinary = new Dictionary<string, decimal>();

            //Celsius to enother Unit
            TemperatureDictinary.Add($"{TemperatureUnit.Celsius}-{TemperatureUnit.Fahrenheit}", (FromUnitValue * 9 / 5) + 32);
            TemperatureDictinary.Add($"{TemperatureUnit.Celsius}-{TemperatureUnit.Kelvin}", FromUnitValue + 273.15m);

            //Kelvin to enother Unit
            TemperatureDictinary.Add($"{TemperatureUnit.Kelvin}-{TemperatureUnit.Celsius}", FromUnitValue - 273.15m);
            TemperatureDictinary.Add($"{TemperatureUnit.Kelvin}-{TemperatureUnit.Fahrenheit}", (FromUnitValue - 273.15m) * 9 / 5 + 32);

            //Fahrenheit to other Unit
            TemperatureDictinary.Add($"{TemperatureUnit.Fahrenheit}-{TemperatureUnit.Celsius}", (FromUnitValue - 32) * 5 / 9);
            TemperatureDictinary.Add($"{TemperatureUnit.Fahrenheit}-{TemperatureUnit.Kelvin}", (FromUnitValue - 32) * 5 / 9 + 273.15m);
            return TemperatureDictinary;
        }
    }
}

