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

        /// <summary>
        /// CarnotaurusCheeseburger should implement the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            CarnotaurusCheeseburger b = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(b);
        }

        /// <summary>
        /// Changing Patties should notify changes of Patties, Price, and Calories properties
        /// </summary>
        /// <param name="patties">How many patties are on the burger</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(2, "Patties")]
        [InlineData(2, "Calories")]
        [InlineData(2, "Price")]
        [InlineData(3, "Patties")]
        [InlineData(3, "Calories")]
        [InlineData(3, "Price")]
        [InlineData(4, "Patties")]
        [InlineData(4, "Calories")]
        [InlineData(4, "Price")]
        public void ChangingPattiesShouldNotifyOfPropertyChanges(uint patties, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            Assert.PropertyChanged(b, propertyName, () => {
                b.Patties = patties;
            });
        }

        /// <summary>
        /// Changing Ketchup should notify changes of Ketchup, Price, and Calories properties
        /// </summary>
        /// <param name="ketchup">Indicates the burger is served with ketchup</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Ketchup")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "Ketchup")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingKetchupShouldNotifyOfPropertyChanges(bool ketchup, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.Ketchup = !ketchup; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.Ketchup = ketchup;
            });
        }

        /// <summary>
        /// Changing Mustard should notify changes of Mustard, Price, and Calories properties
        /// </summary>
        /// <param name="mustard">Indicates the burger is served with mustard</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Mustard")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "Mustard")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingMustardShouldNotifyOfPropertyChanges(bool mustard, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.Mustard = !mustard; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.Mustard = mustard;
            });
        }

        /// <summary>
        /// Changing Pickle should notify changes of Pickle, Price, and Calories properties
        /// </summary>
        /// <param name="pickle">Indicates the burger is served with pickles</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Pickle")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "Pickle")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingPickleShouldNotifyOfPropertyChanges(bool pickle, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.Pickle = !pickle; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.Pickle = pickle;
            });
        }

        /// <summary>
        /// Changing Mayo should notify changes of Mayo, Price, and Calories properties
        /// </summary>
        /// <param name="mayo">Indicates the burger is served with mayo</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Mayo")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "Mayo")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingMayoShouldNotifyOfPropertyChanges(bool mayo, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.Mayo = !mayo; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.Mayo = mayo;
            });
        }

        /// <summary>
        /// Changing BBQ should notify changes of BBQ, Price, and Calories properties
        /// </summary>
        /// <param name="bbq">Indicates the burger is served with BBQ sauce</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "BBQ")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "BBQ")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingBBQShouldNotifyOfPropertyChanges(bool bbq, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.BBQ = !bbq; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.BBQ = bbq;
            });
        }

        /// <summary>
        /// Changing Onion should notify changes of Onion, Price, and Calories properties
        /// </summary>
        /// <param name="onion">Indicates the burger is served with onion</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Onion")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "Onion")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingOnionShouldNotifyOfPropertyChanges(bool onion, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.Onion = !onion; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.Onion = onion;
            });
        }

        /// <summary>
        /// Changing Tomato should notify changes of Tomato, Price, and Calories properties
        /// </summary>
        /// <param name="tomato">Indicates the burger is served with tomato</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Tomato")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "Tomato")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingTomatoShouldNotifyOfPropertyChanges(bool tomato, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.Tomato = !tomato; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.Tomato = tomato;
            });
        }

        /// <summary>
        /// Changing Lettuce should notify changes of Lettuce, Price, and Calories properties
        /// </summary>
        /// <param name="lettuce">Indicates the burger is served with lettuce</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Lettuce")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "Lettuce")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingLettuceShouldNotifyOfPropertyChanges(bool lettuce, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.Lettuce = !lettuce; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.Lettuce = lettuce;
            });
        }

        /// <summary>
        /// Changing AmericanCheese should notify changes of AmericanCheese, Price, and Calories properties
        /// </summary>
        /// <param name="americanCheese">Indicates the burger is served with American cheese</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "AmericanCheese")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "AmericanCheese")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingAmericanCheeseShouldNotifyOfPropertyChanges(bool americanCheese, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.AmericanCheese = !americanCheese; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.AmericanCheese = americanCheese;
            });
        }

        /// <summary>
        /// Changing SwissCheese should notify changes of SwissCheese, Price, and Calories properties
        /// </summary>
        /// <param name="swissCheese">Indicates the burger is served with Swiss cheese</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "SwissCheese")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "SwissCheese")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingSwissCheeseShouldNotifyOfPropertyChanges(bool swissCheese, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.SwissCheese = !swissCheese; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.SwissCheese = swissCheese;
            });
        }

        /// <summary>
        /// Changing Bacon should notify changes of Bacon, Price, and Calories properties
        /// </summary>
        /// <param name="bacon">Indicates the burger is served with bacon</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Bacon")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "Bacon")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingBaconShouldNotifyOfPropertyChanges(bool bacon, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.Bacon = !bacon; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.Bacon = bacon;
            });
        }

        /// <summary>
        /// Changing Mushrooms should notify changes of Mushrooms, Price, and Calories properties
        /// </summary>
        /// <param name="mushrooms">Indicates the burger is served with mushrooms</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Mushrooms")]
        [InlineData(true, "Calories")]
        [InlineData(true, "Price")]
        [InlineData(false, "Mushrooms")]
        [InlineData(false, "Calories")]
        [InlineData(false, "Price")]
        public void ChangingMushroomsShouldNotifyOfPropertyChanges(bool mushrooms, string propertyName)
        {
            CarnotaurusCheeseburger b = new();
            b.Mushrooms = !mushrooms; // Ensures the property will always be set
            Assert.PropertyChanged(b, propertyName, () => {
                b.Mushrooms = mushrooms;
            });
        }

        /// <summary>
        /// CarnotaurusCheeseburger can be cast as MenuItem
        /// </summary>
        [Fact]
        public void ShouldInheritFromMenuItem()
        {
            CarnotaurusCheeseburger b = new();
            Assert.IsAssignableFrom<MenuItem>(b);
        }

        /// <summary>
        /// Updating Patties should apply the appropriate change to SpecialInstructions
        /// </summary>
        /// <param name="patties">The number of patties served on the burger</param>
        /// <param name="instruction">The expected instruction in SpecialInstructions</param>
        [Theory]
        [InlineData(0, "0 Patties")]
        [InlineData(1, "")]
        [InlineData(2, "2 Patties")]
        [InlineData(3, "3 Patties")]
        [InlineData(4, "4 Patties")]
        [InlineData(5, "5 Patties")]
        [InlineData(6, "6 Patties")]
        [InlineData(7, "7 Patties")]
        public void SpecialInstructionsShouldBeCorrectForPatties(uint patties, string instruction)
        {
            CarnotaurusCheeseburger b = new();
            b.Patties = patties;
            if (instruction == "")
            {
                Assert.DoesNotContain<string>(b.SpecialInstructions, item => item.Contains("Patt"));
            }
            else
            {
                Assert.Contains<string>(b.SpecialInstructions, item => item.Contains("Patt"));
            }
            b.Patties = 1;
            Assert.DoesNotContain<string>(b.SpecialInstructions, item => item.Contains("Patt"));
        }

        /// <summary>
        /// Updating Ketchup should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForKetchup()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Hold Ketchup"; // Ensures string will be the same in both asserts
            b.Ketchup = false;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.Ketchup = true;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating Mustard should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForMustard()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Add Mustard"; // Ensures string will be the same in both asserts
            b.Mustard = true;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.Mustard = false;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating Pickle should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForPickle()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Hold Pickle"; // Ensures string will be the same in both asserts
            b.Pickle = false;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.Pickle = true;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating Mayo should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForMayo()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Add Mayo"; // Ensures string will be the same in both asserts
            b.Mayo = true;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.Mayo = false;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating BBQ should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForBBQ()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Add BBQ"; // Ensures string will be the same in both asserts
            b.BBQ = true;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.BBQ = false;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating Onion should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForOnion()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Add Onion"; // Ensures string will be the same in both asserts
            b.Onion = true;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.Onion = false;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating Tomato should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForTomato()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Hold Tomato"; // Ensures string will be the same in both asserts
            b.Tomato = false;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.Tomato = true;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating Lettuce should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForLettuce()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Add Lettuce"; // Ensures string will be the same in both asserts
            b.Lettuce = true;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.Lettuce = false;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating AmericanCheese should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForAmericanCheese()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Hold American Cheese"; // Ensures string will be the same in both asserts
            b.AmericanCheese = false;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.AmericanCheese = true;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating SwissCheese should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForSwissCheese()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Add Swiss Cheese"; // Ensures string will be the same in both asserts
            b.SwissCheese = true;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.SwissCheese = false;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating Bacon should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForBacon()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Add Bacon"; // Ensures string will be the same in both asserts
            b.Bacon = true;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.Bacon = false;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// Updating Mushrooms should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForMushrooms()
        {
            CarnotaurusCheeseburger b = new();
            string instruction = "Add Mushrooms"; // Ensures string will be the same in both asserts
            b.Mushrooms = true;
            Assert.Contains<string>(instruction, b.SpecialInstructions);
            b.Mushrooms = false;
            Assert.DoesNotContain<string>(instruction, b.SpecialInstructions);
        }

        /// <summary>
        /// CarnotaurusCheeseburger can be cast as Burger
        /// </summary>
        [Fact]
        public void ShouldInheritFromBurger()
        {
            CarnotaurusCheeseburger b = new();
            Assert.IsAssignableFrom<Burger>(b);
        }
    }
}
