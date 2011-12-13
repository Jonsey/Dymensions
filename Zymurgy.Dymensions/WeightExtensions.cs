namespace Zymurgy.Dymensions
{
    public static class WeightExtensions
    {
        public static Weight KiloGrams(this int value)
        {
            return new Weight(value, MassUnit.KiloGrams);
        }

        public static Weight KiloGram(this int value)
        {
            return new Weight(value, MassUnit.KiloGrams);
        }

        public static Weight Grams(this int value)
        {
            return new Weight(value, MassUnit.Grams);
        }

        public static Weight Gram(this int value)
        {
            return new Weight(value, MassUnit.Grams);
        }

        public static Weight Pounds(this int value)
        {
            return new Weight(value, MassUnit.Pounds);
        }

        public static Weight Pound(this int value)
        {
            return new Weight(value, MassUnit.Pounds);
        }
    }
}
