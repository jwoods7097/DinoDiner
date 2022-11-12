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
    }
}
