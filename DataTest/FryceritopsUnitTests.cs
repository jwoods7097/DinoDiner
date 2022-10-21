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

        /// <summary>
        /// Fryceritops should implement the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            Fryceritops ft = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ft);
        }

        /// <summary>
        /// Changing Size should notify changes of Size, Name, Price, and Calories properties
        /// </summary>
        /// <param name="size">The size of the Fryceritops</param>
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
            Fryceritops ft = new();
            Assert.PropertyChanged(ft, propertyName, () => {
                ft.Size = size;
            });
        }

        /// <summary>
        /// Changing Salt should notify changes of Toasted property
        /// </summary>
        /// <param name="salt">Indicates the fries are salted</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingSaltShouldNotifyOfPropertyChanges(bool salt)
        {
            Fryceritops ft = new();
            ft.Salt = !salt; // Ensures the property will always be set
            Assert.PropertyChanged(ft, "Salt", () => {
                ft.Salt = salt;
            });
        }

        /// <summary>
        /// Changing Sauce should notify changes of Sauce and Calories properties
        /// </summary>
        /// <param name="sauce">Indicates the fries are served with fry sauce</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Sauce")]
        [InlineData(false, "Sauce")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingSauceShouldNotifyOfPropertyChanges(bool sauce, string propertyName)
        {
            Fryceritops ft = new();
            ft.Sauce = !sauce; // Ensures the property will always be set
            Assert.PropertyChanged(ft, propertyName, () => {
                ft.Sauce = sauce;
            });
        }

        /// <summary>
        /// Fryceritops can be cast as MenuItem
        /// </summary>
        [Fact]
        public void ShouldInheritFromMenuItem()
        {
            Fryceritops ft = new();
            Assert.IsAssignableFrom<MenuItem>(ft);
        }

        /// <summary>
        /// Updating Salt should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForSalt()
        {
            Fryceritops ft = new();
            string instruction = "Hold Salt"; // Ensures string will be the same in both asserts
            ft.Salt = false;
            Assert.Contains<string>(instruction, ft.SpecialInstructions);
            ft.Salt = true;
            Assert.DoesNotContain<string>(instruction, ft.SpecialInstructions);
        }

        /// <summary>
        /// Updating Sauce should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForSauce()
        {
            Fryceritops ft = new();
            string instruction = "Add Sauce"; // Ensures string will be the same in both asserts
            ft.Sauce = true;
            Assert.Contains<string>(instruction, ft.SpecialInstructions);
            ft.Sauce = false;
            Assert.DoesNotContain<string>(instruction, ft.SpecialInstructions);
        }
    }
}
