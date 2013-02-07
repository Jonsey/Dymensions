using NUnit.Framework;
using Zymurgy.Dymensions;

namespace Zymurgy.Dimensions.Specs
{
    [TestFixture]
    public class WeigthConversionSpecs
    {
        [Test]
        public void ShouldConvertGramsToPounds()
        {
            var result = 1.Gram().ConvertTo(MassUnit.Pounds);

            Assert.AreEqual(0.00220462M, result.Value);
            Assert.AreEqual(MassUnit.Pounds, result.Unit);
        }

        [Test]
        public void ShouldConvertGramsToKiloGrams()
        {
            var result = 1.Gram().ConvertTo(MassUnit.KiloGrams);

            Assert.AreEqual(0.001M, result.Value);
            Assert.AreEqual(MassUnit.KiloGrams, result.Unit);
        }

        [Test]
        public void ShouldNotChangeGramsToGrams()
        {
            var result = 1.Gram().ConvertTo(MassUnit.Grams);

            Assert.AreEqual(1M, result.Value);
            Assert.AreEqual(MassUnit.Grams, result.Unit);
        }

        [Test]
        public void ShouldConvertKiloGramsToPounds()
        {
            var result = 1.KiloGram().ConvertTo(MassUnit.Pounds);

            Assert.AreEqual(2.20462M, result.Value);
            Assert.AreEqual(MassUnit.Pounds, result.Unit);
        }

        [Test]
        public void ShouldConvertKiloGramsToGrams()
        {
            var result = 1.KiloGram().ConvertTo(MassUnit.Grams);

            Assert.AreEqual(1000M, result.Value);
            Assert.AreEqual(MassUnit.Grams, result.Unit);
        }

        [Test]
        public void ShouldNotChangeKiloGramsToKiloGrams()
        {
            var result = 1.KiloGram().ConvertTo(MassUnit.KiloGrams);

            Assert.AreEqual(1M, result.Value);
            Assert.AreEqual(MassUnit.KiloGrams, result.Unit);
        }

        [Test]
        public void ShouldConvertPoundsToGrams()
        {
            var result = 1.Pound().ConvertTo(MassUnit.Grams);

            Assert.AreEqual(453.592M, result.Value);
            Assert.AreEqual(MassUnit.Grams, result.Unit);
        }

        [Test]
        public void ShouldConvertPoundsToKiloGrams()
        {
            var result = 1.Pound().ConvertTo(MassUnit.KiloGrams);

            Assert.AreEqual(0.453592M, result.Value);
            Assert.AreEqual(MassUnit.KiloGrams, result.Unit);
        }

        [Test]
        public void ShouldNotChangePoundsToPounds()
        {
            var result = 1.Pound().ConvertTo(MassUnit.Pounds);

            Assert.AreEqual(1M, result.Value);
            Assert.AreEqual(MassUnit.Pounds, result.Unit);
        }
    }
}