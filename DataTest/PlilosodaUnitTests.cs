namespace DataTest
{
    /// <summary>
    /// Unit Tests for Plilosoda
    /// </summary>
    public class PlilosodaUnitTests
    {
        /// <summary>
        /// Plilosoda can be cast as Drink
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Plilosoda ps = new();
            Assert.IsAssignableFrom<Drink>(ps);
        }

        /// <summary>
        /// Name should vary depending on the size and flavor of the Plilosoda
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="flavor">The soda flavor</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(ServingSize.Small, SodaFlavor.Cola, "Small Cola Plilosoda")]
        [InlineData(ServingSize.Small, SodaFlavor.CherryCola, "Small Cherry Cola Plilosoda")]
        [InlineData(ServingSize.Small, SodaFlavor.LemonLime, "Small Lemon-Lime Plilosoda")]
        [InlineData(ServingSize.Medium, SodaFlavor.Cola, "Medium Cola Plilosoda")]
        [InlineData(ServingSize.Medium, SodaFlavor.DinoDew, "Medium Dino Dew Plilosoda")]
        [InlineData(ServingSize.Medium, SodaFlavor.LemonLime, "Medium Lemon-Lime Plilosoda")]
        [InlineData(ServingSize.Large, SodaFlavor.Cola, "Large Cola Plilosoda")]
        [InlineData(ServingSize.Large, SodaFlavor.DoctorDino, "Large Doctor Dino Plilosoda")]
        public void NameShouldBeCorrect(ServingSize size, SodaFlavor flavor, string name)
        {
            Plilosoda ps = new();
            ps.Size = size;
            ps.Flavor = flavor;
            Assert.Equal(name, ps.Name);
        }

        /// <summary>
        /// Price should vary depending on the serving size of the Plilosoda
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(ServingSize.Small, 1.00)]
        [InlineData(ServingSize.Medium, 1.75)]
        [InlineData(ServingSize.Large, 2.50)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            Plilosoda ps = new();
            ps.Size = size;
            Assert.Equal(price, ps.Price);
        }

        /// <summary>
        /// Name should vary depending on the size and flavor of the Plilosoda
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="flavor">The soda flavor</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(ServingSize.Small, SodaFlavor.Cola, 180)]
        [InlineData(ServingSize.Small, SodaFlavor.CherryCola, 100)]
        [InlineData(ServingSize.Small, SodaFlavor.LemonLime, 41)]
        [InlineData(ServingSize.Medium, SodaFlavor.Cola, 288)]
        [InlineData(ServingSize.Medium, SodaFlavor.DinoDew, 256)]
        [InlineData(ServingSize.Medium, SodaFlavor.LemonLime, 66)]
        [InlineData(ServingSize.Large, SodaFlavor.Cola, 432)]
        [InlineData(ServingSize.Large, SodaFlavor.DoctorDino, 288)]
        public void CaloriesShouldBeCorrect(ServingSize size, SodaFlavor flavor, uint calories)
        {
            Plilosoda ps = new();
            ps.Size = size;
            ps.Flavor = flavor;
            Assert.Equal(calories, ps.Calories);
        }

        /// <summary>
        /// Should be able to set the serving size
        /// </summary>
        /// <param name="size">The serving size</param>
        [Theory]
        [InlineData(ServingSize.Small)]
        [InlineData(ServingSize.Medium)]
        [InlineData(ServingSize.Large)]
        public void ShouldBeAbleToSetSize(ServingSize size)
        {
            Plilosoda ps = new();
            ps.Size = size;
            Assert.Equal(size, ps.Size);
        }

        /// <summary>
        /// Should be able to set the soda flavor
        /// </summary>
        /// <param name="flavor">The soda flavor</param>
        [Theory]
        [InlineData(SodaFlavor.Cola)]
        [InlineData(SodaFlavor.CherryCola)]
        [InlineData(SodaFlavor.DoctorDino)]
        [InlineData(SodaFlavor.LemonLime)]
        [InlineData(SodaFlavor.DinoDew)]
        public void ShouldBeAbleToSetFlavor(SodaFlavor flavor)
        {
            Plilosoda ps = new();
            ps.Flavor = flavor;
            Assert.Equal(flavor, ps.Flavor);
        }
    }
}
