namespace DataTest
{
    /// <summary>
    /// Unit Tests for TRexTriple
    /// </summary>
    public class TRexTripleUnitTests
    {
        /// <summary>
        /// TRexTriple can be cast as Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            TRexTriple b = new();
            Assert.IsAssignableFrom<Entree>(b);
        }

        /// <summary>
        /// The name should always be "TRexTriple, regardless of how it's served
        /// </summary>
        /// <param name="patties">Number of patties on the TRexTriple</param>
        /// <param name="ketchup">If the TRexTriple contains ketchup</param>
        /// <param name="mustard">If the TRexTriple contains mustard</param>
        /// <param name="pickle">If the TRexTriple contains pickle</param>
        /// <param name="mayo">If the TRexTriple contains mayo</param>
        /// <param name="bbq">If the TRexTriple contains bbq</param>
        /// <param name="onion">If the TRexTriple contains onion</param>
        /// <param name="tomato">If the TRexTriple contains tomato</param>
        /// <param name="lettuce">If the TRexTriple contains lettuce</param>
        /// <param name="americanCheese">If the TRexTriple contains americanCheese</param>
        /// <param name="swissCheese">If the TRexTriple contains swissCheese</param>
        /// <param name="bacon">If the TRexTriple contains bacon</param>
        /// <param name="mushrooms">If the TRexTriple contains mushrooms</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(8, false, true, true, false, true, true, false, true, true, true, true, true, "T-Rex Triple")]
        [InlineData(6, false, false, true, false, false, false, false, true, true, true, true, false, "T-Rex Triple")]
        [InlineData(4, false, true, false, false, false, true, false, false, false, true, true, false, "T-Rex Triple")]
        [InlineData(1, false, true, false, false, false, false, true, true, true, true, true, true, "T-Rex Triple")]
        [InlineData(3, true, true, true, false, true, false, false, false, true, true, true, false, "T-Rex Triple")]
        [InlineData(2, true, true, false, true, true, true, false, true, false, false, false, true, "T-Rex Triple")]
        [InlineData(9, true, false, false, false, true, true, true, true, false, false, false, true, "T-Rex Triple")]
        [InlineData(7, true, true, true, true, true, true, false, true, true, false, true, true, "T-Rex Triple")]
        public void NameShouldBeCorrect(uint patties, bool ketchup, bool mustard, bool pickle, bool mayo, bool bbq, bool onion, bool tomato, bool lettuce, bool americanCheese, bool swissCheese, bool bacon, bool mushrooms, string name)
        {
            TRexTriple b = new();
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
        /// <param name="patties">Number of patties on the TRexTriple</param>
        /// <param name="ketchup">If the TRexTriple contains ketchup</param>
        /// <param name="mustard">If the TRexTriple contains mustard</param>
        /// <param name="pickle">If the TRexTriple contains pickle</param>
        /// <param name="mayo">If the TRexTriple contains mayo</param>
        /// <param name="bbq">If the TRexTriple contains bbq</param>
        /// <param name="onion">If the TRexTriple contains onion</param>
        /// <param name="tomato">If the TRexTriple contains tomato</param>
        /// <param name="lettuce">If the TRexTriple contains lettuce</param>
        /// <param name="americanCheese">If the TRexTriple contains americanCheese</param>
        /// <param name="swissCheese">If the TRexTriple contains swissCheese</param>
        /// <param name="bacon">If the TRexTriple contains bacon</param>
        /// <param name="mushrooms">If the TRexTriple contains mushrooms</param>
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
            TRexTriple b = new();
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
        /// <param name="patties">Number of patties on the TRexTriple</param>
        /// <param name="ketchup">If the TRexTriple contains ketchup</param>
        /// <param name="mustard">If the TRexTriple contains mustard</param>
        /// <param name="pickle">If the TRexTriple contains pickle</param>
        /// <param name="mayo">If the TRexTriple contains mayo</param>
        /// <param name="bbq">If the TRexTriple contains bbq</param>
        /// <param name="onion">If the TRexTriple contains onion</param>
        /// <param name="tomato">If the TRexTriple contains tomato</param>
        /// <param name="lettuce">If the TRexTriple contains lettuce</param>
        /// <param name="americanCheese">If the TRexTriple contains americanCheese</param>
        /// <param name="swissCheese">If the TRexTriple contains swissCheese</param>
        /// <param name="bacon">If the TRexTriple contains bacon</param>
        /// <param name="mushrooms">If the TRexTriple contains mushrooms</param>
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
            TRexTriple b = new();
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
        /// Patties should default to three
        /// </summary>
        [Fact]
        public void PattiesShouldDefaultToThree()
        {
            TRexTriple b = new();
            Assert.Equal(3u, b.Patties);
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
            TRexTriple b = new();
            b.Patties = patties;
            Assert.Equal(patties, b.Patties);
        }

        /// <summary>
        /// Ketchup should default to true
        /// </summary>
        [Fact]
        public void KetchupShouldDefaultToTrue()
        {
            TRexTriple b = new();
            Assert.True(b.Ketchup);
        }

        /// <summary>
        /// Should be able to set Ketchup to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            TRexTriple b = new();
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
            TRexTriple b = new();
            Assert.False(b.Mustard);
        }

