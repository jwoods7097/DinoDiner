namespace DataTest
{
    /// <summary>
    /// Unit Tests for Fryceritops
    /// </summary>
    public class FryceritopsUnitTests
    {
        /// <summary>
        /// Fryceritops can be cast as Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Fryceritops ft = new();
            Assert.IsAssignableFrom<Side>(ft);
        }

        /// <summary>
        /// Name should vary depending on the size of the Fryceritops
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Fryceritops")]
        [InlineData(ServingSize.Medium, "Medium Fryceritops")]
        [InlineData(ServingSize.Large, "Large Fryceritops")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            Fryceritops ft = new();
            ft.Size = size;
            Assert.Equal(name, ft.Name);
        }

        /// <summary>
        /// Price should vary depending on the serving size of the Fryceritops
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.50)]
        [InlineData(ServingSize.Medium, 4.00)]
        [InlineData(ServingSize.Large, 5.00)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            Fryceritops ft = new();
            ft.Size = size;
            Assert.Equal(price, ft.Price);
        }

        /// <summary>
        /// Calories should vary depending on how the Fryceritops is served
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="sauce">If the Fryceritops contains sauce</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 365 + 80)]
        [InlineData(ServingSize.Small, false, 365)]
        [InlineData(ServingSize.Medium, true, 465 + 80)]
        [InlineData(ServingSize.Medium, false, 465)]
        [InlineData(ServingSize.Large, true, 510 + 80)]
        [InlineData(ServingSize.Large, false, 510)]
        public void CaloriesShouldBeCorrect(ServingSize size, bool sauce, uint calories)
        {
            Fryceritops ft = new()
            {
                Size = size,
                Sauce = sauce
            };
            Assert.Equal(calories, ft.Calories);
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
            Fryceritops ft = new();
            ft.Size = size;
            Assert.Equal(size, ft.Size);
        }

        /// <summary>
        /// Salt should default to true
        /// </summary>
        [Fact]
        public void SaltShouldDefaultToTrue()
        {
            Fryceritops ft = new();
            Assert.True(ft.Salt);
        }

        /// <summary>
        /// Should be able to set Salt to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSalt()
        {
            Fryceritops ft = new();
            ft.Salt = false;
            Assert.False(ft.Salt);
            ft.Salt = true;
            Assert.True(ft.Salt);
        }

        /// <summary>
        /// Sauce should default to false
        /// </summary>
        [Fact]
        public void SauceShouldDefaultToFalse()
        {
            Fryceritops ft = new();
            Assert.False(ft.Sauce);
        }

        /// <summary>
        /// Should be able to set Sauce to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSauce()
        {
            Fryceritops ft = new();
            ft.Sauce = true;
            Assert.True(ft.Sauce);
            ft.Sauce = false;
            Assert.False(ft.Sauce);
        }
    }
}
