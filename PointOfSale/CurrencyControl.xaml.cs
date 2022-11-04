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
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        /// <summary>
        /// Allows CustomerQuantity to be set with data binding
        /// </summary>
        public static readonly DependencyProperty CustomerQuantityProperty = DependencyProperty.Register(nameof(CustomerQuantity), typeof(uint), typeof(CurrencyControl), new FrameworkPropertyMetadata(0u, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Allows ChangeQuantity to be set with data binding
        /// </summary>
        public static readonly DependencyProperty ChangeQuantityProperty = DependencyProperty.Register(nameof(ChangeQuantity), typeof(uint), typeof(CurrencyControl), new FrameworkPropertyMetadata(0u, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// The amount of currency the customer provided
        /// </summary>
        public uint CustomerQuantity
        {
            get => (uint)GetValue(CustomerQuantityProperty);
            set => SetValue(CustomerQuantityProperty, value);
        }

        /// <summary>
        /// The amount of currency to give back to the customer as change.
        /// </summary>
        public uint ChangeQuantity
        {
            get => (uint)GetValue(ChangeQuantityProperty);
            set => SetValue(ChangeQuantityProperty, value);
        }

        public CurrencyControl()
        {
            InitializeComponent();
        }
    }
}
