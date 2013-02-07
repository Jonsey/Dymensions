using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Zymurgy.Dymensions;

namespace Zymurgy.Dimensions.Specs
{
    [TestFixture]
    public class VolumeConversionSpecs
    {
        [Test]
        public void ShouldConvertLitresToUSQuarts()
        {
            var result = 1.Litre().ConvertTo(VolumeUnit.Quarts);

            Assert.AreEqual(1.05669, result.Value);
            Assert.AreEqual(VolumeUnit.Quarts, result.Unit);
        }

        [Test]
        public void ShouldConvertLitresToUSGallons()
        {
            var result = 1.Litre().ConvertTo(VolumeUnit.Gallons);

            Assert.AreEqual(0.264172, result.Value);
            Assert.AreEqual(VolumeUnit.Gallons, result.Unit);
        }

        [Test]
        public void ShouldNotChangeLitresToLitres()
        {
            var result = 1.Litre().ConvertTo(VolumeUnit.Litres);

            Assert.AreEqual(1, result.Value);
            Assert.AreEqual(VolumeUnit.Litres, result.Unit);
        }

        [Test]
        public void ShouldConvertUSQuartsToLitres()
        {
            var result = 1.Quarts().ConvertTo(VolumeUnit.Litres);

            Assert.AreEqual(0.946353, result.Value);
            Assert.AreEqual(VolumeUnit.Litres, result.Unit);
        }

        [Test]
        public void ShouldConvertUSQuartsToUSGallons()
        {
            var result = 1.Quarts().ConvertTo(VolumeUnit.Gallons);

            Assert.AreEqual(0.25, result.Value);
            Assert.AreEqual(VolumeUnit.Gallons, result.Unit);
        }

        [Test]
        public void ShouldNotChangeGallonsToUSQuarts()
        {
            var result = 1.Quart().ConvertTo(VolumeUnit.Quarts);

            Assert.AreEqual(1, result.Value);
            Assert.AreEqual(VolumeUnit.Quarts, result.Unit);
        }

        [Test]
        public void ShouldConvertUSGallonsToLitres()
        {
            var result = 1.Gallon().ConvertTo(VolumeUnit.Litres);

            Assert.AreEqual(3.78541, result.Value);
            Assert.AreEqual(VolumeUnit.Litres, result.Unit);
        }

        [Test]
        public void ShouldConvertUSGallonsToQuarts()
        {
            var result = 1.Gallon().ConvertTo(VolumeUnit.Quarts);

            Assert.AreEqual(4, result.Value);
            Assert.AreEqual(VolumeUnit.Quarts, result.Unit);
        }

        [Test]
        public void ShouldNotChangeGallonsToGallons()
        {
            var result = 1.Gallon().ConvertTo(VolumeUnit.Gallons);

            Assert.AreEqual(1, result.Value);
            Assert.AreEqual(VolumeUnit.Gallons, result.Unit);
        }

    }
}
