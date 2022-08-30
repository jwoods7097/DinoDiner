namespace DataTest
{
    public class PrehistoricPBJUnitTest
    {
        /// <summary>
        /// PeanutButter should default to true
        /// </summary>
        [Fact]
        public void PeanutButterShouldDefaultToTrue()
        {
            PrehistoricPBJ pbj = new();
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Should be able to set PeanutButter to
        /// true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetPeanutButter()
        {
            PrehistoricPBJ pbj = new();
            pbj.PeanutButter = false;
            Assert.False(pbj.PeanutButter);
            pbj.PeanutButter = true;
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Jelly should default to true
        /// </summary>
        [Fact]
        public void JellyShouldDefaultToTrue()
        {
            PrehistoricPBJ pbj = new();
            Assert.True(pbj.Jelly);
        }

        /// <summary>
        /// Should be able to set Jelly to
        /// true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetJelly()
        {
            PrehistoricPBJ pbj = new();
            pbj.PeanutButter = false;
            Assert.False(pbj.PeanutButter);
            pbj.PeanutButter = true;
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Toasted should default to true
        /// </summary>
        [Fact]
        public void ToastedShouldDefaultToTrue()
        {
            PrehistoricPBJ pbj = new();
            Assert.True(pbj.Toasted);
        }

        /// <summary>
        /// Should be able to set Toasted to
        /// true or false
        /// </summary>
        [Fact]
        public void ShouldBeAbleToSetToasted()
        {
            PrehistoricPBJ pbj = new();
            pbj.PeanutButter = false;
            Assert.False(pbj.PeanutButter);
            pbj.PeanutButter = true;
            Assert.True(pbj.PeanutButter);
        }

        /// <summary>
        /// Price should always be $3.75
        /// </summary>
        /// <param name="peanutButter">If pbj contains peanut butter</param>
        /// <param name="jelly">If pbj contains jelly</param>
        /// <param name="toasted">If pbj is toasted</param>
        [InlineData(true, true, true)]
        [InlineData(true, true, false)]
        [InlineData(true, false, true)]
        [InlineData(false, true, true)]
        [InlineData(false, false, true)]
        [InlineData(true, false, false)]
        [InlineData(false, true, false)]
        [InlineData(false, false, false)]
        [Theory]
        public void PriceShouldBeCorrect(bool peanutButter, bool jelly, bool toasted)
        {
            PrehistoricPBJ pbj = new()
            {
                PeanutButter = peanutButter,
                Jelly = jelly,
                Toasted = toasted
            };
            Assert.Equal(3.75m, pbj.Price);
        }

        /// <summary>
        /// Calories varies based on how the PBJ is made
        /// </summary>
        /// <details>
        /// 148 calories for the bread
        /// 188 calories for the peanut butter 
        /// 62 calories for the jelly
        /// </details>
        /// <param name="peanutButter">If pbj contains peanut butter</param>
        /// <param name="jelly">If pbj contains jelly</param>
        /// <param name="toasted">If pbj is toasted</param>
        /// <param name="calories">The expected calories</param>
        [InlineData(true, true, true, 148+188+62)]
        [InlineData(true, true, false, 148+188+62)]
        [InlineData(true, false, true, 148+188)]
        [InlineData(false, true, true, 148+62)]
        [InlineData(false, false, true, 148)]
        [InlineData(true, false, false, 148+188)]
        [InlineData(false, true, false, 148+62)]
        [InlineData(false, false, false, 148)]
        [Theory]
        public void CaloriesShouldBeCorrect(bool peanutButter, bool jelly, bool toasted, uint calories)
        {
            PrehistoricPBJ pbj = new()
            {
                PeanutButter = peanutButter,
                Jelly = jelly,
                Toasted = toasted
            };
            Assert.Equal(calories, pbj.Calories);
        }
    }
}