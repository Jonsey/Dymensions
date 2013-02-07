using System;

namespace Zymurgy.Dymensions
{
    public class Volume
    {
        #region Ctors

        protected Volume()
        {

        }

        public Volume(decimal value, VolumeUnit unit)
        {
            Value = value;
            Unit = unit;
        }

        #endregion

        #region Properties

        public virtual decimal Value { get; private set; }

        public virtual VolumeUnit Unit { get; private set; }

        #endregion

        #region Equality Members

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof (Volume)) return false;
            return Equals((Volume) obj);
        }

        public bool Equals(Volume other)
        {
            return other.Value.Equals(Value) && Equals(other.Unit, Unit);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Value.GetHashCode()*397) ^ Unit.GetHashCode();
            }
        }

        #endregion

        //#region Operator Overrides

        //public static bool operator ==(Volume left, Volume right)
        //{
        //    return Equals(left, right);
        //}

        //public static bool operator !=(Volume left, Volume right)
        //{
        //    return !Equals(left, right);
        //}

        //#endregion

        #region Public Methods

        public virtual Volume ConvertTo(VolumeUnit unitTo)
        {
            var volume = GetInstanceOfCurrentVolume();
            return volume.ConvertTo(unitTo);
        }

        private Volume GetInstanceOfCurrentVolume()
        {
            Volume volume;
            switch (Unit)
            {
                case VolumeUnit.Gallons:
                    {
                        volume = new USGallon(Value);
                        break;
                    }
                case VolumeUnit.Litres:
                    {
                        volume = new Litre(Value);
                        break;
                    }
                case VolumeUnit.Quarts:
                    {
                        volume = new USQuart(Value);
                        break;
                    }
                default:
                    {
                        throw new Exception(String.Format("Volume unit {0} is unknown.", Unit.GetType().Name));
                    }
            }
            return volume;
        }

        #endregion
    }
}