namespace Zymurgy.Dymensions
{
    public static class VolumeExtensions
    {
        public static Volume Litre(this int value)
        {
            return new Volume(value, VolumeUnit.Litres);
        }

        public static Volume Litres(this int value)
        {
            return new Volume(value, VolumeUnit.Litres);
        }

        public static Volume Gallon(this int value)
        {
            return new Volume(value, VolumeUnit.Gallons);
        }

        public static Volume Gallons(this int value)
        {
            return new Volume(value, VolumeUnit.Gallons);
        }
    }
}