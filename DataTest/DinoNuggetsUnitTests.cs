namespace DataTest
{
    /// <summary>
    /// Unit Tests for DinoNuggets
    /// </summary>
    public class DinoNuggetsUnitTests
    {
        /// <summary>
        /// DinoNuggets can be cast as Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            DinoNuggets dn = new();
            Assert.IsAssignableFrom<Entree>(dn);
        }

        /// <summary>
        /// Name should always be "[count] Dino Nuggets"
        /// </summary>
        /// <param name="count">Number of Dino Nuggets</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(6, "6 Dino Nuggets")]
        [InlineData(17, "17 Dino Nuggets")]
        [InlineData(7, "7 Dino Nuggets")]
        [InlineData(50, "50 Dino Nuggets")]
        [InlineData(29, "29 Dino Nuggets")]
        [InlineData(9, "9 Dino Nuggets")]
        [InlineData(0, "0 Dino Nuggets")]
        [InlineData(1, "1 Dino Nuggets")]
        public void NameShouldBeCorrect(uint count, string name)
        {
            DinoNuggets dn = new()
            {
                Count = count
            };
            Assert.Equal(name, dn.Name);
        }

        /// <summary>
        /// Price should always be $0.25 * Count"
        /// </summary>
        /// <param name="count">Number of Dino Nuggets</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(6, 6 * 0.25)]
        [InlineData(17, 17 * 0.25)]
        [InlineData(7, 7 * 0.25)]
        [InlineData(50, 50 * 0.25)]
        [InlineData(29, 29 * 0.25)]
        [InlineData(9, 9 * 0.25)]
        [InlineData(0, 0 * 0.25)]
        [InlineData(1, 1 * 0.25)]
        public void PriceShouldBeCorrect(uint count, decimal price)
        {
            DinoNuggets dn = new()
            {
                Count = count
            };
            Assert.Equal(price, dn.Price);
        }

        /// <summary>
        /// Calories should always be 61 * Count"
        /// </summary>
        /// <param name="count">Number of Dino Nuggets</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(6, 6 * 61)]
        [InlineData(17, 17 * 61)]
        [InlineData(7, 7 * 61)]
        [InlineData(50, 50 * 61)]
        [InlineData(29, 29 * 61)]
        [InlineData(9, 9 * 61)]
        [InlineData(0, 0 * 61)]
        [InlineData(1, 1 * 61)]
        public void CaloriesShouldBeCorrect(uint count, uint calories)
        {
            DinoNuggets dn = new()
            {
                Count = count
            };
            Assert.Equal(calories, dn.Calories);
        }

        /// <summary>
        /// Count should default to six
        /// </summary>
        [Fact]
        public void CountShouldDefaultToSix()
        {
            DinoNuggets dn = new();
            Assert.Equal(6u, dn.Count);
        }

        /// <summary>
        /// Should be able to set count
        /// </summary>
        /// <param name="count">Number of Dino Nuggets</param>
        [Theory]
        [InlineData(6)]
        [InlineData(17)]
        [InlineData(7)]
        [InlineData(50)]
        [InlineData(29)]
        [InlineData(9)]
        [InlineData(0)]
        [InlineData(1)]
        public void ShouldBeAbleToSetCount(uint count)
        {
            DinoNuggets dn = new();
            dn.Count = count;
            Assert.Equal(count, dn.Count);
        }
    }
}
