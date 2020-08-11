using System;
using System.Collections.Generic;

namespace Unit.Converter
{
    public class AngleConverter : BaseConverter, IConverter
    {
        internal enum AngleUnit
        {
            Degree,
            Radian,
            Gradian
        }

        public AngleConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
        {
            FromUnitValue = fromUnitValue;
            FromUnit = fromUnitName;
            ToUnit = toUnitName;
            FromUnit_ToUnit = $"{fromUnitName}-{toUnitName}";
        }

        public decimal ConvertUnit()
        {
            var keyValuePairs = CreateDictinary();
            decimal keyExists = 0;
            keyValuePairs.TryGetValue(FromUnit_ToUnit, out keyExists);
            return keyExists;
        }

        public Dictionary<string, decimal> CreateDictinary()
        {
            Dictionary<string, decimal> angleDictinary = new Dictionary<string, decimal>();
            //Degree to other Unit
            angleDictinary.Add($"{AngleUnit.Degree}-{AngleUnit.Radian}", FromUnitValue * (decimal)(Math.PI / 180));
            angleDictinary.Add($"{AngleUnit.Degree}-{AngleUnit.Gradian}", FromUnitValue * (200m / 180m));
            //Radian to other unit
            angleDictinary.Add($"{AngleUnit.Radian}-{AngleUnit.Degree}", FromUnitValue * (decimal)(180 / Math.PI));
            angleDictinary.Add($"{AngleUnit.Radian}-{AngleUnit.Gradian}", FromUnitValue * (decimal)(200 / Math.PI));
            //Gradian to other unit
            angleDictinary.Add($"{AngleUnit.Gradian}-{AngleUnit.Degree}", FromUnitValue * (180m / 200m));
            angleDictinary.Add($"{AngleUnit.Gradian}-{AngleUnit.Radian}", FromUnitValue * (decimal)(Math.PI / 200));
            return angleDictinary;
        }
    }
}
