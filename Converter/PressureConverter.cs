using System.Collections.Generic;

namespace Unit.Converter
{
    public class PressureConverter : BaseConverter, IConverter
    {
        public PressureConverter(decimal fromUnitValue, string fromUnit, string toUnit)
        {
            FromUnitValue = fromUnitValue;
            FromUnit = fromUnit;
            ToUnit = toUnit;
            FromUnit_ToUnit = $"{FromUnit}-{ToUnit}";
        }

        public enum PressureUnit
        {
            Bar,
            Pascal,
            PSI,
            Atmosphere,
            Torr
        }

        public decimal ConvertUnit()
        {
            var pressureDictinary = CreateDictinary();
            decimal keyIsMatched = 0;
            pressureDictinary.TryGetValue(FromUnit_ToUnit, out keyIsMatched);
            return keyIsMatched;
        }

        public Dictionary<string, decimal> CreateDictinary()
        {
            Dictionary<string, decimal> pressureDictinary = new Dictionary<string, decimal>();

            //Bar to enother unit
            pressureDictinary.Add($"{PressureUnit.Bar}-{PressureUnit.Pascal}", FromUnitValue * 100000);
            pressureDictinary.Add($"{PressureUnit.Bar}-{PressureUnit.PSI}", FromUnitValue * 14.504m);
            pressureDictinary.Add($"{PressureUnit.Bar}-{PressureUnit.Atmosphere}", FromUnitValue / 1.013m);
            pressureDictinary.Add($"{PressureUnit.Bar}-{PressureUnit.Torr}", FromUnitValue * 750);

            //Pascal to enother unit
            pressureDictinary.Add($"{PressureUnit.Pascal}-{PressureUnit.Bar}", FromUnitValue / 100000);
            pressureDictinary.Add($"{PressureUnit.Pascal}-{PressureUnit.PSI}", FromUnitValue / 6895);
            pressureDictinary.Add($"{PressureUnit.Pascal}-{PressureUnit.Atmosphere}", FromUnitValue / 101325);
            pressureDictinary.Add($"{PressureUnit.Pascal}-{PressureUnit.Torr}", FromUnitValue / 133);

            //PSI to enother unit
            pressureDictinary.Add($"{PressureUnit.PSI}-{PressureUnit.Bar}", FromUnitValue / 14.504m);
            pressureDictinary.Add($"{PressureUnit.PSI}-{PressureUnit.Pascal}", FromUnitValue * 6895);
            pressureDictinary.Add($"{PressureUnit.PSI}-{PressureUnit.Atmosphere}", FromUnitValue / 14.696m);
            pressureDictinary.Add($"{PressureUnit.PSI}-{PressureUnit.Torr}", FromUnitValue * 51.715m);

            //Atmospher to other unit
            pressureDictinary.Add($"{PressureUnit.Atmosphere}-{PressureUnit.Bar}", FromUnitValue * 1.013m);
            pressureDictinary.Add($"{PressureUnit.Atmosphere}-{PressureUnit.Pascal}", FromUnitValue * 101325);
            pressureDictinary.Add($"{PressureUnit.Atmosphere}-{PressureUnit.PSI}", FromUnitValue * 14.696m);
            pressureDictinary.Add($"{PressureUnit.Atmosphere}-{PressureUnit.Torr}", FromUnitValue * 760);

            //Torr to enither unit
            pressureDictinary.Add($"{PressureUnit.Torr}-{PressureUnit.Bar}", FromUnitValue / 750);
            pressureDictinary.Add($"{PressureUnit.Torr}-{PressureUnit.Pascal}", FromUnitValue * 133.322m);
            pressureDictinary.Add($"{PressureUnit.Torr}-{PressureUnit.PSI}", FromUnitValue / 51.715m);
            pressureDictinary.Add($"{PressureUnit.Torr}-{PressureUnit.Atmosphere}", FromUnitValue / 760);

            return pressureDictinary;
        }
    }
}
