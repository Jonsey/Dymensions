namespace Zymurgy.Dymensions
{
    public class Volume
    {
        private readonly decimal _value;
        private readonly VolumeUnit _unit;

        public Volume(decimal value, VolumeUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Volume)) return false;
            return Equals((Volume)obj);
        }

        public bool Equals(Volume other)
        {
            return other._value.Equals(_value) && Equals(other._unit, _unit);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_value.GetHashCode() * 397) ^ _unit.GetHashCode();
            }
        }

        public static bool operator ==(Volume left, Volume right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Volume left, Volume right)
        {
            return !Equals(left, right);
        }

        public Volume ConvertTo(VolumeUnit unitTo)
        {
            switch (_unit)
            {
                case VolumeUnit.Litres:
                    {
                        switch (unitTo)
                        {
                            case VolumeUnit.Gallons:
                                {
                                    return new Volume(_value * 0.264172M, VolumeUnit.Gallons);
                                }
                            case VolumeUnit.Litres:
                                {
                                    return new Volume(_value, _unit);
                                }
                        }
                        break;
                    }
                case VolumeUnit.Gallons:
                    {
                        switch (unitTo)
                        {
                            case VolumeUnit.Gallons:
                                {
                                    return new Volume(_value, _unit);
                                }
                            case VolumeUnit.Litres:
                                {
                                    return new Volume(_value / 0.264172M, VolumeUnit.Litres);
                                }
                        }
                        break;
                    }
                default:
                    {
                        return new Volume(_value, _unit);
                    }
            }
            return null;
        }



        public decimal GetValue()
        {
            return _value;
        }

        public VolumeUnit GetUnit()
        {
            return _unit;
        }
    }
}