        /// <summary>
        /// Should be able to set Mustard to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            TRexTriple b = new();
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
            TRexTriple b = new();
            Assert.True(b.Pickle);
        }

        /// <summary>
        /// Should be able to set Pickle to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            TRexTriple b = new();
            b.Pickle = true;
            Assert.True(b.Pickle);
            b.Pickle = false;
            Assert.False(b.Pickle);
        }

        /// <summary>
        /// Mayo should default to true
        /// </summary>
        [Fact]
        public void MayoShouldDefaultToTrue()
        {
            TRexTriple b = new();
            Assert.True(b.Mayo);
        }

        /// <summary>
        /// Should be able to set Mayo to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            TRexTriple b = new();
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
            TRexTriple b = new();
            Assert.False(b.BBQ);
        }

        /// <summary>
        /// Should be able to set BBQ to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBBQ()
        {
            TRexTriple b = new();
            b.BBQ = true;
            Assert.True(b.BBQ);
            b.BBQ = false;
            Assert.False(b.BBQ);
        }

        /// <summary>
        /// Onion should default to true
        /// </summary>
        [Fact]
        public void OnionShouldDefaultToTrue()
        {
            TRexTriple b = new();
            Assert.True(b.Onion);
        }

        /// <summary>
        /// Should be able to set Onion to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetOnion()
        {
            TRexTriple b = new();
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
            TRexTriple b = new();
            Assert.True(b.Tomato);
        }

        /// <summary>
        /// Should be able to set Tomato to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            TRexTriple b = new();
            b.Tomato = true;
            Assert.True(b.Tomato);
            b.Tomato = false;
            Assert.False(b.Tomato);
        }

        /// <summary>
        /// Lettuce should default to true
        /// </summary>
        [Fact]
        public void LettuceShouldDefaultToTrue()
        {
            TRexTriple b = new();
            Assert.True(b.Lettuce);
        }

        /// <summary>
        /// Should be able to set Lettuce to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            TRexTriple b = new();
            b.Lettuce = true;
            Assert.True(b.Lettuce);
            b.Lettuce = false;
            Assert.False(b.Lettuce);
        }

        /// <summary>
        /// AmericanCheese should default to false
        /// </summary>
        [Fact]
        public void AmericanCheeseShouldDefaultToFalse()
        {
            TRexTriple b = new();
            Assert.False(b.AmericanCheese);
        }

        /// <summary>
        /// Should be able to set AmericanCheese to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetAmericanCheese()
        {
            TRexTriple b = new();
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
            TRexTriple b = new();
            Assert.False(b.SwissCheese);
        }

        /// <summary>
        /// Should be able to set SwissCheese to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetSwissCheese()
        {
            TRexTriple b = new();
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
            TRexTriple b = new();
            Assert.False(b.Bacon);
        }

        /// <summary>
        /// Should be able to set Bacon to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            TRexTriple b = new();
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
            TRexTriple b = new();
            Assert.False(b.Mushrooms);
        }

        /// <summary>
        /// Should be able to set Mushrooms to true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            TRexTriple b = new();
            b.Mushrooms = true;
            Assert.True(b.Mushrooms);
            b.Mushrooms = false;
            Assert.False(b.Mushrooms);
        }
    }
}
