using Xunit;
using DinoDiner.PointOfSale;
using System.ComponentModel;
using RoundRegister;
using System;

namespace PointOfSaleTest
{
    /// <summary>
    /// Unit Tests for CashDrawerDataContext
    /// </summary>
    public class CashDrawerDataContextUnitTests
    {
        /// <summary>
        /// CashDrawerDataContext should implement the INotifyPropertyChanged interface
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyChanged()
        {
            CashDrawerDataContext c = new();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(c);
        }

        /// <summary>
        /// CustomerHundreds should default to zero
        /// </summary>
        [Fact]
        public void CustomerHundredsShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerHundreds);
        }

        /// <summary>
        /// Should be able to set CustomerHundreds
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerHundreds(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerHundreds = value;
            Assert.Equal(value, c.CustomerHundreds);
        }

        /// <summary>
        /// CustomerFifties should default to zero
        /// </summary>
        [Fact]
        public void CustomerFiftiesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerFifties);
        }

        /// <summary>
        /// Should be able to set CustomerFifties
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerFifties(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerFifties = value;
            Assert.Equal(value, c.CustomerFifties);
        }

        /// <summary>
        /// CustomerTwenties should default to zero
        /// </summary>
        [Fact]
        public void CustomerTwentiesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerTwenties);
        }

        /// <summary>
        /// Should be able to set CustomerTwenties
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerTwenties(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerTwenties = value;
            Assert.Equal(value, c.CustomerTwenties);
        }

        /// <summary>
        /// CustomerTens should default to zero
        /// </summary>
        [Fact]
        public void CustomerTensShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerTens);
        }

        /// <summary>
        /// Should be able to set CustomerTens
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerTens(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerTens = value;
            Assert.Equal(value, c.CustomerTens);
        }

        /// <summary>
        /// CustomerFives should default to zero
        /// </summary>
        [Fact]
        public void CustomerFivesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerFives);
        }

        /// <summary>
        /// Should be able to set CustomerFives
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerFives(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerFives = value;
            Assert.Equal(value, c.CustomerFives);
        }

        /// <summary>
        /// CustomerTwos should default to zero
        /// </summary>
        [Fact]
        public void CustomerTwosShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerTwos);
        }

        /// <summary>
        /// Should be able to set CustomerTwos
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerTwos(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerTwos = value;
            Assert.Equal(value, c.CustomerTwos);
        }

        /// <summary>
        /// CustomerOnes should default to zero
        /// </summary>
        [Fact]
        public void CustomerOnesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerOnes);
        }

        /// <summary>
        /// Should be able to set CustomerOnes
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerOnes(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerOnes = value;
            Assert.Equal(value, c.CustomerOnes);
        }

        /// <summary>
        /// CustomerDollars should default to zero
        /// </summary>
        [Fact]
        public void CustomerDollarsShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerDollars);
        }

        /// <summary>
        /// Should be able to set CustomerDollars
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerDollars(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerDollars = value;
            Assert.Equal(value, c.CustomerDollars);
        }

        /// <summary>
        /// CustomerHalfDollars should default to zero
        /// </summary>
        [Fact]
        public void CustomerHalfDollarsShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerHalfDollars);
        }

        /// <summary>
        /// Should be able to set CustomerHalfDollars
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerHalfDollars(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerHalfDollars = value;
            Assert.Equal(value, c.CustomerHalfDollars);
        }

        /// <summary>
        /// CustomerQuarters should default to zero
        /// </summary>
        [Fact]
        public void CustomerQuartersShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerQuarters);
        }

        /// <summary>
        /// Should be able to set CustomerQuarters
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerQuarters(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerQuarters = value;
            Assert.Equal(value, c.CustomerQuarters);
        }

        /// <summary>
        /// CustomerDimes should default to zero
        /// </summary>
        [Fact]
        public void CustomerDimesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerDimes);
        }

        /// <summary>
        /// Should be able to set CustomerDimes
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerDimes(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerDimes = value;
            Assert.Equal(value, c.CustomerDimes);
        }

        /// <summary>
        /// CustomerNickels should default to zero
        /// </summary>
        [Fact]
        public void CustomerNickelsShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerNickels);
        }

        /// <summary>
        /// Should be able to set CustomerNickels
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerNickels(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerNickels = value;
            Assert.Equal(value, c.CustomerNickels);
        }

        /// <summary>
        /// CustomerPennies should default to zero
        /// </summary>
        [Fact]
        public void CustomerPenniesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.CustomerPennies);
        }

        /// <summary>
        /// Should be able to set CustomerPennies
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetCustomerPennies(uint value)
        {
            CashDrawerDataContext c = new();
            c.CustomerPennies = value;
            Assert.Equal(value, c.CustomerPennies);
        }

        /// <summary>
        /// ChangeHundreds should default to zero
        /// </summary>
        [Fact]
        public void ChangeHundredsShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeHundreds);
        }

        /// <summary>
        /// Should be able to set ChangeHundreds
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeHundreds(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeHundreds = value;
            Assert.Equal(value, c.ChangeHundreds);
        }

        /// <summary>
        /// ChangeFifties should default to zero
        /// </summary>
        [Fact]
        public void ChangeFiftiesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeFifties);
        }

        /// <summary>
        /// Should be able to set ChangeFifties
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeFifties(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeFifties = value;
            Assert.Equal(value, c.ChangeFifties);
        }

        /// <summary>
        /// ChangeTwenties should default to zero
        /// </summary>
        [Fact]
        public void ChangeTwentiesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeTwenties);
        }

        /// <summary>
        /// Should be able to set ChangeTwenties
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeTwenties(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeTwenties = value;
            Assert.Equal(value, c.ChangeTwenties);
        }

        /// <summary>
        /// ChangeTens should default to zero
        /// </summary>
        [Fact]
        public void ChangeTensShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeTens);
        }

        /// <summary>
        /// Should be able to set ChangeTens
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeTens(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeTens = value;
            Assert.Equal(value, c.ChangeTens);
        }

        /// <summary>
        /// ChangeFives should default to zero
        /// </summary>
        [Fact]
        public void ChangeFivesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeFives);
        }

        /// <summary>
        /// Should be able to set ChangeFives
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeFives(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeFives = value;
            Assert.Equal(value, c.ChangeFives);
        }

        /// <summary>
        /// ChangeTwos should default to zero
        /// </summary>
        [Fact]
        public void ChangeTwosShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeTwos);
        }

        /// <summary>
        /// Should be able to set ChangeTwos
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeTwos(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeTwos = value;
            Assert.Equal(value, c.ChangeTwos);
        }

        /// <summary>
        /// ChangeOnes should default to zero
        /// </summary>
        [Fact]
        public void ChangeOnesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeOnes);
        }

        /// <summary>
        /// Should be able to set ChangeOnes
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeOnes(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeOnes = value;
            Assert.Equal(value, c.ChangeOnes);
        }

        /// <summary>
        /// ChangeDollars should default to zero
        /// </summary>
        [Fact]
        public void ChangeDollarsShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeDollars);
        }

        /// <summary>
        /// Should be able to set ChangeDollars
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeDollars(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeDollars = value;
            Assert.Equal(value, c.ChangeDollars);
        }

        /// <summary>
        /// ChangeHalfDollars should default to zero
        /// </summary>
        [Fact]
        public void ChangeHalfDollarsShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeHalfDollars);
        }

        /// <summary>
        /// Should be able to set ChangeHalfDollars
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeHalfDollars(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeHalfDollars = value;
            Assert.Equal(value, c.ChangeHalfDollars);
        }

        /// <summary>
        /// ChangeQuarters should default to zero
        /// </summary>
        [Fact]
        public void ChangeQuartersShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeQuarters);
        }

        /// <summary>
        /// Should be able to set ChangeQuarters
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeQuarters(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeQuarters = value;
            Assert.Equal(value, c.ChangeQuarters);
        }

        /// <summary>
        /// ChangeDimes should default to zero
        /// </summary>
        [Fact]
        public void ChangeDimesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeDimes);
        }

        /// <summary>
        /// Should be able to set ChangeDimes
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeDimes(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeDimes = value;
            Assert.Equal(value, c.ChangeDimes);
        }

        /// <summary>
        /// ChangeNickels should default to zero
        /// </summary>
        [Fact]
        public void ChangeNickelsShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangeNickels);
        }

        /// <summary>
        /// Should be able to set ChangeNickels
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangeNickels(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangeNickels = value;
            Assert.Equal(value, c.ChangeNickels);
        }

        /// <summary>
        /// ChangePennies should default to zero
        /// </summary>
        [Fact]
        public void ChangePenniesShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0u, c.ChangePennies);
        }

        /// <summary>
        /// Should be able to set ChangePennies
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(10)]
        [Theory]
        public void ShouldBeAbleToSetChangePennies(uint value)
        {
            CashDrawerDataContext c = new();
            c.ChangePennies = value;
            Assert.Equal(value, c.ChangePennies);
        }

        /// <summary>
        /// Total should default to zero
        /// </summary>
        [Fact]
        public void TotalShouldDefaultToZero()
        {
            CashDrawerDataContext c = new();
            Assert.Equal(0m, c.Total);
        }

        /// <summary>
        /// Should be able to set ChangePennies
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(0.00)]
        [InlineData(1.69)]
        [InlineData(13.45)]
        [InlineData(17.62)]
        [InlineData(3.45)]
        [InlineData(8.42)]
        [InlineData(8.79)]
        [InlineData(10.15)]
        [Theory]
        public void ShouldBeAbleToSetTotal(decimal value)
        {
            CashDrawerDataContext c = new();
            c.Total = value;
            Assert.Equal(value, c.Total);
        }

        /// <summary>
        /// Changing CustomerHundreds should notify changes of CustomerHundreds, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerHundreds")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerHundreds")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerHundredsShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerHundreds = value;
            });
        }

        /// <summary>
        /// Changing CustomerFifties should notify changes of CustomerFifties, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerFifties")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerFifties")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerFiftiesShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerFifties = value;
            });
        }

        /// <summary>
        /// Changing CustomerTwenties should notify changes of CustomerTwenties, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerTwenties")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerTwenties")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerTwentiesShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerTwenties = value;
            });
        }

        /// <summary>
        /// Changing CustomerTens should notify changes of CustomerTens, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerTens")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerTens")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerTensShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerTens = value;
            });
        }

        /// <summary>
        /// Changing CustomerFives should notify changes of CustomerFives, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerFives")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerFives")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerFivesShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerFives = value;
            });
        }

        /// <summary>
        /// Changing CustomerTwos should notify changes of CustomerTwos, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerTwos")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerTwos")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerTwosShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerTwos = value;
            });
        }

        /// <summary>
        /// Changing CustomerOnes should notify changes of CustomerOnes, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerOnes")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerOnes")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerOnesShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerOnes = value;
            });
        }

        /// <summary>
        /// Changing CustomerDollars should notify changes of CustomerDollars, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerDollars")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerDollars")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerDollarsShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerDollars = value;
            });
        }

        /// <summary>
        /// Changing CustomerHalfDollars should notify changes of CustomerHalfDollars, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerHalfDollars")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerHalfDollars")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerHalfDollarsShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerHalfDollars = value;
            });
        }

        /// <summary>
        /// Changing CustomerQuarters should notify changes of CustomerQuarters, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerQuarters")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerQuarters")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerQuartersShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerQuarters = value;
            });
        }

        /// <summary>
        /// Changing CustomerDimes should notify changes of CustomerDimes, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerDimes")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerDimes")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerDimesShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerDimes = value;
            });
        }

        /// <summary>
        /// Changing CustomerNickels should notify changes of CustomerNickels, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerNickels")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerNickels")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerNickelsShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerNickels = value;
            });
        }

        /// <summary>
        /// Changing CustomerPennies should notify changes of CustomerPennies, AmountDue, ChangeOwed, and FullyPaid properties
        /// </summary>
        /// <param name="value">The test value</param>
        /// <param name="propertyName">The property that should be notified</param>
        [InlineData(1, "CustomerPennies")]
        [InlineData(1, "AmountDue")]
        [InlineData(1, "ChangeOwed")]
        [InlineData(1, "FullyPaid")]
        [InlineData(3, "CustomerPennies")]
        [InlineData(3, "AmountDue")]
        [InlineData(3, "ChangeOwed")]
        [InlineData(3, "FullyPaid")]
        [Theory]
        public void ChangingCustomerPenniesShouldNotifyOfPropertyChanges(uint value, string propertyName)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, propertyName, () =>
            {
                c.CustomerPennies = value;
            });
        }

        /// <summary>
        /// Changing ChangeHundreds should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeHundredsShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeHundreds", () =>
            {
                c.ChangeHundreds = value;
            });
        }

        /// <summary>
        /// Changing ChangeFifties should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeFiftiesShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeFifties", () =>
            {
                c.ChangeFifties = value;
            });
        }

        /// <summary>
        /// Changing ChangeTwenties should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeTwentiesShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeTwenties", () =>
            {
                c.ChangeTwenties = value;
            });
        }

        /// <summary>
        /// Changing ChangeTens should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeTensShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeTens", () =>
            {
                c.ChangeTens = value;
            });
        }

        /// <summary>
        /// Changing ChangeFives should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeFivesShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeFives", () =>
            {
                c.ChangeFives = value;
            });
        }

        /// <summary>
        /// Changing ChangeTwos should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeTwosShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeTwos", () =>
            {
                c.ChangeTwos = value;
            });
        }

        /// <summary>
        /// Changing ChangeOnes should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeOnesShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeOnes", () =>
            {
                c.ChangeOnes = value;
            });
        }

        /// <summary>
        /// Changing ChangeDollars should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeDollarsShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeDollars", () =>
            {
                c.ChangeDollars = value;
            });
        }

        /// <summary>
        /// Changing ChangeHalfDollars should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeHalfDollarsShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeHalfDollars", () =>
            {
                c.ChangeHalfDollars = value;
            });
        }

        /// <summary>
        /// Changing ChangeQuarters should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeQuartersShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeQuarters", () =>
            {
                c.ChangeQuarters = value;
            });
        }

        /// <summary>
        /// Changing ChangeDimes should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeDimesShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeDimes", () =>
            {
                c.ChangeDimes = value;
            });
        }

        /// <summary>
        /// Changing ChangeNickels should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangeNickelsShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangeNickels", () =>
            {
                c.ChangeNickels = value;
            });
        }

        /// <summary>
        /// Changing ChangePennies should notify change of its property
        /// </summary>
        /// <param name="value">The test value</param>
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(10)]
        [Theory]
        public void ChangingChangePenniesShouldNotifyOfPropertyChange(uint value)
        {
            CashDrawerDataContext c = new();
            Assert.PropertyChanged(c, "ChangePennies", () =>
            {
                c.ChangePennies = value;
            });
        }

        /// <summary>
        /// The amount due should be calculated correctly
        /// </summary>
        [Fact]
        public void AmountDueIsCalculatedCorrectly()
        {
            CashDrawerDataContext c = new();
            decimal total = 200m;
            c.Total = total;
            Assert.Equal(total, c.AmountDue);
            c.CustomerHundreds = 1;
            total -= 100m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerFifties = 1;
            total -= 50m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerTwenties = 1;
            total -= 20m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerTens = 1;
            total -= 10m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerFives = 1;
            total -= 5m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerTwos = 1;
            total -= 2m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerOnes = 1;
            total -= 1m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerDollars = 1;
            total -= 1m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerHalfDollars = 1;
            total -= 0.50m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerQuarters = 1;
            total -= 0.25m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerDimes = 1;
            total -= 0.10m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerNickels = 1;
            total -= 0.05m;
            Assert.Equal(total, c.AmountDue);
            c.CustomerPennies = 1;
            total -= 0.01m;
            Assert.Equal(total, c.AmountDue);
        }

        /// <summary>
        /// The change owed should be calculated correctly. The customer always pays $13.37
        /// </summary>
        /// <param name="total">The total cost of the order</param>
        /// <param name="expectedChange">The expected change owed</param>
        [InlineData(0, 13.37)]
        [InlineData(15, 0)]
        [InlineData(13.37, 0)]
        [InlineData(13.38, 0)]
        [InlineData(13.36, 0.01)]
        [InlineData(13, 0.37)]
        [InlineData(10, 3.37)]
        [InlineData(12.34, 1.03)]
        [Theory]
        public void ChangeOwedIsCaluclatedCorrectly(decimal total, decimal expectedChange)
        {
            CashDrawerDataContext c = new()
            {
                Total = total,
                CustomerTens = 1,
                CustomerOnes = 3,
                CustomerQuarters = 1,
                CustomerDimes = 1,
                CustomerPennies = 2
            };
            Assert.Equal(expectedChange, c.ChangeOwed);
        }

        /// <summary>
        /// FullyPaid should update when the order has been fully paid off. The customer always pays $13.37
        /// </summary>
        /// <param name="total">The total cost of the order</param>
        /// <param name="expected">The expected value of FullyPaid</param>
        [InlineData(0, true)]
        [InlineData(15, false)]
        [InlineData(13.37, true)]
        [InlineData(13.38, false)]
        [InlineData(13.36, true)]
        [InlineData(13, true)]
        [InlineData(10, true)]
        [InlineData(16.34, false)]
        [Theory]
        public void FullyPaidShouldUpdateCorrectly(decimal total, bool expected)
        {
            CashDrawerDataContext c = new()
            {
                Total = total,
                CustomerTens = 1,
                CustomerOnes = 3,
                CustomerQuarters = 1,
                CustomerDimes = 1,
                CustomerPennies = 2
            };
            Assert.Equal(expected, c.FullyPaid);
        }

        /// <summary>
        /// The FinalizeSale method should update the amount of currency in the drawer
        /// </summary>
        [Fact]
        public void FinalizeSaleShouldUpdateCashDrawerCorrectly()
        {
            CashDrawer.Reset();
            CashDrawerDataContext c = new()
            {
                CustomerHundreds = 3,
                CustomerFifties = 3,
                CustomerTwenties = 3,
                CustomerTens = 3,
                CustomerFives = 3,
                CustomerTwos = 3,
                CustomerOnes = 3,
                CustomerDollars = 3,
                CustomerHalfDollars = 3,
                CustomerQuarters = 3,
                CustomerDimes = 3,
                CustomerNickels = 3,
                CustomerPennies = 3,
                ChangeHundreds = 1,
                ChangeFifties = 1,
                ChangeTwenties = 1,
                ChangeTens = 1,
                ChangeFives = 1,
                ChangeTwos = 1,
                ChangeOnes = 1,
                ChangeDollars = 1,
                ChangeHalfDollars = 1,
                ChangeQuarters = 1,
                ChangeDimes = 1,
                ChangeNickels = 1,
                ChangePennies = 1
            };
            c.FinalizeSale();
            uint drawerHundreds = CashDrawer.Hundreds;
            uint drawerFifties = CashDrawer.Fifties;
            uint drawerTwenties = CashDrawer.Twenties;
            uint drawerTens = CashDrawer.Tens;
            uint drawerFives = CashDrawer.Fives;
            uint drawerTwos = CashDrawer.Twos;
            uint drawerOnes = CashDrawer.Ones;
            uint drawerDollars = CashDrawer.DollarCoins;
            uint drawerHalfDollars = CashDrawer.HalfDollarCoins;
            uint drawerQuarters = CashDrawer.Quarters;
            uint drawerDimes = CashDrawer.Dimes;
            uint drawerNickels = CashDrawer.Nickles;
            uint drawerPennies = CashDrawer.Pennies;
            CashDrawer.Reset();
            Assert.Equal(drawerHundreds - 2, CashDrawer.Hundreds);
            Assert.Equal(drawerFifties - 2, CashDrawer.Fifties);
            Assert.Equal(drawerTwenties - 2, CashDrawer.Twenties);
            Assert.Equal(drawerTens - 2, CashDrawer.Tens);
            Assert.Equal(drawerFives - 2, CashDrawer.Fives);
            Assert.Equal(drawerTwos - 2, CashDrawer.Twos);
            Assert.Equal(drawerOnes - 2, CashDrawer.Ones);
            Assert.Equal(drawerDollars - 2, CashDrawer.DollarCoins);
            Assert.Equal(drawerHalfDollars - 2, CashDrawer.HalfDollarCoins);
            Assert.Equal(drawerQuarters - 2, CashDrawer.Quarters);
            Assert.Equal(drawerDimes - 2, CashDrawer.Dimes);
            Assert.Equal(drawerFives - 2, CashDrawer.Fives);
            Assert.Equal(drawerPennies - 2, CashDrawer.Pennies);
        }
    }
}