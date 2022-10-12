namespace DataTest
{
    /// <summary>
    /// Unit Tests for CretaceousCoffee
    /// </summary>
    public class CretaceousCoffeeUnitTests
    {
        /// <summary>
        /// CretaceousCoffee can be cast as Drink
        /// </summary>
        [Fact]
        public void ShouldInheritFromDrink()
        {
            CretaceousCoffee cc = new();
            Assert.IsAssignableFrom<Drink>(cc);
        }

        /// <summary>
        /// Name should vary depending on the size of the CretaceousCoffee
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Cretaceous Coffee")]
        [InlineData(ServingSize.Medium, "Medium Cretaceous Coffee")]
        [InlineData(ServingSize.Large, "Large Cretaceous Coffee")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            CretaceousCoffee cc = new();
            cc.Size = size;
            Assert.Equal(name, cc.Name);
        }

        /// <summary>
        /// Price should vary depending on the serving size of the CretaceousCoffee
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(ServingSize.Small, 0.75)]
        [InlineData(ServingSize.Medium, 1.25)]
        [InlineData(ServingSize.Large, 2.00)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            CretaceousCoffee cc = new();
            cc.Size = size;
            Assert.Equal(price, cc.Price);
        }

        /// <summary>
        /// Calories depend on whether the CretaceousCoffee contains Cream
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="cream">If the CretaceousCoffee contains Cream</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(ServingSize.Small, true, 64)]
        [InlineData(ServingSize.Small, false, 0)]
        [InlineData(ServingSize.Medium, true, 64)]
        [InlineData(ServingSize.Medium, false, 0)]
        [InlineData(ServingSize.Large, true, 64)]
        [InlineData(ServingSize.Large, false, 0)]
        public void CaloriesShouldBeCorrect(ServingSize size, bool cream, uint calories)
        {
            CretaceousCoffee cc = new()
            {
                Size = size,
                Cream = cream
            };
            Assert.Equal(calories, cc.Calories);
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
            CretaceousCoffee cc = new();
            cc.Size = size;
            Assert.Equal(size, cc.Size);
        }

        /// <summary>
        /// Cream should default to false
        /// </summary>
        [Fact]
        public void CreamShouldDefaultToFalse()
        {
            CretaceousCoffee cc = new();
            Assert.False(cc.Cream);
        }

        /// <summary>
        /// Should be able to set Cream to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCream()
        {
            CretaceousCoffee cc = new();
            cc.Cream = true;
            Assert.True(cc.Cream);
            cc.Cream = false;
            Assert.False(cc.Cream);
        }

        /// <summary>
        /// CretaceousCoffee should implement the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            CretaceousCoffee cc = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cc);
        }

        /// <summary>
        /// Changing Size should notify changes of Size, Name, and Price properties
        /// </summary>
        /// <param name="size">Indicates the size of the CretaceousCoffee</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(ServingSize.Small, "Size")]
        [InlineData(ServingSize.Small, "Price")]
        [InlineData(ServingSize.Small, "Name")]
        [InlineData(ServingSize.Medium, "Size")]
        [InlineData(ServingSize.Medium, "Price")]
        [InlineData(ServingSize.Medium, "Name")]
        [InlineData(ServingSize.Large, "Size")]
        [InlineData(ServingSize.Large, "Price")]
        [InlineData(ServingSize.Large, "Name")]
        public void ChangingSizeShouldNotifyOfPropertyChanges(ServingSize size, string propertyName)
        {
            CretaceousCoffee cc = new();
            cc.Size = (ServingSize)10; // Ensures the property will always be set
            Assert.PropertyChanged(cc, propertyName, () => {
                cc.Size = size;
            });
        }

        /// <summary>
        /// Changing Cream should notify changes of Cream and Calories properties
        /// </summary>
        /// <param name="cream">Indicates the CretaceousCoffe is served with cream</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Cream")]
        [InlineData(false, "Cream")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingCreamShouldNotifyOfPropertyChanges(bool cream, string propertyName)
        {
            CretaceousCoffee cc = new();
            cc.Cream = !cream; // Ensures the property will always be set
            Assert.PropertyChanged(cc, propertyName, () => {
                cc.Cream = cream;
            });
        }
    }
}
