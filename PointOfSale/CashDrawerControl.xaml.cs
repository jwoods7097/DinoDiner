using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for CashDrawerControl.xaml
    /// </summary>
    public partial class CashDrawerControl : UserControl
    {
        public CashDrawerControl()
        {
            InitializeComponent();
            CreateBill(HundredsControl, 100);
            CreateBill(FiftiesControl, 50);
            CreateBill(TwentiesControl, 20);
            CreateBill(TensControl, 10);
            CreateBill(FivesControl, 5);
            CreateBill(TwosControl, 2);
            CreateBill(OnesControl, 1);
            CreateCoin(DollarControl, 100);
            CreateCoin(HalfDollarControl, 50);
            CreateCoin(QuarterControl, 25);
            CreateCoin(DimeControl, 10);
            CreateCoin(NickelControl, 5);
            CreateCoin(PennyControl, 1);
            DataContext = new CashDrawerDataContext();
        }

        /// <summary>
        /// Creates the graphic for a bill CurrencyControl
        /// </summary>
        /// <param name="control">The CurrencyControl to add the graphic to</param>
        /// <param name="value">The value of the bill in dollars</param>
        private void CreateBill(CurrencyControl control, int value)
        {
            control.CurrencyGraphic.Children.Insert(0, new Rectangle()
            {
                Height = 25,
                Width = 45,
                Stroke = Brushes.LightGray,
                StrokeThickness = 1,
                Fill = Brushes.ForestGreen
            });
            if(control.CurrencyGraphic.Children[1] is TextBlock tb)
            {
                tb.Text = $"${value}";
            }
        }

        /// <summary>
        /// Creates the graphic for a coin CurrencyControl
        /// </summary>
        /// <param name="control">The CurrencyControl to add the graphic to</param>
        /// <param name="value">The value of the coin in cents</param>
        private void CreateCoin(CurrencyControl control, int value)
        {
            control.CurrencyGraphic.Children.Insert(0, new Ellipse()
            {
                Height = 40,
                Width = 40,
                Stroke = Brushes.LightGray,
                StrokeThickness = 1,
                Fill = Brushes.Goldenrod
            });
            if(control.CurrencyGraphic.Children[1] is TextBlock tb)
            {
                if(value >= 100)
                {
                    tb.Text = $"${value / 100}";
                }
                else
                {
                    tb.Text = $"{value}¢";
                }
            }
        }

        /// <summary>
        /// Sets the order total
        /// </summary>
        /// <param name="orderTotal">The total cost of the order</param>
        public void SetTotal(decimal orderTotal)
        {
            if(DataContext is CashDrawerDataContext dc)
            {
                dc.Total = orderTotal;
            }
        }
    }
}
