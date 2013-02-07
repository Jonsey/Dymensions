using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zymurgy.Dymensions
{
    internal class USGallon : Volume
    {
        public USGallon(decimal value)
            : base(value, VolumeUnit.Gallons)
        {
        }

        public override Volume ConvertTo(VolumeUnit unitTo)
        {
            switch (unitTo)
            {
                case VolumeUnit.Quarts:
                    {
                        return new USQuart(Value * 4M);
                    }
                case VolumeUnit.Gallons:
                    {
                        return new USGallon(Value);
                    }
                case VolumeUnit.Litres:
                    {
                        return new Litre(Value * 3.78541M);
                    }
                default:
                    {
                        throw new Exception(String.Format("Volume unit {0} is unknown.", unitTo.GetType().Name));
                    }
            }
        }
    }
}
