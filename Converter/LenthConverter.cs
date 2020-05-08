using System.Collections;

namespace ModernUiDesign
{
    public class LenthConverter : IConverter
    {
        public decimal FromUnitValue { get; private set; } = 0;

        public string FromUnitName { get; private set; } = string.Empty;

        public string ToUnitName { get; private set; } = string.Empty;

        public string ResultString { get; private set; }

        public LenthConverter(decimal fromUnitValue, string fromUnitName, string toUnitName)
        {
            FromUnitValue = fromUnitValue;
            FromUnitName = fromUnitName;
            ToUnitName = toUnitName;
            ResultString = $"{fromUnitName}-{toUnitName}";
        }

        public enum LenthUnits

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
            Hashtable lenthTable = new Hashtable();

            //Kilometre to another unit
            lenthTable.Add($"{ LenthUnits.Kilometre }-{ LenthUnits.Metres }", FromUnitValue * 1000m);
            lenthTable.Add($"{ LenthUnits.Kilometre }-{ LenthUnits.Centimetres }", FromUnitValue * 100000m);
            lenthTable.Add($"{ LenthUnits.Kilometre }-{ LenthUnits.Millimetre }", FromUnitValue * 1e+6m);
            lenthTable.Add($"{ LenthUnits.Kilometre }-{ LenthUnits.Micrometre }", FromUnitValue * 1e+9m);
            lenthTable.Add($"{ LenthUnits.Kilometre }-{ LenthUnits.Nanometre }", FromUnitValue * 1e+12m);
            lenthTable.Add($"{ LenthUnits.Kilometre }-{ LenthUnits.Mile }", FromUnitValue / 1.609m);
            lenthTable.Add($"{ LenthUnits.Kilometre }-{ LenthUnits.Yard }", FromUnitValue * 1094m);
            lenthTable.Add($"{ LenthUnits.Kilometre }-{ LenthUnits.Foot }", FromUnitValue * 3280.84m);
            lenthTable.Add($"{ LenthUnits.Kilometre }-{ LenthUnits.Inch }", FromUnitValue * 39370.1m);
            lenthTable.Add($"{ LenthUnits.Kilometre }-{ LenthUnits.Nautical_mile }", FromUnitValue / 1.852m);

            //Metres to another unit
            lenthTable.Add($"{LenthUnits.Metres}-{LenthUnits.Kilometre}", FromUnitValue / 1000m);
            lenthTable.Add($"{LenthUnits.Metres}-{LenthUnits.Centimetres}", FromUnitValue * 100m);
            lenthTable.Add($"{LenthUnits.Metres}-{LenthUnits.Millimetre}", FromUnitValue * 1000m);
            lenthTable.Add($"{LenthUnits.Metres}-{LenthUnits.Micrometre}", FromUnitValue * 1e+6m);
            lenthTable.Add($"{LenthUnits.Metres}-{LenthUnits.Nanometre}", FromUnitValue * 1e+9m);
            lenthTable.Add($"{LenthUnits.Metres}-{LenthUnits.Mile}", FromUnitValue / 1609m);
            lenthTable.Add($"{LenthUnits.Metres}-{LenthUnits.Yard}", FromUnitValue * 1.094m);
            lenthTable.Add($"{LenthUnits.Metres}-{LenthUnits.Foot}", FromUnitValue * 3.281m);
            lenthTable.Add($"{LenthUnits.Metres}-{LenthUnits.Inch}", FromUnitValue * 39.37m);
            lenthTable.Add($"{LenthUnits.Metres}-{LenthUnits.Nautical_mile}", FromUnitValue / 1852m);

