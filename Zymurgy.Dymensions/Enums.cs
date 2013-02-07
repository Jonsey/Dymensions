using System.ComponentModel;

namespace Zymurgy.Dymensions
{
    public enum MassUnit
    {
        [Description("Grams")]
        Grams,
        [Description("Kilograms")]
        KiloGrams,
        [Description("Pounds")]
        Pounds
    }

    public enum VolumeUnit
    {
        Litres,
        Quarts,
        Gallons
    }
}
