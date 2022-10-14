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
    /// Interaction logic for NumberSelectionControl.xaml
    /// </summary>
    public partial class NumberSelectionControl : UserControl
    {
        /// <summary>
        /// Allows Value to be set with a Data binding
        /// </summary>
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(nameof(Value), typeof(uint), typeof(NumberSelectionControl), new FrameworkPropertyMetadata(1u, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// The value stored in this NumberSelectionControl
        /// </summary>
        public uint Value
        {
            get => (uint)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public NumberSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles clicks on the Decrement Button
        /// </summary>
        /// <param name="sender">The caller of the event</param>
        /// <param name="e">Routed event arguments</param>
        private void DecrementButtonClicked(object sender, RoutedEventArgs e)
        {
            Value--;
            if(Value == 0)
            {
                DecrementButton.IsEnabled = false;
            }
            e.Handled = true;
        }

        /// <summary>
        /// Handles clicks on the Increment Button
        /// </summary>
        /// <param name="sender">The caller of the event</param>
        /// <param name="e">Routed event arguments</param>
        private void IncrementButtonClicked(object sender, RoutedEventArgs e)
        {
            Value++;
            if(Value == 1)
            {
                DecrementButton.IsEnabled = true;
            }
            e.Handled = true;
        }
    }
}
