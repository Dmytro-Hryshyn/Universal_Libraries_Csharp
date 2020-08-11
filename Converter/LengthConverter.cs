using System.Collections.Generic;

namespace Unit.Converter
{
    public class LengthConverter : BaseConverter, IConverter
    {

        public LengthConverter(decimal fromUnitValue, string fromUnit, string toUnit)
        {
            FromUnitValue = fromUnitValue;
            FromUnit = fromUnit;
            ToUnit = toUnit;
            FromUnit_ToUnit = $"{FromUnit}-{ToUnit}";
        }

        public enum LengthUnits
        {
            Kilometre,
            Metres,
            Centimetres,
            Millimetre,
            Micrometre,
            Nanometre,
            Mile,
            Yard,
            Foot,
            Inch,
            Nautical_mile
        }

        public static Dictionary<string, string> NiceComboboxDataRepresentation()
        {
            Dictionary<string, string> lengthPairs = new Dictionary<string, string>();
            lengthPairs.Add("Kilometre", $"{LengthUnits.Kilometre}");
            lengthPairs.Add("Metres", $"{LengthUnits.Metres}");
            lengthPairs.Add("Centimetres", $"{LengthUnits.Centimetres}");
            lengthPairs.Add("Millimetre", $"{LengthUnits.Millimetre}");
            lengthPairs.Add("Micrometre", $"{LengthUnits.Micrometre}");
            lengthPairs.Add("Nanometre", $"{LengthUnits.Nanometre}");
            lengthPairs.Add("Mile", $"{LengthUnits.Mile}");
            lengthPairs.Add("Yard", $"{LengthUnits.Yard}");
            lengthPairs.Add("Foot", $"{LengthUnits.Foot}");
            lengthPairs.Add("Inch", $"{LengthUnits.Inch}");
            lengthPairs.Add("Nautical mile", $"{LengthUnits.Nautical_mile}");
            return lengthPairs;
        }

        public decimal ConvertUnit()
        {
            var speeddictinary = CreateDictinary();
            decimal keyIsMatched = 0;
            speeddictinary.TryGetValue(FromUnit_ToUnit, out keyIsMatched);
            return keyIsMatched;
        }

