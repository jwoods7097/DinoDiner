using Website.Pages;

namespace DataTest
{
    /// <summary>
    /// Unit Tests for Menu
    /// </summary>
    public class MenuUnitTests
    {
        /// <summary>
        /// There should be 10 entrees in the menu
        /// </summary>
        [Fact]
        public void EntreesShouldContainCorrectNumberofItems()
        {
            Assert.Equal(10, Menu.Entrees.Count());
        }

        /// <summary>
        /// There should be 12 total items in Sides, 4 sides with 3 sizes each
        /// </summary>
        [Fact]
        public void SidesShouldContainCorrectNumberofItems()
        {
            Assert.Equal(4 * 3, Menu.Sides.Count());
        }

        /// <summary>
        /// There should be 18 total items in Drinks: 5 Plilosoda flavors with 3 sizes each,
        /// and 3 sizes of CretaceousCoffee
        /// </summary>
        [Fact]
        public void DrinksShouldContainCorrectNumberofItems()
        {
            Assert.Equal(5 * 3 + 3, Menu.Drinks.Count());
        }

        /// <summary>
        /// FullMenu should have the sum of the counts of Entrees, Sides, and Drinks items
        /// </summary>
        [Fact]
        public void FullMenuShouldContainCorrectNumberofItems()
        {
            Assert.Equal(10 + (4 * 3) + (5 * 3 + 3), Menu.FullMenu.Count());
        }

        /// <summary>
        /// Entrees should contain the correct items
        /// </summary>
        [Fact]
        public void EntreesContainsCorrectItems()
        {
            Assert.Collection(Menu.Entrees,
                item => Assert.IsType<AllosaurusAllAmericanBurger>(item),
                item => Assert.IsType<CarnotaurusCheeseburger>(item),
                item => Assert.IsType<DeinonychusDouble>(item),
                item => Assert.IsType<TRexTriple>(item),
                item => Assert.IsType<Burger>(item),
                item => Assert.IsType<Brontowurst>(item),
                item => Assert.IsType<PrehistoricPBJ>(item),
                item => Assert.IsType<PterodactylWings>(item),
                item => Assert.IsType<VelociWraptor>(item),
                item => Assert.IsType<DinoNuggets>(item)
            );
        }

        /// <summary>
        /// Sides should contain the correct items
        /// </summary>
        [Fact]
        public void SidesContainsCorrectItems()
        {
            foreach(ServingSize size in Enum.GetValues(typeof(ServingSize)))
            {
                Assert.Contains(Menu.Sides, item => item is Fryceritops ft && ft.Size == size);
                Assert.Contains(Menu.Sides, item => item is MeteorMacAndCheese mc && mc.Size == size);
                Assert.Contains(Menu.Sides, item => item is MezzorellaSticks ms && ms.Size == size);
                Assert.Contains(Menu.Sides, item => item is Triceritots tt && tt.Size == size);
            }
        }

        /// <summary>
        /// Drinks should contain the correct items
        /// </summary>
        [Fact]
        public void DrinksContainsCorrectItems()
        {
            foreach (ServingSize size in Enum.GetValues(typeof(ServingSize)))
            {
                foreach(SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    Assert.Contains(Menu.Drinks, item => item is Plilosoda ps && ps.Size == size && ps.Flavor == flavor);
                }
                Assert.Contains(Menu.Drinks, item => item is CretaceousCoffee cc && cc.Size == size);
            }
        }

        /// <summary>
        /// The full menu should contain all the items from the entrees, sides, and drinks list
        /// </summary>
        [Fact]
        public void FullMenuContainsCorrectItems()
        {
            Assert.Contains(Menu.FullMenu, item => item is AllosaurusAllAmericanBurger);
            Assert.Contains(Menu.FullMenu, item => item is CarnotaurusCheeseburger);
            Assert.Contains(Menu.FullMenu, item => item is DeinonychusDouble);
            Assert.Contains(Menu.FullMenu, item => item is TRexTriple);
            Assert.Contains(Menu.FullMenu, item => item is Burger);
            Assert.Contains(Menu.FullMenu, item => item is Brontowurst);
            Assert.Contains(Menu.FullMenu, item => item is PrehistoricPBJ);
            Assert.Contains(Menu.FullMenu, item => item is PterodactylWings);
            Assert.Contains(Menu.FullMenu, item => item is VelociWraptor);
            Assert.Contains(Menu.FullMenu, item => item is DinoNuggets);
            foreach (ServingSize size in Enum.GetValues(typeof(ServingSize)))
            {
                Assert.Contains(Menu.FullMenu, item => item is Fryceritops ft && ft.Size == size);
                Assert.Contains(Menu.FullMenu, item => item is MeteorMacAndCheese mc && mc.Size == size);
                Assert.Contains(Menu.FullMenu, item => item is MezzorellaSticks ms && ms.Size == size);
                Assert.Contains(Menu.FullMenu, item => item is Triceritots tt && tt.Size == size);
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    Assert.Contains(Menu.FullMenu, item => item is Plilosoda ps && ps.Size == size && ps.Flavor == flavor);
                }
                Assert.Contains(Menu.FullMenu, item => item is CretaceousCoffee cc && cc.Size == size);
            }
        }

