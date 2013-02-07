using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zymurgy.Dymensions
{
    internal class Litre : Volume
    {
        public Litre(decimal value)
            : base(value, VolumeUnit.Litres)
        {
        }

        public override Volume ConvertTo(VolumeUnit unitTo)
        {
            switch (unitTo)
            {
                case VolumeUnit.Quarts:
                    {
                        return new USQuart(Value * 1.05669M);
                    }
                case VolumeUnit.Gallons:
                    {
                        return new USGallon(Value * 0.264172M);
                    }
                case VolumeUnit.Litres:
                    {
                        return new Litre(Value);
                    }
                default:
                    {
                        throw new Exception(String.Format("Volume unit {0} is unknown.", unitTo.GetType().Name));
                    }
            }
        }
    }
}