            //Centimetres to another unit
            lenthTable.Add($"{LenthUnits.Centimetres}-{LenthUnits.Kilometre}", FromUnitValue / 100000m);
            lenthTable.Add($"{LenthUnits.Centimetres}-{LenthUnits.Metres}", FromUnitValue / 100m);
            lenthTable.Add($"{LenthUnits.Centimetres}-{LenthUnits.Millimetre}", FromUnitValue * 10m);
            lenthTable.Add($"{LenthUnits.Centimetres}-{LenthUnits.Micrometre}", FromUnitValue * 10000m);
            lenthTable.Add($"{LenthUnits.Centimetres}-{LenthUnits.Nanometre}", FromUnitValue * 1e+7m);
            lenthTable.Add($"{LenthUnits.Centimetres}-{LenthUnits.Mile}", FromUnitValue / 160934m);
            lenthTable.Add($"{LenthUnits.Centimetres}-{LenthUnits.Yard}", FromUnitValue / 91.44m);
            lenthTable.Add($"{LenthUnits.Centimetres}-{LenthUnits.Foot}", FromUnitValue / 30.48m);
            lenthTable.Add($"{LenthUnits.Centimetres}-{LenthUnits.Inch}", FromUnitValue / 2.54m);
            lenthTable.Add($"{LenthUnits.Centimetres}-{LenthUnits.Nautical_mile}", FromUnitValue / 185200m);

            //Millimetre to enother unit
            lenthTable.Add($"{LenthUnits.Millimetre}-{LenthUnits.Kilometre}", FromUnitValue / 1e+6m);
            lenthTable.Add($"{LenthUnits.Millimetre}-{LenthUnits.Metres}", FromUnitValue / 1000m);
            lenthTable.Add($"{LenthUnits.Millimetre}-{LenthUnits.Centimetres}", FromUnitValue / 10m);
            lenthTable.Add($"{LenthUnits.Millimetre}-{LenthUnits.Micrometre}", FromUnitValue * 1000m);
            lenthTable.Add($"{LenthUnits.Millimetre}-{LenthUnits.Nanometre}", FromUnitValue * 1e+6m);
            lenthTable.Add($"{LenthUnits.Millimetre}-{LenthUnits.Mile}", FromUnitValue / 1.609e+6m);
            lenthTable.Add($"{LenthUnits.Millimetre}-{LenthUnits.Yard}", FromUnitValue / 914m);
            lenthTable.Add($"{LenthUnits.Millimetre}-{LenthUnits.Foot}", FromUnitValue / 305m);
            lenthTable.Add($"{LenthUnits.Millimetre}-{LenthUnits.Inch}", FromUnitValue / 25.4m);
            lenthTable.Add($"{LenthUnits.Millimetre}-{LenthUnits.Nautical_mile}", FromUnitValue / 1.852e+6m);

            //Micrometre to enother unit 
            lenthTable.Add($"{LenthUnits.Micrometre}-{LenthUnits.Kilometre}", FromUnitValue / 1e-9m);
            lenthTable.Add($"{LenthUnits.Micrometre}-{LenthUnits.Metres}", FromUnitValue / 1e-6m);
            lenthTable.Add($"{LenthUnits.Micrometre}-{LenthUnits.Centimetres}", FromUnitValue / 1e-4m);
            lenthTable.Add($"{LenthUnits.Micrometre}-{LenthUnits.Millimetre}", FromUnitValue / 1000m);
            lenthTable.Add($"{LenthUnits.Micrometre}-{LenthUnits.Nanometre}", FromUnitValue * 1000m);
            lenthTable.Add($"{LenthUnits.Micrometre}-{LenthUnits.Mile}", FromUnitValue / 1.609e+9m);
            lenthTable.Add($"{LenthUnits.Micrometre}-{LenthUnits.Yard}", FromUnitValue / 914400m);
            lenthTable.Add($"{LenthUnits.Micrometre}-{LenthUnits.Foot}", FromUnitValue / 304800m);
            lenthTable.Add($"{LenthUnits.Micrometre}-{LenthUnits.Inch}", FromUnitValue / 25400m);
            lenthTable.Add($"{LenthUnits.Micrometre}-{LenthUnits.Nautical_mile}", FromUnitValue / 1.852e+9m);