        /// <summary>
        /// Searching by name returns the correct results
        /// </summary>
        /// <param name="searchTerms">The terms to search for</param>
        /// <param name="numItems">How many items should be returned from the query</param>
        [Theory]
        [InlineData(null, 40)]
        [InlineData("", 40)]
        [InlineData("burger", 3)]
        [InlineData("BURGER", 3)]
        [InlineData("Dino Nuggets", 1)]
        [InlineData("Nuggets Dino", 1)]
        [InlineData("large", 10)]
        [InlineData("xxyxz", 0)]
        public void SearchByNameWorksCorrectly(string searchTerms, int numItems)
        {
            IndexModel model = new();
            model.OnGet(searchTerms, null, null, null, null, null);
            Assert.Equal(numItems, model.Items.Count());
        }

        /// <summary>
        /// Searching with item types should exclude those types
        /// </summary>
        /// <param name="itemTypes">The item types to exclude from the results</param>
        [Theory]
        [InlineData("")]
        [InlineData(nameof(Entree))]
        [InlineData(nameof(Side))]
        [InlineData(nameof(Drink))]
        [InlineData(nameof(Entree), nameof(Side))]
        [InlineData(nameof(Entree), nameof(Drink))]
        [InlineData(nameof(Drink), nameof(Side))]
        [InlineData(nameof(Entree), nameof(Side), nameof(Drink))]
        public void SearchByTypeWorksCorrectly(params string[] itemTypes)
        {
            IndexModel model = new();
            model.OnGet(null, itemTypes, null, null, null, null);
            foreach (MenuItem item in model.Items)
            {
                if (!itemTypes.Contains(nameof(Entree)))
                {
                    Assert.False(item is Entree);
                }
                if (!itemTypes.Contains(nameof(Side)))
                {
                    Assert.False(item is Side);
                }
                if (!itemTypes.Contains(nameof(Drink)))
                {
                    Assert.False(item is Drink);
                }
            }
        }

        /// <summary>
        /// Searching by calories should return items with calories in the given range
        /// </summary>
        /// <param name="minCalories">The minimum calories to include</param>
        /// <param name="maxCalories">The maximum calories to include</param>
        /// <param name="numItems">How many items should be returned from the query</param>
        [Theory]
        [InlineData(null, null, 40)]
        [InlineData(null, 200, 12)]
        [InlineData(600, null, 5)]
        [InlineData(512, 512, 1)]
        [InlineData(200, 300, 6)]
        [InlineData(200, 400, 13)]
        [InlineData(200, 500, 17)]
        [InlineData(200, 600, 23)]
        public void SearchByCaloriesWorksCorrectly(int? minCalories, int? maxCalories, int numItems)
        {
            IndexModel model = new();
            model.OnGet(null, null, (uint?)minCalories, (uint?)maxCalories, null, null);
            Assert.Equal(numItems, model.Items.Count());
        }

        /// <summary>
        /// Searching by price should return items with price in the given range
        /// </summary>
        /// <param name="minPrice">The minimum price to include</param>
        /// <param name="maxPrice">The maximum price to include</param>
        /// <param name="numItems">How many items should be returned from the query</param>
        [Theory]
        [InlineData(null, null, 40)]
        [InlineData(null, 2.00, 15)]
        [InlineData(6.00, null, 3)]
        [InlineData(8.95, 8.95, 1)]
        [InlineData(2.00, 3.00, 8)]
        [InlineData(2.00, 4.00, 17)]
        [InlineData(2.00, 5.00, 19)]
        [InlineData(2.00, 6.00, 23)]
        public void SearchByPriceWorksCorrectly(double? minPrice, double? maxPrice, int numItems)
        {
            IndexModel model = new();
            model.OnGet(null, null, null, null, (decimal?)minPrice, (decimal?)maxPrice);
            Assert.Equal(numItems, model.Items.Count());
        }
    }
}