        public Dictionary<string, decimal> CreateDictinary()
        {
            Dictionary<string, decimal> lengthDictinary = new Dictionary<string, decimal>();

            //Kilometre to other unit
            lengthDictinary.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Metres }", FromUnitValue * 1000m);
            lengthDictinary.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Centimetres }", FromUnitValue * 100000m);
            lengthDictinary.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Millimetre }", FromUnitValue * 1e+6m);
            lengthDictinary.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Micrometre }", FromUnitValue * 1e+9m);
            lengthDictinary.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Nanometre }", FromUnitValue * 1e+12m);
            lengthDictinary.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Mile }", FromUnitValue / 1.609m);
            lengthDictinary.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Yard }", FromUnitValue * 1094m);
            lengthDictinary.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Foot }", FromUnitValue * 3280.84m);
            lengthDictinary.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Inch }", FromUnitValue * 39370.1m);
            lengthDictinary.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Nautical_mile }", FromUnitValue / 1.852m);

            //Metres to other unit
            lengthDictinary.Add($"{LengthUnits.Metres}-{LengthUnits.Kilometre}", FromUnitValue / 1000m);
            lengthDictinary.Add($"{LengthUnits.Metres}-{LengthUnits.Centimetres}", FromUnitValue * 100m);
            lengthDictinary.Add($"{LengthUnits.Metres}-{LengthUnits.Millimetre}", FromUnitValue * 1000m);
            lengthDictinary.Add($"{LengthUnits.Metres}-{LengthUnits.Micrometre}", FromUnitValue * 1e+6m);
            lengthDictinary.Add($"{LengthUnits.Metres}-{LengthUnits.Nanometre}", FromUnitValue * 1e+9m);
            lengthDictinary.Add($"{LengthUnits.Metres}-{LengthUnits.Mile}", FromUnitValue / 1609m);
            lengthDictinary.Add($"{LengthUnits.Metres}-{LengthUnits.Yard}", FromUnitValue * 1.094m);
            lengthDictinary.Add($"{LengthUnits.Metres}-{LengthUnits.Foot}", FromUnitValue * 3.281m);
            lengthDictinary.Add($"{LengthUnits.Metres}-{LengthUnits.Inch}", FromUnitValue * 39.37m);
            lengthDictinary.Add($"{LengthUnits.Metres}-{LengthUnits.Nautical_mile}", FromUnitValue / 1852m);

            //Centimetres to other unit
            lengthDictinary.Add($"{LengthUnits.Centimetres}-{LengthUnits.Kilometre}", FromUnitValue / 100000m);
            lengthDictinary.Add($"{LengthUnits.Centimetres}-{LengthUnits.Metres}", FromUnitValue / 100m);
            lengthDictinary.Add($"{LengthUnits.Centimetres}-{LengthUnits.Millimetre}", FromUnitValue * 10m);
            lengthDictinary.Add($"{LengthUnits.Centimetres}-{LengthUnits.Micrometre}", FromUnitValue * 10000m);
            lengthDictinary.Add($"{LengthUnits.Centimetres}-{LengthUnits.Nanometre}", FromUnitValue * 1e+7m);
            lengthDictinary.Add($"{LengthUnits.Centimetres}-{LengthUnits.Mile}", FromUnitValue / 160934m);
            lengthDictinary.Add($"{LengthUnits.Centimetres}-{LengthUnits.Yard}", FromUnitValue / 91.44m);
            lengthDictinary.Add($"{LengthUnits.Centimetres}-{LengthUnits.Foot}", FromUnitValue / 30.48m);
            lengthDictinary.Add($"{LengthUnits.Centimetres}-{LengthUnits.Inch}", FromUnitValue / 2.54m);
            lengthDictinary.Add($"{LengthUnits.Centimetres}-{LengthUnits.Nautical_mile}", FromUnitValue / 185200m);

            //Millimetre to enother unit
            lengthDictinary.Add($"{LengthUnits.Millimetre}-{LengthUnits.Kilometre}", FromUnitValue / 1e+6m);
            lengthDictinary.Add($"{LengthUnits.Millimetre}-{LengthUnits.Metres}", FromUnitValue / 1000m);
            lengthDictinary.Add($"{LengthUnits.Millimetre}-{LengthUnits.Centimetres}", FromUnitValue / 10m);
            lengthDictinary.Add($"{LengthUnits.Millimetre}-{LengthUnits.Micrometre}", FromUnitValue * 1000m);
            lengthDictinary.Add($"{LengthUnits.Millimetre}-{LengthUnits.Nanometre}", FromUnitValue * 1e+6m);
            lengthDictinary.Add($"{LengthUnits.Millimetre}-{LengthUnits.Mile}", FromUnitValue / 1.609e+6m);
            lengthDictinary.Add($"{LengthUnits.Millimetre}-{LengthUnits.Yard}", FromUnitValue / 914m);
            lengthDictinary.Add($"{LengthUnits.Millimetre}-{LengthUnits.Foot}", FromUnitValue / 305m);
            lengthDictinary.Add($"{LengthUnits.Millimetre}-{LengthUnits.Inch}", FromUnitValue / 25.4m);
            lengthDictinary.Add($"{LengthUnits.Millimetre}-{LengthUnits.Nautical_mile}", FromUnitValue / 1.852e+6m);

            //Micrometre to enother unit 
            lengthDictinary.Add($"{LengthUnits.Micrometre}-{LengthUnits.Kilometre}", FromUnitValue / 1e-9m);
            lengthDictinary.Add($"{LengthUnits.Micrometre}-{LengthUnits.Metres}", FromUnitValue / 1e-6m);
            lengthDictinary.Add($"{LengthUnits.Micrometre}-{LengthUnits.Centimetres}", FromUnitValue / 1e-4m);
            lengthDictinary.Add($"{LengthUnits.Micrometre}-{LengthUnits.Millimetre}", FromUnitValue / 1000m);
            lengthDictinary.Add($"{LengthUnits.Micrometre}-{LengthUnits.Nanometre}", FromUnitValue * 1000m);
            lengthDictinary.Add($"{LengthUnits.Micrometre}-{LengthUnits.Mile}", FromUnitValue / 1.609e+9m);
            lengthDictinary.Add($"{LengthUnits.Micrometre}-{LengthUnits.Yard}", FromUnitValue / 914400m);
            lengthDictinary.Add($"{LengthUnits.Micrometre}-{LengthUnits.Foot}", FromUnitValue / 304800m);
            lengthDictinary.Add($"{LengthUnits.Micrometre}-{LengthUnits.Inch}", FromUnitValue / 25400m);
            lengthDictinary.Add($"{LengthUnits.Micrometre}-{LengthUnits.Nautical_mile}", FromUnitValue / 1.852e+9m);

            //Nanometre to enother unit
            lengthDictinary.Add($"{LengthUnits.Nanometre}-{LengthUnits.Kilometre}", FromUnitValue / 1e+12m);
            lengthDictinary.Add($"{LengthUnits.Nanometre}-{LengthUnits.Metres}", FromUnitValue / 1e+9m);
            lengthDictinary.Add($"{LengthUnits.Nanometre}-{LengthUnits.Centimetres}", FromUnitValue / 1e+7m);
            lengthDictinary.Add($"{LengthUnits.Nanometre}-{LengthUnits.Millimetre}", FromUnitValue / 1e+6m);
            lengthDictinary.Add($"{LengthUnits.Nanometre}-{LengthUnits.Micrometre}", FromUnitValue / 1000m);
            lengthDictinary.Add($"{LengthUnits.Nanometre}-{LengthUnits.Mile}", FromUnitValue / 1.609e+12m);
            lengthDictinary.Add($"{LengthUnits.Nanometre}-{LengthUnits.Yard}", FromUnitValue / 9.144e+8m);
            lengthDictinary.Add($"{LengthUnits.Nanometre}-{LengthUnits.Foot}", FromUnitValue / 3.048e+8m);
            lengthDictinary.Add($"{LengthUnits.Nanometre}-{LengthUnits.Inch}", FromUnitValue / 2.54e+7m);
            lengthDictinary.Add($"{LengthUnits.Nanometre}-{LengthUnits.Nautical_mile}", FromUnitValue / 1.852e+12m);

            //Mile to enother unit
            lengthDictinary.Add($"{LengthUnits.Mile}-{LengthUnits.Kilometre}", FromUnitValue * 1.609m);
            lengthDictinary.Add($"{LengthUnits.Mile}-{LengthUnits.Metres}", FromUnitValue * 1609m);
            lengthDictinary.Add($"{LengthUnits.Mile}-{LengthUnits.Centimetres}", FromUnitValue * 160934m);
            lengthDictinary.Add($"{LengthUnits.Mile}-{LengthUnits.Millimetre}", FromUnitValue * 1.609e+6m);
            lengthDictinary.Add($"{LengthUnits.Mile}-{LengthUnits.Micrometre}", FromUnitValue * 1.609e+9m);
            lengthDictinary.Add($"{LengthUnits.Mile}-{LengthUnits.Nanometre}", FromUnitValue * 1.609e+12m);
            lengthDictinary.Add($"{LengthUnits.Mile}-{LengthUnits.Yard}", FromUnitValue * 1760m);
            lengthDictinary.Add($"{LengthUnits.Mile}-{LengthUnits.Foot}", FromUnitValue * 5280m);
            lengthDictinary.Add($"{LengthUnits.Mile}-{LengthUnits.Inch}", FromUnitValue * 63360m);
            lengthDictinary.Add($"{LengthUnits.Mile}-{LengthUnits.Nautical_mile}", FromUnitValue / 1.151m);

            //Yard to enother unit
            lengthDictinary.Add($"{LengthUnits.Yard}-{LengthUnits.Kilometre}", FromUnitValue / 1094m);
            lengthDictinary.Add($"{LengthUnits.Yard}-{LengthUnits.Metres}", FromUnitValue / 1.094m);
            lengthDictinary.Add($"{LengthUnits.Yard}-{LengthUnits.Centimetres}", FromUnitValue * 91.44m);
            lengthDictinary.Add($"{LengthUnits.Yard}-{LengthUnits.Millimetre}", FromUnitValue * 914.4m);
            lengthDictinary.Add($"{LengthUnits.Yard}-{LengthUnits.Micrometre}", FromUnitValue * 914400m);
            lengthDictinary.Add($"{LengthUnits.Yard}-{LengthUnits.Nanometre}", FromUnitValue * 9.144e+8m);
            lengthDictinary.Add($"{LengthUnits.Yard}-{LengthUnits.Mile}", FromUnitValue / 1760m);
            lengthDictinary.Add($"{LengthUnits.Yard}-{LengthUnits.Foot}", FromUnitValue * 3m);
            lengthDictinary.Add($"{LengthUnits.Yard}-{LengthUnits.Inch}", FromUnitValue * 36m);
            lengthDictinary.Add($"{LengthUnits.Yard}-{LengthUnits.Nautical_mile}", FromUnitValue / 2025m);

            //Foot to enother unit
            lengthDictinary.Add($"{LengthUnits.Foot}-{LengthUnits.Kilometre}", FromUnitValue / 3281m);
            lengthDictinary.Add($"{LengthUnits.Foot}-{LengthUnits.Metres}", FromUnitValue / 3.281m);
            lengthDictinary.Add($"{LengthUnits.Foot}-{LengthUnits.Centimetres}", FromUnitValue * 30.48m);
            lengthDictinary.Add($"{LengthUnits.Foot}-{LengthUnits.Millimetre}", FromUnitValue * 305m);
            lengthDictinary.Add($"{LengthUnits.Foot}-{LengthUnits.Micrometre}", FromUnitValue * 304800m);
            lengthDictinary.Add($"{LengthUnits.Foot}-{LengthUnits.Nanometre}", FromUnitValue * 3.048e+8m);
            lengthDictinary.Add($"{LengthUnits.Foot}-{LengthUnits.Mile}", FromUnitValue / 5280m);
            lengthDictinary.Add($"{LengthUnits.Foot}-{LengthUnits.Yard}", FromUnitValue / 3m);
            lengthDictinary.Add($"{LengthUnits.Foot}-{LengthUnits.Inch}", FromUnitValue * 12m);
            lengthDictinary.Add($"{LengthUnits.Foot}-{LengthUnits.Nautical_mile}", FromUnitValue / 6076m);

            //Inches to enother unit
            lengthDictinary.Add($"{LengthUnits.Inch}-{LengthUnits.Kilometre}", FromUnitValue / 39370m);
            lengthDictinary.Add($"{LengthUnits.Inch}-{LengthUnits.Metres}", FromUnitValue / 39.37m);
            lengthDictinary.Add($"{LengthUnits.Inch}-{LengthUnits.Centimetres}", FromUnitValue * 2.54m);
            lengthDictinary.Add($"{LengthUnits.Inch}-{LengthUnits.Millimetre}", FromUnitValue * 25.4m);
            lengthDictinary.Add($"{LengthUnits.Inch}-{LengthUnits.Micrometre}", FromUnitValue * 25400m);
            lengthDictinary.Add($"{LengthUnits.Inch}-{LengthUnits.Nanometre}", FromUnitValue * 2.54e+7m);
            lengthDictinary.Add($"{LengthUnits.Inch}-{LengthUnits.Mile}", FromUnitValue / 63360m);
            lengthDictinary.Add($"{LengthUnits.Inch}-{LengthUnits.Yard}", FromUnitValue / 36m);
            lengthDictinary.Add($"{LengthUnits.Inch}-{LengthUnits.Foot}", FromUnitValue / 12m);
            lengthDictinary.Add($"{LengthUnits.Inch}-{LengthUnits.Nautical_mile}", FromUnitValue / 72913m);

            //Nautical Mile to enother unit
            lengthDictinary.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Kilometre}", FromUnitValue * 1.852m);
            lengthDictinary.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Metres}", FromUnitValue * 1852m);
            lengthDictinary.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Centimetres}", FromUnitValue * 185200m);
            lengthDictinary.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Millimetre}", FromUnitValue * 1.852e+6m);
            lengthDictinary.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Micrometre}", FromUnitValue * 1.852e+9m);
            lengthDictinary.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Nanometre}", FromUnitValue * 1.852e+12m);
            lengthDictinary.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Mile}", FromUnitValue * 1.151m);
            lengthDictinary.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Yard}", FromUnitValue * 2025m);
            lengthDictinary.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Foot}", FromUnitValue * 6076m);
            lengthDictinary.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Inch}", FromUnitValue * 72913m);

            return lengthDictinary;
        }
    }
}