            //Nanometre to enother unit
            lenthTable.Add($"{LenthUnits.Nanometre}-{LenthUnits.Kilometre}", FromUnitValue / 1e+12m);
            lenthTable.Add($"{LenthUnits.Nanometre}-{LenthUnits.Metres}", FromUnitValue / 1e+9m);
            lenthTable.Add($"{LenthUnits.Nanometre}-{LenthUnits.Centimetres}", FromUnitValue / 1e+7m);
            lenthTable.Add($"{LenthUnits.Nanometre}-{LenthUnits.Millimetre}", FromUnitValue / 1e+6m);
            lenthTable.Add($"{LenthUnits.Nanometre}-{LenthUnits.Micrometre}", FromUnitValue / 1000m);
            lenthTable.Add($"{LenthUnits.Nanometre}-{LenthUnits.Mile}", FromUnitValue / 1.609e+12m);
            lenthTable.Add($"{LenthUnits.Nanometre}-{LenthUnits.Yard}", FromUnitValue / 9.144e+8m);
            lenthTable.Add($"{LenthUnits.Nanometre}-{LenthUnits.Foot}", FromUnitValue / 3.048e+8m);
            lenthTable.Add($"{LenthUnits.Nanometre}-{LenthUnits.Inch}", FromUnitValue / 2.54e+7m);
            lenthTable.Add($"{LenthUnits.Nanometre}-{LenthUnits.Nautical_mile}", FromUnitValue / 1.852e+12m);

            //Mile to enother unit
            lenthTable.Add($"{LenthUnits.Mile}-{LenthUnits.Kilometre}", FromUnitValue * 1.609m);
            lenthTable.Add($"{LenthUnits.Mile}-{LenthUnits.Metres}", FromUnitValue * 1609m);
            lenthTable.Add($"{LenthUnits.Mile}-{LenthUnits.Centimetres}", FromUnitValue * 160934m);
            lenthTable.Add($"{LenthUnits.Mile}-{LenthUnits.Millimetre}", FromUnitValue * 1.609e+6m);
            lenthTable.Add($"{LenthUnits.Mile}-{LenthUnits.Micrometre}", FromUnitValue * 1.609e+9m);
            lenthTable.Add($"{LenthUnits.Mile}-{LenthUnits.Nanometre}", FromUnitValue * 1.609e+12m);
            lenthTable.Add($"{LenthUnits.Mile}-{LenthUnits.Yard}", FromUnitValue * 1760m);
            lenthTable.Add($"{LenthUnits.Mile}-{LenthUnits.Foot}", FromUnitValue * 5280m);
            lenthTable.Add($"{LenthUnits.Mile}-{LenthUnits.Inch}", FromUnitValue * 63360m);
            lenthTable.Add($"{LenthUnits.Mile}-{LenthUnits.Nautical_mile}", FromUnitValue / 1.151m);

            //Yard to enother unit
            lenthTable.Add($"{LenthUnits.Yard}-{LenthUnits.Kilometre}", FromUnitValue / 1094m);
            lenthTable.Add($"{LenthUnits.Yard}-{LenthUnits.Metres}", FromUnitValue / 1.094m);
            lenthTable.Add($"{LenthUnits.Yard}-{LenthUnits.Centimetres}", FromUnitValue * 91.44m);
            lenthTable.Add($"{LenthUnits.Yard}-{LenthUnits.Millimetre}", FromUnitValue * 914.4m);
            lenthTable.Add($"{LenthUnits.Yard}-{LenthUnits.Micrometre}", FromUnitValue * 914400m);
            lenthTable.Add($"{LenthUnits.Yard}-{LenthUnits.Nanometre}", FromUnitValue * 9.144e+8m);
            lenthTable.Add($"{LenthUnits.Yard}-{LenthUnits.Mile}", FromUnitValue / 1760m);
            lenthTable.Add($"{LenthUnits.Yard}-{LenthUnits.Foot}", FromUnitValue * 3m);
            lenthTable.Add($"{LenthUnits.Yard}-{LenthUnits.Inch}", FromUnitValue * 36m);
            lenthTable.Add($"{LenthUnits.Yard}-{LenthUnits.Nautical_mile}", FromUnitValue / 2025m);

