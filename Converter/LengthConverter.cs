using System.Collections;

namespace ModernUiDesign
{
    public class LengthConverter : IConverter
    {
        public decimal FromUnitValue { get; private set; } = 0;

        public string FromUnitName { get; private set; } = string.Empty;

        public string ToUnitName { get; private set; } = string.Empty;

        public string ResultString { get; private set; }

        public LengthConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
        {
            FromUnitValue = fromUnitValue;
            FromUnitName = fromUnitName;
            ToUnitName = toUnitName;
            ResultString = $"{fromUnitName}-{toUnitName}";
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
        public string GetUnswer()
        {
            Hashtable lengthTable = new Hashtable();

            //Kilometre to another unit
            lengthTable.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Metres }", FromUnitValue * 1000m);
            lengthTable.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Centimetres }", FromUnitValue * 100000m);
            lengthTable.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Millimetre }", FromUnitValue * 1e+6m);
            lengthTable.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Micrometre }", FromUnitValue * 1e+9m);
            lengthTable.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Nanometre }", FromUnitValue * 1e+12m);
            lengthTable.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Mile }", FromUnitValue / 1.609m);
            lengthTable.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Yard }", FromUnitValue * 1094m);
            lengthTable.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Foot }", FromUnitValue * 3280.84m);
            lengthTable.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Inch }", FromUnitValue * 39370.1m);
            lengthTable.Add($"{ LengthUnits.Kilometre }-{ LengthUnits.Nautical_mile }", FromUnitValue / 1.852m);

            //Metres to another unit
            lengthTable.Add($"{LengthUnits.Metres}-{LengthUnits.Kilometre}", FromUnitValue / 1000m);
            lengthTable.Add($"{LengthUnits.Metres}-{LengthUnits.Centimetres}", FromUnitValue * 100m);
            lengthTable.Add($"{LengthUnits.Metres}-{LengthUnits.Millimetre}", FromUnitValue * 1000m);
            lengthTable.Add($"{LengthUnits.Metres}-{LengthUnits.Micrometre}", FromUnitValue * 1e+6m);
            lengthTable.Add($"{LengthUnits.Metres}-{LengthUnits.Nanometre}", FromUnitValue * 1e+9m);
            lengthTable.Add($"{LengthUnits.Metres}-{LengthUnits.Mile}", FromUnitValue / 1609m);
            lengthTable.Add($"{LengthUnits.Metres}-{LengthUnits.Yard}", FromUnitValue * 1.094m);
            lengthTable.Add($"{LengthUnits.Metres}-{LengthUnits.Foot}", FromUnitValue * 3.281m);
            lengthTable.Add($"{LengthUnits.Metres}-{LengthUnits.Inch}", FromUnitValue * 39.37m);
            lengthTable.Add($"{LengthUnits.Metres}-{LengthUnits.Nautical_mile}", FromUnitValue / 1852m);

            //Centimetres to another unit
            lengthTable.Add($"{LengthUnits.Centimetres}-{LengthUnits.Kilometre}", FromUnitValue / 100000m);
            lengthTable.Add($"{LengthUnits.Centimetres}-{LengthUnits.Metres}", FromUnitValue / 100m);
            lengthTable.Add($"{LengthUnits.Centimetres}-{LengthUnits.Millimetre}", FromUnitValue * 10m);
            lengthTable.Add($"{LengthUnits.Centimetres}-{LengthUnits.Micrometre}", FromUnitValue * 10000m);
            lengthTable.Add($"{LengthUnits.Centimetres}-{LengthUnits.Nanometre}", FromUnitValue * 1e+7m);
            lengthTable.Add($"{LengthUnits.Centimetres}-{LengthUnits.Mile}", FromUnitValue / 160934m);
            lengthTable.Add($"{LengthUnits.Centimetres}-{LengthUnits.Yard}", FromUnitValue / 91.44m);
            lengthTable.Add($"{LengthUnits.Centimetres}-{LengthUnits.Foot}", FromUnitValue / 30.48m);
            lengthTable.Add($"{LengthUnits.Centimetres}-{LengthUnits.Inch}", FromUnitValue / 2.54m);
            lengthTable.Add($"{LengthUnits.Centimetres}-{LengthUnits.Nautical_mile}", FromUnitValue / 185200m);

            //Millimetre to enother unit
            lengthTable.Add($"{LengthUnits.Millimetre}-{LengthUnits.Kilometre}", FromUnitValue / 1e+6m);
            lengthTable.Add($"{LengthUnits.Millimetre}-{LengthUnits.Metres}", FromUnitValue / 1000m);
            lengthTable.Add($"{LengthUnits.Millimetre}-{LengthUnits.Centimetres}", FromUnitValue / 10m);
            lengthTable.Add($"{LengthUnits.Millimetre}-{LengthUnits.Micrometre}", FromUnitValue * 1000m);
            lengthTable.Add($"{LengthUnits.Millimetre}-{LengthUnits.Nanometre}", FromUnitValue * 1e+6m);
            lengthTable.Add($"{LengthUnits.Millimetre}-{LengthUnits.Mile}", FromUnitValue / 1.609e+6m);
            lengthTable.Add($"{LengthUnits.Millimetre}-{LengthUnits.Yard}", FromUnitValue / 914m);
            lengthTable.Add($"{LengthUnits.Millimetre}-{LengthUnits.Foot}", FromUnitValue / 305m);
            lengthTable.Add($"{LengthUnits.Millimetre}-{LengthUnits.Inch}", FromUnitValue / 25.4m);
            lengthTable.Add($"{LengthUnits.Millimetre}-{LengthUnits.Nautical_mile}", FromUnitValue / 1.852e+6m);

            //Micrometre to enother unit 
            lengthTable.Add($"{LengthUnits.Micrometre}-{LengthUnits.Kilometre}", FromUnitValue / 1e-9m);
            lengthTable.Add($"{LengthUnits.Micrometre}-{LengthUnits.Metres}", FromUnitValue / 1e-6m);
            lengthTable.Add($"{LengthUnits.Micrometre}-{LengthUnits.Centimetres}", FromUnitValue / 1e-4m);
            lengthTable.Add($"{LengthUnits.Micrometre}-{LengthUnits.Millimetre}", FromUnitValue / 1000m);
            lengthTable.Add($"{LengthUnits.Micrometre}-{LengthUnits.Nanometre}", FromUnitValue * 1000m);
            lengthTable.Add($"{LengthUnits.Micrometre}-{LengthUnits.Mile}", FromUnitValue / 1.609e+9m);
            lengthTable.Add($"{LengthUnits.Micrometre}-{LengthUnits.Yard}", FromUnitValue / 914400m);
            lengthTable.Add($"{LengthUnits.Micrometre}-{LengthUnits.Foot}", FromUnitValue / 304800m);
            lengthTable.Add($"{LengthUnits.Micrometre}-{LengthUnits.Inch}", FromUnitValue / 25400m);
            lengthTable.Add($"{LengthUnits.Micrometre}-{LengthUnits.Nautical_mile}", FromUnitValue / 1.852e+9m);

            //Nanometre to enother unit
            lengthTable.Add($"{LengthUnits.Nanometre}-{LengthUnits.Kilometre}", FromUnitValue / 1e+12m);
            lengthTable.Add($"{LengthUnits.Nanometre}-{LengthUnits.Metres}", FromUnitValue / 1e+9m);
            lengthTable.Add($"{LengthUnits.Nanometre}-{LengthUnits.Centimetres}", FromUnitValue / 1e+7m);
            lengthTable.Add($"{LengthUnits.Nanometre}-{LengthUnits.Millimetre}", FromUnitValue / 1e+6m);
            lengthTable.Add($"{LengthUnits.Nanometre}-{LengthUnits.Micrometre}", FromUnitValue / 1000m);
            lengthTable.Add($"{LengthUnits.Nanometre}-{LengthUnits.Mile}", FromUnitValue / 1.609e+12m);
            lengthTable.Add($"{LengthUnits.Nanometre}-{LengthUnits.Yard}", FromUnitValue / 9.144e+8m);
            lengthTable.Add($"{LengthUnits.Nanometre}-{LengthUnits.Foot}", FromUnitValue / 3.048e+8m);
            lengthTable.Add($"{LengthUnits.Nanometre}-{LengthUnits.Inch}", FromUnitValue / 2.54e+7m);
            lengthTable.Add($"{LengthUnits.Nanometre}-{LengthUnits.Nautical_mile}", FromUnitValue / 1.852e+12m);

            //Mile to enother unit
            lengthTable.Add($"{LengthUnits.Mile}-{LengthUnits.Kilometre}", FromUnitValue * 1.609m);
            lengthTable.Add($"{LengthUnits.Mile}-{LengthUnits.Metres}", FromUnitValue * 1609m);
            lengthTable.Add($"{LengthUnits.Mile}-{LengthUnits.Centimetres}", FromUnitValue * 160934m);
            lengthTable.Add($"{LengthUnits.Mile}-{LengthUnits.Millimetre}", FromUnitValue * 1.609e+6m);
            lengthTable.Add($"{LengthUnits.Mile}-{LengthUnits.Micrometre}", FromUnitValue * 1.609e+9m);
            lengthTable.Add($"{LengthUnits.Mile}-{LengthUnits.Nanometre}", FromUnitValue * 1.609e+12m);
            lengthTable.Add($"{LengthUnits.Mile}-{LengthUnits.Yard}", FromUnitValue * 1760m);
            lengthTable.Add($"{LengthUnits.Mile}-{LengthUnits.Foot}", FromUnitValue * 5280m);
            lengthTable.Add($"{LengthUnits.Mile}-{LengthUnits.Inch}", FromUnitValue * 63360m);
            lengthTable.Add($"{LengthUnits.Mile}-{LengthUnits.Nautical_mile}", FromUnitValue / 1.151m);

            //Yard to enother unit
            lengthTable.Add($"{LengthUnits.Yard}-{LengthUnits.Kilometre}", FromUnitValue / 1094m);
            lengthTable.Add($"{LengthUnits.Yard}-{LengthUnits.Metres}", FromUnitValue / 1.094m);
            lengthTable.Add($"{LengthUnits.Yard}-{LengthUnits.Centimetres}", FromUnitValue * 91.44m);
            lengthTable.Add($"{LengthUnits.Yard}-{LengthUnits.Millimetre}", FromUnitValue * 914.4m);
            lengthTable.Add($"{LengthUnits.Yard}-{LengthUnits.Micrometre}", FromUnitValue * 914400m);
            lengthTable.Add($"{LengthUnits.Yard}-{LengthUnits.Nanometre}", FromUnitValue * 9.144e+8m);
            lengthTable.Add($"{LengthUnits.Yard}-{LengthUnits.Mile}", FromUnitValue / 1760m);
            lengthTable.Add($"{LengthUnits.Yard}-{LengthUnits.Foot}", FromUnitValue * 3m);
            lengthTable.Add($"{LengthUnits.Yard}-{LengthUnits.Inch}", FromUnitValue * 36m);
            lengthTable.Add($"{LengthUnits.Yard}-{LengthUnits.Nautical_mile}", FromUnitValue / 2025m);

            //Foot to enother unit
            lengthTable.Add($"{LengthUnits.Foot}-{LengthUnits.Kilometre}", FromUnitValue / 3281m);
            lengthTable.Add($"{LengthUnits.Foot}-{LengthUnits.Metres}", FromUnitValue / 3.281m);
            lengthTable.Add($"{LengthUnits.Foot}-{LengthUnits.Centimetres}", FromUnitValue * 30.48m);
            lengthTable.Add($"{LengthUnits.Foot}-{LengthUnits.Millimetre}", FromUnitValue * 305m);
            lengthTable.Add($"{LengthUnits.Foot}-{LengthUnits.Micrometre}", FromUnitValue * 304800m);
            lengthTable.Add($"{LengthUnits.Foot}-{LengthUnits.Nanometre}", FromUnitValue * 3.048e+8m);
            lengthTable.Add($"{LengthUnits.Foot}-{LengthUnits.Mile}", FromUnitValue / 5280m);
            lengthTable.Add($"{LengthUnits.Foot}-{LengthUnits.Yard}", FromUnitValue / 3m);
            lengthTable.Add($"{LengthUnits.Foot}-{LengthUnits.Inch}", FromUnitValue * 12m);
            lengthTable.Add($"{LengthUnits.Foot}-{LengthUnits.Nautical_mile}", FromUnitValue / 6076m);

            //Inches to enother unit
            lengthTable.Add($"{LengthUnits.Inch}-{LengthUnits.Kilometre}", FromUnitValue / 39370m);
            lengthTable.Add($"{LengthUnits.Inch}-{LengthUnits.Metres}", FromUnitValue / 39.37m);
            lengthTable.Add($"{LengthUnits.Inch}-{LengthUnits.Centimetres}", FromUnitValue * 2.54m);
            lengthTable.Add($"{LengthUnits.Inch}-{LengthUnits.Millimetre}", FromUnitValue * 25.4m);
            lengthTable.Add($"{LengthUnits.Inch}-{LengthUnits.Micrometre}", FromUnitValue * 25400m);
            lengthTable.Add($"{LengthUnits.Inch}-{LengthUnits.Nanometre}", FromUnitValue * 2.54e+7m);
            lengthTable.Add($"{LengthUnits.Inch}-{LengthUnits.Mile}", FromUnitValue / 63360m);
            lengthTable.Add($"{LengthUnits.Inch}-{LengthUnits.Yard}", FromUnitValue / 36m);
            lengthTable.Add($"{LengthUnits.Inch}-{LengthUnits.Foot}", FromUnitValue / 12m);
            lengthTable.Add($"{LengthUnits.Inch}-{LengthUnits.Nautical_mile}", FromUnitValue / 72913m);

            //Nautical Mile to enother unit
            lengthTable.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Kilometre}", FromUnitValue * 1.852m);
            lengthTable.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Metres}", FromUnitValue * 1852m);
            lengthTable.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Centimetres}", FromUnitValue * 185200m);
            lengthTable.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Millimetre}", FromUnitValue * 1.852e+6m);
            lengthTable.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Micrometre}", FromUnitValue * 1.852e+9m);
            lengthTable.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Nanometre}", FromUnitValue * 1.852e+12m);
            lengthTable.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Mile}", FromUnitValue * 1.151m);
            lengthTable.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Yard}", FromUnitValue * 2025m);
            lengthTable.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Foot}", FromUnitValue * 6076m);
            lengthTable.Add($"{LengthUnits.Nautical_mile}-{LengthUnits.Inch}", FromUnitValue * 72913m);

            if (lengthTable.ContainsKey(ResultString))
            {
                return lengthTable[ResultString].ToString();
            }

            else
            {
                return "0.error";
            }
        }
    }
}
