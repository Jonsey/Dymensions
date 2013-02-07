namespace Zymurgy.Dymensions
{
    public static class VolumeExtensions
    {
        public static Volume Litre(this int value)
        {
            return new Litre(value);
        }

        public static Volume Litres(this int value)
        {
            return new Litre(value);
        }

        public static Volume Gallon(this int value)
        {
            return new USGallon(value);
        }

        public static Volume Gallons(this int value)
        {
            return new USGallon(value);
        }

        public static Volume Quart(this int value)
        {
            return new USQuart(value);
        }

        public static Volume Quarts(this int value)
        {
            return new USQuart(value);
        }
    }
}