            //Foot to enother unit
            lenthTable.Add($"{LenthUnits.Foot}-{LenthUnits.Kilometre}", FromUnitValue / 3281m);
            lenthTable.Add($"{LenthUnits.Foot}-{LenthUnits.Metres}", FromUnitValue / 3.281m);
            lenthTable.Add($"{LenthUnits.Foot}-{LenthUnits.Centimetres}", FromUnitValue * 30.48m);
            lenthTable.Add($"{LenthUnits.Foot}-{LenthUnits.Millimetre}", FromUnitValue * 305m);
            lenthTable.Add($"{LenthUnits.Foot}-{LenthUnits.Micrometre}", FromUnitValue * 304800m);
            lenthTable.Add($"{LenthUnits.Foot}-{LenthUnits.Nanometre}", FromUnitValue * 3.048e+8m);
            lenthTable.Add($"{LenthUnits.Foot}-{LenthUnits.Mile}", FromUnitValue / 5280m);
            lenthTable.Add($"{LenthUnits.Foot}-{LenthUnits.Yard}", FromUnitValue / 3m);
            lenthTable.Add($"{LenthUnits.Foot}-{LenthUnits.Inch}", FromUnitValue * 12m);
            lenthTable.Add($"{LenthUnits.Foot}-{LenthUnits.Nautical_mile}", FromUnitValue / 6076m);

            //Inches to enother unit
            lenthTable.Add($"{LenthUnits.Inch}-{LenthUnits.Kilometre}", FromUnitValue / 39370m);
            lenthTable.Add($"{LenthUnits.Inch}-{LenthUnits.Metres}", FromUnitValue / 39.37m);
            lenthTable.Add($"{LenthUnits.Inch}-{LenthUnits.Centimetres}", FromUnitValue * 2.54m);
            lenthTable.Add($"{LenthUnits.Inch}-{LenthUnits.Millimetre}", FromUnitValue * 25.4m);
            lenthTable.Add($"{LenthUnits.Inch}-{LenthUnits.Micrometre}", FromUnitValue * 25400m);
            lenthTable.Add($"{LenthUnits.Inch}-{LenthUnits.Nanometre}", FromUnitValue * 2.54e+7m);
            lenthTable.Add($"{LenthUnits.Inch}-{LenthUnits.Mile}", FromUnitValue / 63360m);
            lenthTable.Add($"{LenthUnits.Inch}-{LenthUnits.Yard}", FromUnitValue / 36m);
            lenthTable.Add($"{LenthUnits.Inch}-{LenthUnits.Foot}", FromUnitValue / 12m);
            lenthTable.Add($"{LenthUnits.Inch}-{LenthUnits.Nautical_mile}", FromUnitValue / 72913m);

            //Nautical Mile to enother unit
            lenthTable.Add($"{LenthUnits.Nautical_mile}-{LenthUnits.Kilometre}", FromUnitValue * 1.852m);
            lenthTable.Add($"{LenthUnits.Nautical_mile}-{LenthUnits.Metres}", FromUnitValue * 1852m);
            lenthTable.Add($"{LenthUnits.Nautical_mile}-{LenthUnits.Centimetres}", FromUnitValue * 185200m);
            lenthTable.Add($"{LenthUnits.Nautical_mile}-{LenthUnits.Millimetre}", FromUnitValue * 1.852e+6m);
            lenthTable.Add($"{LenthUnits.Nautical_mile}-{LenthUnits.Micrometre}", FromUnitValue * 1.852e+9m);
            lenthTable.Add($"{LenthUnits.Nautical_mile}-{LenthUnits.Nanometre}", FromUnitValue * 1.852e+12m);
            lenthTable.Add($"{LenthUnits.Nautical_mile}-{LenthUnits.Mile}", FromUnitValue * 1.151m);
            lenthTable.Add($"{LenthUnits.Nautical_mile}-{LenthUnits.Yard}", FromUnitValue * 2025m);
            lenthTable.Add($"{LenthUnits.Nautical_mile}-{LenthUnits.Foot}", FromUnitValue * 6076m);
            lenthTable.Add($"{LenthUnits.Nautical_mile}-{LenthUnits.Inch}", FromUnitValue * 72913m);

            if (lenthTable.ContainsKey(ResultString))
            {
                return lenthTable[ResultString].ToString();
            }

            else
            {
                return "0.error";
            }
        }
    }
}
