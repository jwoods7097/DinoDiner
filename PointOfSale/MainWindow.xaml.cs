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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Stores the MenuItemSelectionControl for future use
        /// </summary>
        public MenuItemSelectionControl MenuSelect { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MenuSelect = new MenuItemSelectionControl();
            SelectionContainer.Child = MenuSelect;
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
                SelectionContainer.Child = (button.Name) switch
                {
                    "CancelButton" or "AddButton" or "CompleteButton" => MenuSelect,
                    _ => new ItemCustomizationControl(button.Name),
                };
                e.Handled = true;
            }
        }
    }
}
