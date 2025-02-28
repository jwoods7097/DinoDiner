﻿namespace DataTest
{
    /// <summary>
    /// Unit Tests for MeteorMacAndCheese
    /// </summary>
    public class MeteorMacAndCheeseUnitTests
    {
        /// <summary>
        /// MeteorMacAndCheese can be cast as Side
        /// </summary>
        [Fact]
        public void ShouldInheritFromSide()
        {
            MeteorMacAndCheese mc = new();
            Assert.IsAssignableFrom<Side>(mc);
        }

        /// <summary>
        /// Name should vary depending on the size of the MeteorMacAndCheese
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(ServingSize.Small, "Small Meteor Mac & Cheese")]
        [InlineData(ServingSize.Medium, "Medium Meteor Mac & Cheese")]
        [InlineData(ServingSize.Large, "Large Meteor Mac & Cheese")]
        public void NameShouldBeCorrect(ServingSize size, string name)
        {
            MeteorMacAndCheese mc = new();
            mc.Size = size;
            Assert.Equal(name, mc.Name);
        }

        /// <summary>
        /// Price should vary depending on the serving size of the MeteorMacAndCheese
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(ServingSize.Small, 3.50)]
        [InlineData(ServingSize.Medium, 4.00)]
        [InlineData(ServingSize.Large, 5.25)]
        public void PriceShouldBeCorrect(ServingSize size, decimal price)
        {
            MeteorMacAndCheese mc = new();
            mc.Size = size;
            Assert.Equal(price, mc.Price);
        }

        /// <summary>
        /// Calories should vary depending on how the MeteorMacAndCheese is served
        /// </summary>
        /// <param name="size">The serving size</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(ServingSize.Small, 425)]
        [InlineData(ServingSize.Medium, 510)]
        [InlineData(ServingSize.Large, 700)]
        public void CaloriesShouldBeCorrect(ServingSize size, uint calories)
        {
            MeteorMacAndCheese mc = new();
            mc.Size = size;
            Assert.Equal(calories, mc.Calories);
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
            MeteorMacAndCheese mc = new();
            mc.Size = size;
            Assert.Equal(size, mc.Size);
        }

        /// <summary>
        /// MeteorMacAndCheese should implement the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            MeteorMacAndCheese mc = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(mc);
        }

        /// <summary>
        /// Changing Size should notify changes of Size, Name, Price, and Calories properties
        /// </summary>
        /// <param name="size">The size of the Meteor Mac and Cheese</param>
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
            MeteorMacAndCheese mc = new();
            Assert.PropertyChanged(mc, propertyName, () => {
                mc.Size = size;
            });
        }
    }
}
