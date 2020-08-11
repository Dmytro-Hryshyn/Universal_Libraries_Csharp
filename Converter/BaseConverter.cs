namespace Unit.Converter
{
    public class BaseConverter
    {
        public decimal FromUnitValue { get; protected set; }
        public string FromUnit { get; protected set; }
        public string ToUnit { get; protected set; }
        public string FromUnit_ToUnit { get; protected set; }
    }
}
