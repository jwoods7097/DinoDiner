namespace DataTest
{
    /// <summary>
    /// Unit Tests for MezzorellaSticks
    /// </summary>
    public class MezzorellaSticksUnitTests
    {
        /// <summary>
        /// MezzorellaSticks can be cast as Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            MezzorellaSticks ms = new();
            Assert.IsAssignableFrom<Side>(ms);
        }

        /// <summary>
        /// Name should vary depending on the size of the MezzorellaSticks
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Mezzorealla Sticks")]
        [InlineData(ServingSize.Medium, "Medium Mezzorealla Sticks")]
        [InlineData(ServingSize.Large, "Large Mezzorealla Sticks")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            MezzorellaSticks ms = new();
            ms.Size = size;
            Assert.Equal(name, ms.Name);
        }

        /// <summary>
        /// Price should vary depending on the serving size of the MezzorellaSticks
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.50)]
        [InlineData(ServingSize.Medium, 4.00)]
        [InlineData(ServingSize.Large, 5.25)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            MezzorellaSticks ms = new();
            ms.Size = size;
            Assert.Equal(price, ms.Price);
        }

        /// <summary>
        /// Calories should vary depending on how the MezzorellaSticks is served
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(ServingSize.Small, 530)]
        [InlineData(ServingSize.Medium, 620)]
        [InlineData(ServingSize.Large, 730)]
        public void CaloriesShouldBeCorrect(ServingSize size, uint calories)
        {
            MezzorellaSticks ms = new();
            ms.Size = size;
            Assert.Equal(calories, ms.Calories);
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
            MezzorellaSticks ms = new();
            ms.Size = size;
            Assert.Equal(size, ms.Size);
        }
    }
}
