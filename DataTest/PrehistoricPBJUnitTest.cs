namespace DataTest
{
    /// <summary>
    /// Unit Tests for PrehistoricPBJ
    /// </summary>
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

        /// <summary>
        /// Name should always be "Prehistoric PBJ", regardless of how it's served
        /// </summary>
        /// <param name="peanutButter">If the pbj contains peanut butter</param>
        /// <param name="jelly">If the pbj contains jelly</param>
        /// <param name="toasted">If the pbj is toasted</param>
        /// <param name="name">The expected name</param>
        [Theory]
        [InlineData(true, true, true, "Prehistoric PBJ")]
        [InlineData(true, true, false, "Prehistoric PBJ")]
        [InlineData(true, false, true, "Prehistoric PBJ")]
        [InlineData(true, false, false, "Prehistoric PBJ")]
        [InlineData(false, true, true, "Prehistoric PBJ")]
        [InlineData(false, false, true, "Prehistoric PBJ")]
        [InlineData(false, true, false, "Prehistoric PBJ")]
        [InlineData(false, false, false, "Prehistoric PBJ")]
        public void NameShouldBeCorrect(bool peanutButter, bool jelly, bool toasted, string name)
        {
            PrehistoricPBJ pbj = new() 
            { 
                PeanutButter = peanutButter,
                Jelly = jelly,
                Toasted = toasted
            };
            Assert.Equal(name, pbj.Name);
        }

        /// <summary>
        /// PrehistoricPBJ can be cast as Entree
        /// </summary>
        [Fact]
        public void ShouldInheritFromEntree()
        {
            PrehistoricPBJ pbj = new();
            Assert.IsAssignableFrom<Entree>(pbj);
        }

        /// <summary>
        /// PrehistoricPBJ should implement the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            PrehistoricPBJ pbj = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pbj);
        }

        /// <summary>
        /// Changing PeanutButter should notify changes of PeanutButter and Calories properties
        /// </summary>
        /// <param name="peanutButter">Indicates the PBJ is served with peanut butter</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "PeanutButter")]
        [InlineData(false, "PeanutButter")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingPeanutButterShouldNotifyOfPropertyChanges(bool peanutButter, string propertyName)
        {
            PrehistoricPBJ pbj = new();
            pbj.PeanutButter = !peanutButter; // Ensures the property will always be set
            Assert.PropertyChanged(pbj, propertyName, () => {
                pbj.PeanutButter = peanutButter;
            });
        }

        /// <summary>
        /// Changing Jelly should notify changes of Jelly and Calories properties
        /// </summary>
        /// <param name="jelly">Indicates the PBJ is served with jelly</param>
        /// <param name="propertyName">The property that should be notified</param>
        [Theory]
        [InlineData(true, "Jelly")]
        [InlineData(false, "Jelly")]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ChangingJellyShouldNotifyOfPropertyChanges(bool jelly, string propertyName)
        {
            PrehistoricPBJ pbj = new();
            pbj.Jelly = !jelly; // Ensures the property will always be set
            Assert.PropertyChanged(pbj, propertyName, () => {
                pbj.Jelly = jelly;
            });
        }

        /// <summary>
        /// Changing Toasted should notify changes of Toasted property
        /// </summary>
        /// <param name="toasted">Indicates the PBJ is toasted</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ChangingToastedShouldNotifyOfPropertyChanges(bool toasted)
        {
            PrehistoricPBJ pbj = new();
            pbj.Toasted = !toasted; // Ensures the property will always be set
            Assert.PropertyChanged(pbj, "Toasted", () => {
                pbj.Toasted = toasted;
            });
        }

        /// <summary>
        /// PrehistoricPBJ can be cast as MenuItem
        /// </summary>
        [Fact]
        public void ShouldInheritFromMenuItem()
        {
            PrehistoricPBJ pbj = new();
            Assert.IsAssignableFrom<MenuItem>(pbj);
        }

        /// <summary>
        /// Updating PeanutButter should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForPeanutButter()
        {
            PrehistoricPBJ pbj = new();
            string instruction = "Hold Peanut Butter"; // Ensures string will be the same in both asserts
            pbj.PeanutButter = false;
            Assert.Contains<string>(instruction, pbj.SpecialInstructions);
            pbj.PeanutButter = true;
            Assert.DoesNotContain<string>(instruction, pbj.SpecialInstructions);
        }

        /// <summary>
        /// Updating Jelly should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForJelly()
        {
            PrehistoricPBJ pbj = new();
            string instruction = "Hold Jelly"; // Ensures string will be the same in both asserts
            pbj.Jelly = false;
            Assert.Contains<string>(instruction, pbj.SpecialInstructions);
            pbj.Jelly = true;
            Assert.DoesNotContain<string>(instruction, pbj.SpecialInstructions);
        }

        /// <summary>
        /// Updating Toasted should apply the appropriate change to SpecialInstructions
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeCorrectForToasted()
        {
            PrehistoricPBJ pbj = new();
            string instruction = "Not Toasted"; // Ensures string will be the same in both asserts
            pbj.Toasted = false;
            Assert.Contains<string>(instruction, pbj.SpecialInstructions);
            pbj.Toasted = true;
            Assert.DoesNotContain<string>(instruction, pbj.SpecialInstructions);
        }
    }
}