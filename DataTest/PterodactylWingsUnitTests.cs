namespace DataTest
{
    /// <summary>
    /// Unit Tests for PterodactylWings
    /// </summary>
    public class PterodactylWingsUnitTests
    {
        /// <summary>
        /// PterodactylWings can be cast as Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            PterodactylWings pw = new();
            Assert.IsAssignableFrom<Entree>(pw);
        }

        /// <summary>
        /// Name should always be "[sauce] Pterodactyl Wings"
        /// </summary>
        /// <param name="sauce">The sauce on the wings</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(WingSauce.Buffalo, "Buffalo Pterodactyl Wings")]
        [InlineData(WingSauce.HoneyGlaze, "Honey Glaze Pterodactyl Wings")]
        [InlineData(WingSauce.Teriyaki, "Teriyaki Pterodactyl Wings")]
        public void NameShouldBeCorrect(WingSauce sauce, string name)
        {
            PterodactylWings pw = new()
            {
                Sauce = sauce
            };
            Assert.Equal(name, pw.Name);
        }

        /// <summary>
        /// Price should always be $8.95
        /// </summary>
        /// <param name="sauce">The sauce on the wings</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(WingSauce.Buffalo, 8.95)]
        [InlineData(WingSauce.HoneyGlaze, 8.95)]
        [InlineData(WingSauce.Teriyaki, 8.95)]
        public void PriceShouldBeCorrect(WingSauce sauce, decimal price)
        {
            PterodactylWings pw = new()
            {
                Sauce = sauce
            };
            Assert.Equal(price, pw.Price);
        }

        /// <summary>
        /// Calories should vary depending on which sauce is on the wings
        /// </summary>
        /// <param name="sauce">The sauce on the wings</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(WingSauce.Buffalo, 360)]
        [InlineData(WingSauce.HoneyGlaze, 359)]
        [InlineData(WingSauce.Teriyaki, 342)]
        public void CaloriesShouldBeCorrect(WingSauce sauce, uint calories)
        {
            PterodactylWings pw = new()
            {
                Sauce = sauce
            };
            Assert.Equal(calories, pw.Calories);
        }

        /// <summary>
        /// Sauce should default to Buffalo
        /// </summary>
        [Fact]
        public void SauceShouldDefaultToBuffalo()
        {
            PterodactylWings pw = new();
            Assert.Equal(WingSauce.Buffalo, pw.Sauce);
        }

        /// <summary>
        /// Should be able to set sauce
        /// </summary>
        /// <param name="sauce">The sauce on the wings</param>
        [Theory]
        [InlineData(WingSauce.Buffalo)]
        [InlineData(WingSauce.HoneyGlaze)]
        [InlineData(WingSauce.Teriyaki)]
        public void ShouldBeAbleToSetSauce(WingSauce sauce)
        {
            PterodactylWings pw = new();
            pw.Sauce = sauce;
            Assert.Equal(sauce, pw.Sauce);
        }
    }
}
