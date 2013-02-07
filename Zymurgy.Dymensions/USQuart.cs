using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zymurgy.Dymensions
{
    internal class USQuart : Volume
    {
        public USQuart(decimal value)
            : base(value, VolumeUnit.Quarts)
        {
        }

        public override Volume ConvertTo(VolumeUnit unitTo)
        {
            switch (unitTo)
            {
                case VolumeUnit.Quarts:
                    {
                        return new USQuart(Value);
                    }
                case VolumeUnit.Gallons:
                    {
                        return new USGallon(Value / 4);
                    }
                case VolumeUnit.Litres:
                    {
                        return new Litre(Value * 0.946353M);
                    }
                default:
                    {
                        throw new Exception(String.Format("Volume unit {0} is unknown.", unitTo.GetType().Name));
                    }
            }
        }
    }
}
