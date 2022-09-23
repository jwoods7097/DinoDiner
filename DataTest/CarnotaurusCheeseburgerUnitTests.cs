﻿namespace DataTest
{
    /// <summary>
    /// Unit Tests for CarnotaurusCheeseburger
    /// </summary>
    public class CarnotaurusCheeseburgerUnitTests
    {
        /// <summary>
        /// CarnotaurusCheeseburger can be cast as Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            CarnotaurusCheeseburger b = new();
            Assert.IsAssignableFrom<Entree>(b);
        }

        /// <summary>
        /// The name should always be "CarnotaurusCheeseburger, regardless of how it's served
        /// </summary>
        /// <param name="patties">Number of patties on the CarnotaurusCheeseburger</param>
        /// <param name="ketchup">If the CarnotaurusCheeseburger contains ketchup</param>
        /// <param name="mustard">If the CarnotaurusCheeseburger contains mustard</param>
        /// <param name="pickle">If the CarnotaurusCheeseburger contains pickle</param>
        /// <param name="mayo">If the CarnotaurusCheeseburger contains mayo</param>
        /// <param name="bbq">If the CarnotaurusCheeseburger contains bbq</param>
        /// <param name="onion">If the CarnotaurusCheeseburger contains onion</param>
        /// <param name="tomato">If the CarnotaurusCheeseburger contains tomato</param>
        /// <param name="lettuce">If the CarnotaurusCheeseburger contains lettuce</param>
        /// <param name="americanCheese">If the CarnotaurusCheeseburger contains americanCheese</param>
        /// <param name="swissCheese">If the CarnotaurusCheeseburger contains swissCheese</param>
        /// <param name="bacon">If the CarnotaurusCheeseburger contains bacon</param>
        /// <param name="mushrooms">If the CarnotaurusCheeseburger contains mushrooms</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(8, false, true, true, false, true, true, false, true, true, true, true, true, "Carnotaurus Cheeseburger")]
        [InlineData(6, false, false, true, false, false, false, false, true, true, true, true, false, "Carnotaurus Cheeseburger")]
        [InlineData(4, false, true, false, false, false, true, false, false, false, true, true, false, "Carnotaurus Cheeseburger")]
        [InlineData(1, false, true, false, false, false, false, true, true, true, true, true, true, "Carnotaurus Cheeseburger")]
        [InlineData(3, true, true, true, false, true, false, false, false, true, true, true, false, "Carnotaurus Cheeseburger")]
        [InlineData(2, true, true, false, true, true, true, false, true, false, false, false, true, "Carnotaurus Cheeseburger")]
        [InlineData(9, true, false, false, false, true, true, true, true, false, false, false, true, "Carnotaurus Cheeseburger")]
        [InlineData(7, true, true, true, true, true, true, false, true, true, false, true, true, "Carnotaurus Cheeseburger")]
        public void NameShouldBeCorrect(uint patties, bool ketchup, bool mustard, bool pickle, bool mayo, bool bbq, bool onion, bool tomato, bool lettuce, bool americanCheese, bool swissCheese, bool bacon, bool mushrooms, string name)
        {
            CarnotaurusCheeseburger b = new();
            b.Patties = patties;
            b.Ketchup = ketchup;
            b.Mustard = mustard;
            b.Pickle = pickle;
            b.Mayo = mayo;
            b.BBQ = bbq;
            b.Onion = onion;
            b.Tomato = tomato;
            b.Lettuce = lettuce;
            b.AmericanCheese = americanCheese;
            b.SwissCheese = swissCheese;
            b.Bacon = bacon;
            b.Mushrooms = mushrooms;
            Assert.Equal(name, b.Name);
        }

        /// <summary>
        /// The price should vary based on how it's served
        /// </summary>
        /// <param name="patties">Number of patties on the CarnotaurusCheeseburger</param>
        /// <param name="ketchup">If the CarnotaurusCheeseburger contains ketchup</param>
        /// <param name="mustard">If the CarnotaurusCheeseburger contains mustard</param>
        /// <param name="pickle">If the CarnotaurusCheeseburger contains pickle</param>
        /// <param name="mayo">If the CarnotaurusCheeseburger contains mayo</param>
        /// <param name="bbq">If the CarnotaurusCheeseburger contains bbq</param>
        /// <param name="onion">If the CarnotaurusCheeseburger contains onion</param>
        /// <param name="tomato">If the CarnotaurusCheeseburger contains tomato</param>
        /// <param name="lettuce">If the CarnotaurusCheeseburger contains lettuce</param>
        /// <param name="americanCheese">If the CarnotaurusCheeseburger contains americanCheese</param>
        /// <param name="swissCheese">If the CarnotaurusCheeseburger contains swissCheese</param>
        /// <param name="bacon">If the CarnotaurusCheeseburger contains bacon</param>
        /// <param name="mushrooms">If the CarnotaurusCheeseburger contains mushrooms</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(8, false, true, true, false, true, true, false, true, true, true, true, true, 8 * 1.50 + 0.20 + 0.20 + 0.10 + 0.40 + 0.30 + 0.25 + 0.25 + 0.50 + 0.40)]
        [InlineData(6, false, false, true, false, false, false, false, true, true, true, true, false, 6 * 1.50 + 0.20 + 0.30 + 0.25 + 0.25 + 0.50)]
        [InlineData(4, false, true, false, false, false, true, false, false, false, true, true, false, 4 * 1.50 + 0.20 + 0.40 + 0.25 + 0.50)]
        [InlineData(1, false, true, false, false, false, false, true, true, true, true, true, true, 1 * 1.50 + 0.20 + 0.40 + 0.30 + 0.25 + 0.25 + 0.50 + 0.40)]
        [InlineData(3, true, true, true, false, true, false, false, false, true, true, true, false, 3 * 1.50 + 0.20 + 0.20 + 0.20 + 0.10 + 0.25 + 0.25 + 0.50)]
        [InlineData(2, true, true, false, true, true, true, false, true, false, false, false, true, 2 * 1.50 + 0.20 + 0.20 + 0.20 + 0.10 + 0.40 + 0.30 + 0.40)]
        [InlineData(9, true, false, false, false, true, true, true, true, false, false, false, true, 9 * 1.50 + 0.20 + 0.10 + 0.40 + 0.40 + 0.30 + 0.40)]
        [InlineData(7, true, true, true, true, true, true, false, true, true, false, true, true, 7 * 1.50 + 0.20 + 0.20 + 0.20 + 0.20 + 0.10 + 0.40 + 0.30 + 0.25 + 0.50 + 0.40)]
        public void PriceShouldBeCorrect(uint patties, bool ketchup, bool mustard, bool pickle, bool mayo, bool bbq, bool onion, bool tomato, bool lettuce, bool americanCheese, bool swissCheese, bool bacon, bool mushrooms, decimal price)
        {
            CarnotaurusCheeseburger b = new();
            b.Patties = patties;
            b.Ketchup = ketchup;
            b.Mustard = mustard;
            b.Pickle = pickle;
            b.Mayo = mayo;
            b.BBQ = bbq;
            b.Onion = onion;
            b.Tomato = tomato;
            b.Lettuce = lettuce;
            b.AmericanCheese = americanCheese;
            b.SwissCheese = swissCheese;
            b.Bacon = bacon;
            b.Mushrooms = mushrooms;
            Assert.Equal(price, b.Price);
        }

        /// <summary>
        /// The calories should vary based on how it's served
        /// </summary>
        /// <param name="patties">Number of patties on the CarnotaurusCheeseburger</param>
        /// <param name="ketchup">If the CarnotaurusCheeseburger contains ketchup</param>
        /// <param name="mustard">If the CarnotaurusCheeseburger contains mustard</param>
        /// <param name="pickle">If the CarnotaurusCheeseburger contains pickle</param>
        /// <param name="mayo">If the CarnotaurusCheeseburger contains mayo</param>
        /// <param name="bbq">If the CarnotaurusCheeseburger contains bbq</param>
        /// <param name="onion">If the CarnotaurusCheeseburger contains onion</param>
        /// <param name="tomato">If the CarnotaurusCheeseburger contains tomato</param>
        /// <param name="lettuce">If the CarnotaurusCheeseburger contains lettuce</param>
        /// <param name="americanCheese">If the CarnotaurusCheeseburger contains americanCheese</param>
        /// <param name="swissCheese">If the CarnotaurusCheeseburger contains swissCheese</param>
        /// <param name="bacon">If the CarnotaurusCheeseburger contains bacon</param>
        /// <param name="mushrooms">If the CarnotaurusCheeseburger contains mushrooms</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(8, false, true, true, false, true, true, false, true, true, true, true, true, 8 * 204 + 3 + 7 + 29 + 44 + 5 + 104 + 106 + 43 + 4)]
        [InlineData(6, false, false, true, false, false, false, false, true, true, true, true, false, 6 * 204 + 7 + 5 + 104 + 106 + 43)]
        [InlineData(4, false, true, false, false, false, true, false, false, false, true, true, false, 4 * 204 + 3 + 44 + 106 + 43)]
        [InlineData(1, false, true, false, false, false, false, true, true, true, true, true, true, 1 * 204 + 3 + 22 + 5 + 104 + 106 + 43 + 4)]
        [InlineData(3, true, true, true, false, true, false, false, false, true, true, true, false, 3 * 204 + 19 + 3 + 7 + 29 + 104 + 106 + 43)]
        [InlineData(2, true, true, false, true, true, true, false, true, false, false, false, true, 2 * 204 + 19 + 3 + 94 + 29 + 44 + 5 + 4)]
        [InlineData(9, true, false, false, false, true, true, true, true, false, false, false, true, 9 * 204 + 19 + 29 + 44 + 22 + 5 + 4)]
        [InlineData(7, true, true, true, true, true, true, false, true, true, false, true, true, 7 * 204 + 19 + 3 + 7 + 94 + 29 + 44 + 5 + 104 + 43 + 4)]
        public void CaloriesShouldBeCorrect(uint patties, bool ketchup, bool mustard, bool pickle, bool mayo, bool bbq, bool onion, bool tomato, bool lettuce, bool americanCheese, bool swissCheese, bool bacon, bool mushrooms, uint calories)
        {
            CarnotaurusCheeseburger b = new();
            b.Patties = patties;
            b.Ketchup = ketchup;
            b.Mustard = mustard;
            b.Pickle = pickle;
            b.Mayo = mayo;
            b.BBQ = bbq;
            b.Onion = onion;
            b.Tomato = tomato;
            b.Lettuce = lettuce;
            b.AmericanCheese = americanCheese;
            b.SwissCheese = swissCheese;
            b.Bacon = bacon;
            b.Mushrooms = mushrooms;
            Assert.Equal(calories, b.Calories);
        }

        /// <summary>
        /// Patties should default to one
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToOne()
        {
            CarnotaurusCheeseburger b = new();
            Assert.Equal(1u, b.Patties);
        }

        /// <summary>
        /// Should be able to set patties
        /// </summary>
        /// <param name="patties">Number of patties</param>
        [Theory]
        [InlineData(8)]
        [InlineData(6)]
        [InlineData(4)]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(2)]
        [InlineData(9)]
        [InlineData(7)]
        public void ShouldBeAbleToSetPatties(uint patties)
        {
            CarnotaurusCheeseburger b = new();
            b.Patties = patties;
            Assert.Equal(patties, b.Patties);
        }

        /// <summary>
        /// Ketchup should default to true
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger b = new();
            Assert.True(b.Ketchup);
        }

        /// <summary>
        /// Should be able to set Ketchup to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            CarnotaurusCheeseburger b = new();
            b.Ketchup = true;
            Assert.True(b.Ketchup);
            b.Ketchup = false;
            Assert.False(b.Ketchup);
        }

        /// <summary>
        /// Mustard should default to false
        /// </summary>
        [Fact]
        public void MustardShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger b = new();
            Assert.False(b.Mustard);
        }

        /// <summary>
        /// Should be able to set Mustard to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            CarnotaurusCheeseburger b = new();
            b.Mustard = true;
            Assert.True(b.Mustard);
            b.Mustard = false;
            Assert.False(b.Mustard);
        }

        /// <summary>
        /// Pickle should default to true
        /// </summary>
        [Fact]
        public void PickleShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger b = new();
            Assert.True(b.Pickle);
        }

        /// <summary>
        /// Should be able to set Pickle to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            CarnotaurusCheeseburger b = new();
            b.Pickle = true;
            Assert.True(b.Pickle);
            b.Pickle = false;
            Assert.False(b.Pickle);
        }

        /// <summary>
        /// Mayo should default to false
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger b = new();
            Assert.False(b.Mayo);
        }

        /// <summary>
        /// Should be able to set Mayo to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            CarnotaurusCheeseburger b = new();
            b.Mayo = true;
            Assert.True(b.Mayo);
            b.Mayo = false;
            Assert.False(b.Mayo);
        }

        /// <summary>
        /// BBQ should default to false
        /// </summary>
        [Fact]
        public void BBQShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger b = new();
            Assert.False(b.BBQ);
        }

        /// <summary>
        /// Should be able to set BBQ to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            CarnotaurusCheeseburger b = new();
            b.BBQ = true;
            Assert.True(b.BBQ);
            b.BBQ = false;
            Assert.False(b.BBQ);
        }

        /// <summary>
        /// Onion should default to false
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger b = new();
            Assert.False(b.Onion);
        }

        /// <summary>
        /// Should be able to set Onion to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            CarnotaurusCheeseburger b = new();
            b.Onion = true;
            Assert.True(b.Onion);
            b.Onion = false;
            Assert.False(b.Onion);
        }

        /// <summary>
        /// Tomato should default to true
        /// </summary>
        [Fact]
        public void TomatoShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger b = new();
            Assert.True(b.Tomato);
        }

        /// <summary>
        /// Should be able to set Tomato to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            CarnotaurusCheeseburger b = new();
            b.Tomato = true;
            Assert.True(b.Tomato);
            b.Tomato = false;
            Assert.False(b.Tomato);
        }

        /// <summary>
        /// Lettuce should default to false
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger b = new();
            Assert.False(b.Lettuce);
        }

        /// <summary>
        /// Should be able to set Lettuce to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            CarnotaurusCheeseburger b = new();
            b.Lettuce = true;
            Assert.True(b.Lettuce);
            b.Lettuce = false;
            Assert.False(b.Lettuce);
        }

        /// <summary>
        /// AmericanCheese should default to true
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToTrue()
        {
            CarnotaurusCheeseburger b = new();
            Assert.True(b.AmericanCheese);
        }

        /// <summary>
        /// Should be able to set AmericanCheese to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            CarnotaurusCheeseburger b = new();
            b.AmericanCheese = true;
            Assert.True(b.AmericanCheese);
            b.AmericanCheese = false;
            Assert.False(b.AmericanCheese);
        }

        /// <summary>
        /// SwissCheese should default to false
        /// </summary>
        [Fact]
        public void SwissCheeseShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger b = new();
            Assert.False(b.SwissCheese);
        }

        /// <summary>
        /// Should be able to set SwissCheese to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            CarnotaurusCheeseburger b = new();
            b.SwissCheese = true;
            Assert.True(b.SwissCheese);
            b.SwissCheese = false;
            Assert.False(b.SwissCheese);
        }

        /// <summary>
        /// Bacon should default to false
        /// </summary>
        [Fact]
        public void BaconShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger b = new();
            Assert.False(b.Bacon);
        }

        /// <summary>
        /// Should be able to set Bacon to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            CarnotaurusCheeseburger b = new();
            b.Bacon = true;
            Assert.True(b.Bacon);
            b.Bacon = false;
            Assert.False(b.Bacon);
        }

        /// <summary>
        /// Mushrooms should default to false
        /// </summary>
        [Fact]
        public void MushroomsShouldDefaultToFalse()
        {
            CarnotaurusCheeseburger b = new();
            Assert.False(b.Mushrooms);
        }

        /// <summary>
        /// Should be able to set Mushrooms to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            CarnotaurusCheeseburger b = new();
            b.Mushrooms = true;
            Assert.True(b.Mushrooms);
            b.Mushrooms = false;
            Assert.False(b.Mushrooms);
        }
    }
}
