namespace DataTest
{
    /// <summary>
    /// Unit Tests for Triceritots
    /// </summary>
    public class TriceritotsUnitTests
    {
        /// <summary>
        /// Triceritots can be cast as Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            Triceritots tt = new();
            Assert.IsAssignableFrom<Side>(tt);
        }

        /// <summary>
        /// Name should vary depending on the size of the Triceritots
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Triceritots")]
        [InlineData(ServingSize.Medium, "Medium Triceritots")]
        [InlineData(ServingSize.Large, "Large Triceritots")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            Triceritots tt = new();
            tt.Size = size;
            Assert.Equal(name, tt.Name);
        }

        /// <summary>
        /// Price should vary depending on the serving size of the Triceritots
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.50)]
        [InlineData(ServingSize.Medium, 4.00)]
        [InlineData(ServingSize.Large, 5.25)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            Triceritots tt = new();
            tt.Size = size;
            Assert.Equal(price, tt.Price);
        }

        /// <summary>
        /// Calories should vary depending on how the Triceritots is served
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(ServingSize.Small, 351)]
        [InlineData(ServingSize.Medium, 409)]
        [InlineData(ServingSize.Large, 583)]
        public void CaloriesShouldBeCorrect(ServingSize size, uint calories)
        {
            Triceritots tt = new();
            tt.Size = size;
            Assert.Equal(calories, tt.Calories);
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
            Triceritots tt = new();
            tt.Size = size;
            Assert.Equal(size, tt.Size);
        }

        /// <summary>
        /// Triceritots should implement the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            Triceritots tt = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tt);
        }

        /// <summary>
        /// Changing Size should notify changes of Size, Name, Price, and Calories properties
        /// </summary>
        /// <param name="size">The size of the Triceritots</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(ServingSize.Medium, "Size")]
        [InlineData(ServingSize.Medium, "Name")]
        [InlineData(ServingSize.Medium, "Price")]
        [InlineData(ServingSize.Medium, "Calories")]
        [InlineData(ServingSize.Large, "Size")]
        [InlineData(ServingSize.Large, "Name")]
        [InlineData(ServingSize.Large, "Price")]
        [InlineData(ServingSize.Large, "Calories")]
        public void ChangingSizeShouldNotifyOfPropertyChanges(ServingSize size, string propertyName)
        {
            Triceritots tt = new();
            Assert.PropertyChanged(tt, propertyName, () => {
                tt.Size = size;
            });
        }
    }
}
