using System.Collections.Generic;

namespace Unit.Converter
{

    public class SpeedConverter : BaseConverter, IConverter
    {

        public SpeedConverter(decimal fromUnitValue, string fromUnit, string toUnit)
        {
            FromUnitValue = fromUnitValue;
            FromUnit = fromUnit;
            ToUnit = toUnit;
            FromUnit_ToUnit = $"{FromUnit}-{ToUnit}";
        }

        public enum SpeedUnits
        {
            Mile_per_hour,
            Kilometre_per_hour,
            Feet_per_second,
            Metre_per_second,
            Knot
        }

        public static Dictionary<string, string> NiceComboboxDataRepresentation()
        {
            Dictionary<string, string> speeUnitPairs = new Dictionary<string, string>();
            speeUnitPairs.Add("Mile per hour", $"{SpeedUnits.Mile_per_hour }");
            speeUnitPairs.Add("Kilometre per hour", $"{SpeedUnits.Kilometre_per_hour }");
            speeUnitPairs.Add("Feet per second", $"{SpeedUnits.Feet_per_second }");
            speeUnitPairs.Add("Metre per second", $"{SpeedUnits.Metre_per_second }");
            speeUnitPairs.Add("Knot", $"{SpeedUnits.Knot }");

            return speeUnitPairs;
        }

        public decimal ConvertUnit()
        {
            var speedDictinary = CreateDictinary();
            decimal keyIsMatched = 0;
            speedDictinary.TryGetValue(FromUnit_ToUnit, out keyIsMatched);
            return keyIsMatched;
        }

        public Dictionary<string, decimal> CreateDictinary()
        {
            Dictionary<string, decimal> speedDictinary = new Dictionary<string, decimal>();
            //Mile per hour to enother Unit

            speedDictinary.Add($"{SpeedUnits.Mile_per_hour}-{SpeedUnits.Feet_per_second}", FromUnitValue * 1.467m);
            speedDictinary.Add($"{SpeedUnits.Mile_per_hour}-{SpeedUnits.Metre_per_second}", FromUnitValue / 2.237m);
            speedDictinary.Add($"{SpeedUnits.Mile_per_hour}-{SpeedUnits.Kilometre_per_hour}", FromUnitValue * 1.609m);
            speedDictinary.Add($"{SpeedUnits.Mile_per_hour}-{SpeedUnits.Knot}", FromUnitValue / 1.151m);

            //Feet per second to other Unit
            speedDictinary.Add($"{SpeedUnits.Feet_per_second}-{SpeedUnits.Mile_per_hour}", FromUnitValue / 1.467m);
            speedDictinary.Add($"{SpeedUnits.Feet_per_second}-{SpeedUnits.Metre_per_second}", FromUnitValue / 3.281m);
            speedDictinary.Add($"{SpeedUnits.Feet_per_second}-{SpeedUnits.Kilometre_per_hour}", FromUnitValue * 1.097m);
            speedDictinary.Add($"{SpeedUnits.Feet_per_second}-{SpeedUnits.Knot}", FromUnitValue / 1.688m);

            //Metre per second to enother Unit
            speedDictinary.Add($"{SpeedUnits.Metre_per_second}-{SpeedUnits.Mile_per_hour}", FromUnitValue * 2.237m);
            speedDictinary.Add($"{SpeedUnits.Metre_per_second}-{SpeedUnits.Feet_per_second}", FromUnitValue * 3.281m);
            speedDictinary.Add($"{SpeedUnits.Metre_per_second}-{SpeedUnits.Kilometre_per_hour}", FromUnitValue * 3.6m);
            speedDictinary.Add($"{SpeedUnits.Metre_per_second}-{SpeedUnits.Knot}", FromUnitValue * 1.944m);


            //Kilometre per hour to enother Unit
            speedDictinary.Add($"{SpeedUnits.Kilometre_per_hour}-{SpeedUnits.Mile_per_hour}", FromUnitValue / 1.609m);
            speedDictinary.Add($"{SpeedUnits.Kilometre_per_hour}-{SpeedUnits.Feet_per_second}", FromUnitValue / 1.097m);
            speedDictinary.Add($"{SpeedUnits.Kilometre_per_hour}-{SpeedUnits.Metre_per_second}", FromUnitValue / 3.6m);
            speedDictinary.Add($"{SpeedUnits.Kilometre_per_hour}-{SpeedUnits.Knot}", FromUnitValue / 1.852m);

            //Knot to enother Unit
            speedDictinary.Add($"{SpeedUnits.Knot}-{SpeedUnits.Mile_per_hour}", FromUnitValue * 1.151m);
            speedDictinary.Add($"{SpeedUnits.Knot}-{SpeedUnits.Feet_per_second}", FromUnitValue * 1.688m);
            speedDictinary.Add($"{SpeedUnits.Knot}-{SpeedUnits.Metre_per_second}", FromUnitValue / 1.944m);
            speedDictinary.Add($"{SpeedUnits.Knot}-{SpeedUnits.Kilometre_per_hour}", FromUnitValue * 1.852m);

            return speedDictinary;
        }
    }
}
