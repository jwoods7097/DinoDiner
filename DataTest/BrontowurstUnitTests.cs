namespace DataTest
{
    /// <summary>
    /// Unit Tests for Brontowurst
    /// </summary>
    public class BrontowurstUnitTests
    {
        /// <summary>
        /// Brontowurst can be cast as Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            Brontowurst bw = new();
            Assert.IsAssignableFrom<Entree>(bw);
        }

        /// <summary>
        /// Name should always be "Brontoworst", regardless of how it's served
        /// </summary>
        /// <param name="onions">If the Brontowurst contains onions</param>
        /// <param name="peppers">If the Brontowurst contains peppers</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(true, true, "Brontowurst")]
        [InlineData(true, false, "Brontowurst")]
        [InlineData(false, true, "Brontowurst")]
        [InlineData(false, false, "Brontowurst")]
        public void NameShouldBeCorrect(bool onions, bool peppers, string name)
        {
            Brontowurst bw = new()
            {
                Onions = onions,
                Peppers = peppers
            };
            Assert.Equal(name, bw.Name);
        }

        /// <summary>
        /// Price should always be $5.86, regardless of how it's served
        /// </summary>
        /// <param name="onions">If the Brontowurst contains onions</param>
        /// <param name="peppers">If the Brontowurst contains peppers</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(true, true, 5.86)]
        [InlineData(true, false, 5.86)]
        [InlineData(false, true, 5.86)]
        [InlineData(false, false, 5.86)]
        public void PriceShouldBeCorrect(bool onions, bool peppers, decimal price)
        {
            Brontowurst bw = new()
            {
                Onions = onions,
                Peppers = peppers
            };
            Assert.Equal(price, bw.Price);
        }

        /// <summary>
        /// Calories should always be 512, regardless of how it's served
        /// </summary>
        /// <param name="onions">If the Brontowurst contains onions</param>
        /// <param name="peppers">If the Brontowurst contains peppers</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(true, true, 512)]
        [InlineData(true, false, 512)]
        [InlineData(false, true, 512)]
        [InlineData(false, false, 512)]
        public void CaloriesShouldBeCorrect(bool onions, bool peppers, uint calories)
        {
            Brontowurst bw = new()
            {
                Onions = onions,
                Peppers = peppers
            };
            Assert.Equal(calories, bw.Calories);
        }

        /// <summary>
        /// Onions should default to true
        /// </summary>
        [Fact]
        public void OnionsShouldDefaultToTrue()
        {
            Brontowurst bw = new();
            Assert.True(bw.Onions);
        }

        /// <summary>
        /// Should be able to set Onions to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            Brontowurst bw = new();
            bw.Onions = false;
            Assert.False(bw.Onions);
            bw.Onions = true;
            Assert.True(bw.Onions);
        }

        /// <summary>
        /// Peppers should default to true
        /// </summary>
        [Fact]
        public void PeppersShouldDefaultToTrue()
        {
            Brontowurst bw = new();
            Assert.True(bw.Peppers);
        }

        /// <summary>
        /// Should be able to set Peppers to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPeppers()
        {
            Brontowurst bw = new();
            bw.Peppers = false;
            Assert.False(bw.Peppers);
            bw.Peppers = true;
            Assert.True(bw.Peppers);
        }

        /// <summary>
        /// Brontowurst should implement the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            Brontowurst bw = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(bw);
        }

        /// <summary>
        /// Changing Onions should notify changes of Onions property
        /// </summary>
        /// <param name="onions">Indicates the Brontowurst is served with onions</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingOnionsShouldNotifyOfPropertyChanges(bool onions)
        {
            Brontowurst bw = new();
            bw.Onions = !onions; // Ensures the property will always be set
            Assert.PropertyChanged(bw, "Onions", () => {
                bw.Onions = onions;
            });
        }

        /// <summary>
        /// Changing Peppers should notify changes of Peppers property
        /// </summary>
        /// <param name="peppers">Indicates the Brontowurst is served with peppers</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingPeppersShouldNotifyOfPropertyChanges(bool peppers)
        {
            Brontowurst bw = new();
            bw.Peppers = !peppers; // Ensures the property will always be set
            Assert.PropertyChanged(bw, "Peppers", () => {
                bw.Peppers = peppers;
            });
        }
    }
}
