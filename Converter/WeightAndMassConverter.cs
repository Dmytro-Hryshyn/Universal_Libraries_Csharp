using System.Collections;
using System.Collections.Generic;

namespace Unit.Converter
{
    public class WeightAndMassConverter : BaseConverter , IConverter
    {
       
        enum WeightAndMassUnit
        {
            Tonne,
            Kilogram,
            Gram,
            Milligram,
            Microgram,
            Imperial_ton,
            US_ton,
            Stone,
            Pound,
            Ounce
        }


        public static Dictionary<string, string> NiceComboboxData()
        {
            var WeightAndMassDictinary = new Dictionary<string, string>()
            {
                {"Tonne",$"{WeightAndMassUnit.Tonne}" },
                {"Kilogram",$"{WeightAndMassUnit.Kilogram}" },
                {"Gram",$"{WeightAndMassUnit.Gram}" },
                {"Milligram",$"{WeightAndMassUnit.Milligram}" },
                {"Microgram",$"{WeightAndMassUnit.Microgram}" },
                {"Imperial ton",$"{WeightAndMassUnit.Imperial_ton}" },
                {"US ton",$"{WeightAndMassUnit.US_ton}" },
                {"Stone",$"{WeightAndMassUnit.Stone}" },
                {"Pound",$"{WeightAndMassUnit.Pound}" },
                {"Ounce",$"{WeightAndMassUnit.Ounce}" },
            };

            return WeightAndMassDictinary;
        }

