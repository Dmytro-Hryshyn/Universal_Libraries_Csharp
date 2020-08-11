using System.Collections.Generic;

namespace Unit.Converter
{
    interface IConverter
    {
         public decimal ConvertUnit();

         public Dictionary<string, decimal> CreateDictinary();
    }
}
