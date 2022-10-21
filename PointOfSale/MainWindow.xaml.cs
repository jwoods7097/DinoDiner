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
using DinoDiner.Data;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Stores the MenuItemSelectionControl for future use
        /// </summary>
        public MenuItemSelectionControl MenuSelect { get; set; }

        /// <summary>
        /// Stores the current ItemCustomizationControl
        /// </summary>
        public ItemCustomizationControl ItemCustomization { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MenuSelect = new MenuItemSelectionControl();
            SelectionContainer.Child = MenuSelect;
            OrderSummary.OrderListView.SelectionChanged += HandleSelectionChanged;
        }

        /// <summary>
        /// Handles all button clicks in this application
        /// </summary>
        /// <param name="sender">The caller of the event</param>
        /// <param name="e">Routed event arguments</param>
        private void HandleClick(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button)
            {
                if (button.Name == "NewButton")
                {
                    OrderSummary.DataContext = new Order();
                }
                else if (button.Name == "AddButton")
                {
                    if (OrderSummary.DataContext is Order order && ItemCustomization.DataContext is Data.MenuItem item && !order.Contains(item))
                    {
                        order.Add(item);
                    }
                    OrderSummary.OrderListView.SelectedItem = null;
                }
                else if(button.Name == "DeleteButton")
                {
                    if (OrderSummary.DataContext is Order order && ItemCustomization.DataContext is Data.MenuItem item)
                    {
                        order.Remove(item);
                    }
                }

                if (button.Name == "NewButton" || button.Name == "AddButton" || button.Name == "CompleteButton" || button.Name == "DeleteButton")
                {
                    SelectionContainer.Child = MenuSelect;
                    AddButton.IsEnabled = false;
                    DeleteButton.IsEnabled = false;
                }
                else
                {
                    ItemCustomization = new ItemCustomizationControl(button.Name);
                    SelectionContainer.Child = ItemCustomization;
                    AddButton.IsEnabled = true;
                    DeleteButton.IsEnabled = true;
                }
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event for the ListView in OrderSummaryControl
        /// </summary>
        /// <param name="sender">The caller of the event</param>
        /// <param name="e">Routed event arguments</param>
        private void HandleSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count > 0 && e.AddedItems[0] is Data.MenuItem item)
            {
                ItemCustomization = new ItemCustomizationControl(item);
                SelectionContainer.Child = ItemCustomization;
                AddButton.IsEnabled = true;
                DeleteButton.IsEnabled = true;
            }
        }
    }
}
