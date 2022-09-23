﻿namespace DataTest
{
    /// <summary>
    /// Unit Tests for VelociWraptor
    /// </summary>
    public class VelociWraptorUnitTests
    {
        /// <summary>
        /// VelociWraptor can be cast as Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            VelociWraptor vw = new();
            Assert.IsAssignableFrom<Entree>(vw);
        }

        /// <summary>
        /// Name should always be "Veloci-Wraptor", regardless of how it's served
        /// </summary>
        /// <param name="dressing">If the VelociWraptor contains dressing</param>
        /// <param name="cheese">If the VelociWraptor contains cheese</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(true, true, "Veloci-Wraptor")]
        [InlineData(true, false, "Veloci-Wraptor")]
        [InlineData(false, true, "Veloci-Wraptor")]
        [InlineData(false, false, "Veloci-Wraptor")]
        public void NameShouldBeCorrect(bool dressing, bool cheese, string name)
        {
            VelociWraptor vw = new()
            {
                Dressing = dressing,
                Cheese = cheese
            };
            Assert.Equal(name, vw.Name);
        }

        /// <summary>
        /// Price should always be $6.25, regardless of how it's served
        /// </summary>
        /// <param name="dressing">If the VelociWraptor contains dressing</param>
        /// <param name="cheese">If the VelociWraptor contains cheese</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(true, true, 6.25)]
        [InlineData(true, false, 6.25)]
        [InlineData(false, true, 6.25)]
        [InlineData(false, false, 6.25)]
        public void PriceShouldBeCorrect(bool dressing, bool cheese, decimal price)
        {
            VelociWraptor vw = new()
            {
                Dressing = dressing,
                Cheese = cheese
            };
            Assert.Equal(price, vw.Price);
        }

        /// <summary>
        /// Calories should vary depending on how the VelociWraptor is served
        /// </summary>
        /// <param name="dressing">If the VelociWraptor contains dressing</param>
        /// <param name="cheese">If the VelociWraptor contains cheese</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(true, true, 732)]
        [InlineData(true, false, 732 - 22)]
        [InlineData(false, true, 732 - 94)]
        [InlineData(false, false, 732 - 22 - 94)]
        public void CaloriesShouldBeCorrect(bool dressing, bool cheese, uint calories)
        {
            VelociWraptor vw = new()
            {
                Dressing = dressing,
                Cheese = cheese
            };
            Assert.Equal(calories, vw.Calories);
        }

        /// <summary>
        /// Dressing should default to true
        /// </summary>
        [Fact]
        public void DressingShouldDefaultToTrue()
        {
            VelociWraptor vw = new();
            Assert.True(vw.Dressing);
        }

        /// <summary>
        /// Should be able to set Dressing to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetDressing()
        {
            VelociWraptor vw = new();
            vw.Dressing = false;
            Assert.False(vw.Dressing);
            vw.Dressing = true;
            Assert.True(vw.Dressing);
        }

        /// <summary>
        /// Cheese should default to true
        /// </summary>
        [Fact]
        public void CheeseShouldDefaultToTrue()
        {
            VelociWraptor vw = new();
            Assert.True(vw.Cheese);
        }

        /// <summary>
        /// Should be able to set Cheese to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            VelociWraptor vw = new();
            vw.Cheese = false;
            Assert.False(vw.Cheese);
            vw.Cheese = true;
            Assert.True(vw.Cheese);
        }
    }
}
