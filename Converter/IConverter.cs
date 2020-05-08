
using System;

namespace ModernUiDesign
{
    
    interface IConverter
    {
        
        decimal FromUnitValue { get; }
        string FromUnitName { get; }
        string ToUnitName { get; }
        string ResultString { get; }

         string GetUnswer();
       
       //todo: Add delegate to this method

    }
}