        public WeightAndMassConverter(decimal fromUnitValue, string fromUnit, string toUnit)
        {
            FromUnitValue = fromUnitValue;
            FromUnit = fromUnit.Replace(" ", "_");
            ToUnit = toUnit.Replace(" ", "_");
            FromUnit_ToUnit = $"{FromUnit}-{ToUnit}";
        }


       
       public Dictionary<string,decimal> CreateDictinary()
        {
            Dictionary<string,decimal> UnitPairs = new Dictionary<string, decimal>()
            {
                // Tonne to others unit
                {$"{WeightAndMassUnit.Tonne}-{WeightAndMassUnit.Kilogram}", FromUnitValue * 1000 },
                {$"{WeightAndMassUnit.Tonne}-{WeightAndMassUnit.Gram}", FromUnitValue * 1e+6m },
                {$"{WeightAndMassUnit.Tonne}-{WeightAndMassUnit.Milligram}", FromUnitValue * 1e+9m },
                {$"{WeightAndMassUnit.Tonne}-{WeightAndMassUnit.Microgram}", FromUnitValue * 1e+12m },
                {$"{WeightAndMassUnit.Tonne}-{WeightAndMassUnit.Imperial_ton}", FromUnitValue / 1.016m },
                {$"{WeightAndMassUnit.Tonne}-{WeightAndMassUnit.US_ton}", FromUnitValue * 1.102m },
                {$"{WeightAndMassUnit.Tonne}-{WeightAndMassUnit.Stone}", FromUnitValue * 157 },
                {$"{WeightAndMassUnit.Tonne}-{WeightAndMassUnit.Pound}", FromUnitValue * 2205 },
                {$"{WeightAndMassUnit.Tonne}-{WeightAndMassUnit.Ounce}", FromUnitValue * 35274 },
                
                //Kilogram to other unit
                {$"{WeightAndMassUnit.Kilogram}-{WeightAndMassUnit.Tonne}", FromUnitValue / 1000 },
                {$"{WeightAndMassUnit.Kilogram}-{WeightAndMassUnit.Gram}", FromUnitValue * 1000 },
                {$"{WeightAndMassUnit.Kilogram}-{WeightAndMassUnit.Milligram}", FromUnitValue * 1e+6m },
                {$"{WeightAndMassUnit.Kilogram}-{WeightAndMassUnit.Microgram}", FromUnitValue * 1e+9m },
                {$"{WeightAndMassUnit.Kilogram}-{WeightAndMassUnit.Imperial_ton}", FromUnitValue / 1016 },
                {$"{WeightAndMassUnit.Kilogram}-{WeightAndMassUnit.US_ton}", FromUnitValue / 907 },
                {$"{WeightAndMassUnit.Kilogram}-{WeightAndMassUnit.Stone}", FromUnitValue / 6.35m },
                {$"{WeightAndMassUnit.Kilogram}-{WeightAndMassUnit.Pound}", FromUnitValue * 2.205m },
                {$"{WeightAndMassUnit.Kilogram}-{WeightAndMassUnit.Ounce}", FromUnitValue * 35.274m },

                //Gram to other unit
                 {$"{WeightAndMassUnit.Gram}-{WeightAndMassUnit.Tonne}", FromUnitValue / 1e+6m },
                 {$"{WeightAndMassUnit.Gram}-{WeightAndMassUnit.Kilogram}", FromUnitValue / 1000 },
                 {$"{WeightAndMassUnit.Gram}-{WeightAndMassUnit.Milligram}", FromUnitValue * 1000 },
                 {$"{WeightAndMassUnit.Gram}-{WeightAndMassUnit.Microgram}", FromUnitValue * 1e+6m },
                 {$"{WeightAndMassUnit.Gram}-{WeightAndMassUnit.Imperial_ton}", FromUnitValue / 1.016e+6m},
                 {$"{WeightAndMassUnit.Gram}-{WeightAndMassUnit.US_ton}", FromUnitValue / 907185},
                 {$"{WeightAndMassUnit.Gram}-{WeightAndMassUnit.Stone}", FromUnitValue / 6350},
                 {$"{WeightAndMassUnit.Gram}-{WeightAndMassUnit.Pound}", FromUnitValue / 454},
                 {$"{WeightAndMassUnit.Gram}-{WeightAndMassUnit.Ounce}", FromUnitValue / 28.35m},

                 //Milligram to other unit
                  {$"{WeightAndMassUnit.Milligram}-{WeightAndMassUnit.Tonne}", FromUnitValue / 1e+9m},
                  {$"{WeightAndMassUnit.Milligram}-{WeightAndMassUnit.Kilogram}", FromUnitValue / 1e+6m},
                  {$"{WeightAndMassUnit.Milligram}-{WeightAndMassUnit.Gram}", FromUnitValue / 1000},
                  {$"{WeightAndMassUnit.Milligram}-{WeightAndMassUnit.Microgram}", FromUnitValue * 1000},
                  {$"{WeightAndMassUnit.Milligram}-{WeightAndMassUnit.Imperial_ton}", FromUnitValue / 1.016e+9m},
                  {$"{WeightAndMassUnit.Milligram}-{WeightAndMassUnit.US_ton}", FromUnitValue / 9.072e+8m},
                  {$"{WeightAndMassUnit.Milligram}-{WeightAndMassUnit.Stone}", FromUnitValue / 6.35e+6m},
                  {$"{WeightAndMassUnit.Milligram}-{WeightAndMassUnit.Pound}", FromUnitValue / 453592},
                  {$"{WeightAndMassUnit.Milligram}-{WeightAndMassUnit.Ounce}", FromUnitValue / 28350},

                  //Microgram to other unit
                  {$"{WeightAndMassUnit.Microgram}-{WeightAndMassUnit.Tonne}", FromUnitValue / 1e+12m},
                  {$"{WeightAndMassUnit.Microgram}-{WeightAndMassUnit.Kilogram}", FromUnitValue / 1e+9m},
                  {$"{WeightAndMassUnit.Microgram}-{WeightAndMassUnit.Gram}", FromUnitValue / 1e+6m},
                  {$"{WeightAndMassUnit.Microgram}-{WeightAndMassUnit.Milligram}", FromUnitValue / 1000},
                  {$"{WeightAndMassUnit.Microgram}-{WeightAndMassUnit.Imperial_ton}", FromUnitValue / 1.016e+12m},
                  {$"{WeightAndMassUnit.Microgram}-{WeightAndMassUnit.US_ton}", FromUnitValue / 9.072e+11m},
                  {$"{WeightAndMassUnit.Microgram}-{WeightAndMassUnit.Stone}", FromUnitValue / 6.35e+9m},
                  {$"{WeightAndMassUnit.Microgram}-{WeightAndMassUnit.Pound}", FromUnitValue / 4.536e+8m},
                  {$"{WeightAndMassUnit.Microgram}-{WeightAndMassUnit.Ounce}", FromUnitValue / 2.835e+7m},

                  //Imperial ton to other unit
                  {$"{WeightAndMassUnit.Imperial_ton}-{WeightAndMassUnit.Tonne}", FromUnitValue * 1.016m},
                  {$"{WeightAndMassUnit.Imperial_ton}-{WeightAndMassUnit.Kilogram}", FromUnitValue * 1016.05m},
                  {$"{WeightAndMassUnit.Imperial_ton}-{WeightAndMassUnit.Gram}", FromUnitValue * 1.016e+6m},
                  {$"{WeightAndMassUnit.Imperial_ton}-{WeightAndMassUnit.Milligram}", FromUnitValue * 1.016e+9m},
                  {$"{WeightAndMassUnit.Imperial_ton}-{WeightAndMassUnit.Microgram}", FromUnitValue * 1.016e+12m},
                  {$"{WeightAndMassUnit.Imperial_ton}-{WeightAndMassUnit.US_ton}", FromUnitValue * 1.12m},
                  {$"{WeightAndMassUnit.Imperial_ton}-{WeightAndMassUnit.Stone}", FromUnitValue * 160},
                  {$"{WeightAndMassUnit.Imperial_ton}-{WeightAndMassUnit.Pound}", FromUnitValue * 2240},
                  {$"{WeightAndMassUnit.Imperial_ton}-{WeightAndMassUnit.Ounce}", FromUnitValue * 35840},

                  //Us ton to other unit
                  {$"{WeightAndMassUnit.US_ton}-{WeightAndMassUnit.Tonne}", FromUnitValue / 1.102m},
                  {$"{WeightAndMassUnit.US_ton}-{WeightAndMassUnit.Kilogram}", FromUnitValue * 907.185m},
                  {$"{WeightAndMassUnit.US_ton}-{WeightAndMassUnit.Gram}", FromUnitValue * 907185},
                  {$"{WeightAndMassUnit.US_ton}-{WeightAndMassUnit.Milligram}", FromUnitValue * 9.072e+8m},
                  {$"{WeightAndMassUnit.US_ton}-{WeightAndMassUnit.Microgram}", FromUnitValue * 9.072e+11m},
                  {$"{WeightAndMassUnit.US_ton}-{WeightAndMassUnit.Imperial_ton}", FromUnitValue / 1.12m},
                  {$"{WeightAndMassUnit.US_ton}-{WeightAndMassUnit.Stone}", FromUnitValue * 142.857m},
                  {$"{WeightAndMassUnit.US_ton}-{WeightAndMassUnit.Pound}", FromUnitValue * 2000},
                  {$"{WeightAndMassUnit.US_ton}-{WeightAndMassUnit.Ounce}", FromUnitValue * 32000},

                  //Stone to other unit
                  {$"{WeightAndMassUnit.Stone}-{WeightAndMassUnit.Tonne}", FromUnitValue / 157},
                  {$"{WeightAndMassUnit.Stone}-{WeightAndMassUnit.Kilogram}", FromUnitValue * 6.35m},
                  {$"{WeightAndMassUnit.Stone}-{WeightAndMassUnit.Gram}", FromUnitValue * 6350.29m},
                  {$"{WeightAndMassUnit.Stone}-{WeightAndMassUnit.Milligram}", FromUnitValue * 6.35e+6m},
                  {$"{WeightAndMassUnit.Stone}-{WeightAndMassUnit.Microgram}", FromUnitValue * 6.35e+9m},
                  {$"{WeightAndMassUnit.Stone}-{WeightAndMassUnit.Imperial_ton}", FromUnitValue / 160},
                  {$"{WeightAndMassUnit.Stone}-{WeightAndMassUnit.US_ton}", FromUnitValue / 143},
                  {$"{WeightAndMassUnit.Stone}-{WeightAndMassUnit.Pound}", FromUnitValue * 14},
                  {$"{WeightAndMassUnit.Stone}-{WeightAndMassUnit.Ounce}", FromUnitValue * 224},

                  //Pound to other unit
                  {$"{WeightAndMassUnit.Pound}-{WeightAndMassUnit.Tonne}", FromUnitValue / 2205},
                  {$"{WeightAndMassUnit.Pound}-{WeightAndMassUnit.Kilogram}", FromUnitValue / 2.205m},
                  {$"{WeightAndMassUnit.Pound}-{WeightAndMassUnit.Gram}", FromUnitValue * 453.592m},
                  {$"{WeightAndMassUnit.Pound}-{WeightAndMassUnit.Milligram}", FromUnitValue * 453592},
                  {$"{WeightAndMassUnit.Pound}-{WeightAndMassUnit.Microgram}", FromUnitValue * 4.536e+8m},
                  {$"{WeightAndMassUnit.Pound}-{WeightAndMassUnit.Imperial_ton}", FromUnitValue / 2240},
                  {$"{WeightAndMassUnit.Pound}-{WeightAndMassUnit.US_ton}", FromUnitValue / 2000},
                  {$"{WeightAndMassUnit.Pound}-{WeightAndMassUnit.Stone}", FromUnitValue / 14},
                  {$"{WeightAndMassUnit.Pound}-{WeightAndMassUnit.Ounce}", FromUnitValue * 16},

                  //Ounce to other unit
                  {$"{WeightAndMassUnit.Ounce}-{WeightAndMassUnit.Tonne}", FromUnitValue / 35274},
                  {$"{WeightAndMassUnit.Ounce}-{WeightAndMassUnit.Kilogram}", FromUnitValue / 35.274m},
                  {$"{WeightAndMassUnit.Ounce}-{WeightAndMassUnit.Gram}", FromUnitValue * 28.3495m},
                  {$"{WeightAndMassUnit.Ounce}-{WeightAndMassUnit.Milligram}", FromUnitValue * 28349.5m},
                  {$"{WeightAndMassUnit.Ounce}-{WeightAndMassUnit.Microgram}", FromUnitValue * 2.835e+7m},
                  {$"{WeightAndMassUnit.Ounce}-{WeightAndMassUnit.Imperial_ton}", FromUnitValue / 35840},
                  {$"{WeightAndMassUnit.Ounce}-{WeightAndMassUnit.US_ton}", FromUnitValue / 32000},
                  {$"{WeightAndMassUnit.Ounce}-{WeightAndMassUnit.Stone}", FromUnitValue / 224},
                  {$"{WeightAndMassUnit.Ounce}-{WeightAndMassUnit.Pound}", FromUnitValue / 16},
            };
            return UnitPairs;
        }

        public decimal ConvertUnit()
        {
            var WeightAndMassDictinary = CreateDictinary();
            decimal keyIsMatched = 0;
            WeightAndMassDictinary.TryGetValue(FromUnit_ToUnit, out keyIsMatched);
            return keyIsMatched;
        }

       
    }
}
