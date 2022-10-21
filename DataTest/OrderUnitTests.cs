namespace DataTest
{
    /// <summary>
    /// Unit Tests for Order
    /// </summary>
    public class OrderUnitTests
    {
        /// <summary>
        /// Should be able to add items to the order
        /// </summary>
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            Order o = new();
            PrehistoricPBJ pbj = new();
            Plilosoda ps = new();
            Fryceritops ft = new();
            o.Add(pbj);
            o.Add(ps);
            o.Add(ft);
            Assert.Contains<MenuItem>(pbj, o);
            Assert.Contains<MenuItem>(ps, o);
            Assert.Contains<MenuItem>(ft, o);
        }

        /// <summary>
        /// Should be able to remove items from the order
        /// </summary>
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            Order o = new();
            PrehistoricPBJ pbj = new();
            Plilosoda ps = new();
            Fryceritops ft = new();
            o.Add(pbj);
            o.Add(ps);
            o.Add(ft);
            o.Remove(pbj);
            Assert.DoesNotContain<MenuItem>(pbj, o);
            o.Remove(ps);
            Assert.DoesNotContain<MenuItem>(ps, o);
            o.Remove(ft);
            Assert.DoesNotContain<MenuItem>(ft, o);
        }

        /// <summary>
        /// Order should implement the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            Order o = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(o);
        }

        /// <summary>
        /// Order should implement the INotifyCollectionChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyCollectionChanged()
        {
            Order o = new();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(o);
        }

        /// <summary>
        /// The CollectionChanged event should be triggered when an item is added to the order
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCollectionChangedOnAdd()
        {
            Order o = new();
            NotifyCollectionChangedEventArgs args = null;
            o.CollectionChanged += (sender, e) =>
            {
                args = e;
            };
            PrehistoricPBJ pbj = new();
            o.Add(pbj);
            Assert.NotNull(args);
            Assert.Equal(NotifyCollectionChangedAction.Add, args.Action);
            Assert.Equal(pbj, args.NewItems[0]);
            Assert.Equal(1, args.NewItems.Count);
            Assert.Null(args.OldItems);
        }

        /// <summary>
        /// The CollectionChanged event should be triggered when an item is removed from the order
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCollectionChangedOnRemove()
        {
            Order o = new();
            NotifyCollectionChangedEventArgs args = null;
            o.CollectionChanged += (sender, e) =>
            {
                args = e;
            };
            PrehistoricPBJ pbj = new();
            o.Add(pbj);
            o.Remove(pbj);
            Assert.NotNull(args);
            Assert.Equal(NotifyCollectionChangedAction.Remove, args.Action);
            Assert.Equal(pbj, args.OldItems[0]);
            Assert.Equal(1, args.OldItems.Count);
            Assert.Null(args.NewItems);
        }

        /// <summary>
        /// Subtotal, Tax, Total, and Calories should change when an item is added to the order
        /// </summary>
        /// <param name="propertyName">The property to test</param>
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void ShouldNotifyOfPropertyChangingOnAdd(string propertyName)
        {
            Order o = new();
            PrehistoricPBJ pbj = new();
            Assert.PropertyChanged(o, propertyName, () =>
            {
                o.Add(pbj);
            });
        }

        /// <summary>
        /// Subtotal, Tax, Total, and Calories should change when an item is removed from the order
        /// </summary>
        /// <param name="propertyName">The property to test</param>
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void ShouldNotifyOfPropertyChangingOnRemove(string propertyName)
        {
            Order o = new();
            PrehistoricPBJ pbj = new();
            o.Add(pbj);
            Assert.PropertyChanged(o, propertyName, () =>
            {
                o.Remove(pbj);
            });
        }

        /// <summary>
        /// Subtotal, Tax, and Total should change when the price of an item in the order changes
        /// </summary>
        /// <param name="propertyName">The property to test</param>
        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        public void ShouldNotifyOfPricePropertyChangingWhenItemPriceIsModified(string propertyName)
        {
            Order o = new();
            Triceritots tt = new() { Size = ServingSize.Small };
            o.Add(tt);
            Assert.PropertyChanged(o, propertyName, () =>
            {
                tt.Size = ServingSize.Medium;
            });
        }

        /// <summary>
        /// The calories of the order should change when the calories of an item in the order changes
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCaloriesChangingWhenItemCaloriesIsModified()
        {
            Order o = new();
            CretaceousCoffee cc = new() { Cream = false };
            o.Add(cc);
            Assert.PropertyChanged(o, "Calories", () =>
            {
                cc.Cream = true;
            });
        }
    }
}
