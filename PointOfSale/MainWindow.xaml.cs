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
using RoundRegister;

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

        /// <summary>
        /// Stores the CashDrawControl for this point of sale
        /// </summary>
        public CashDrawerControl DrawerControl { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MenuSelect = new MenuItemSelectionControl();
            SelectionContainer.Child = MenuSelect;
            OrderSummary.OrderListView.SelectionChanged += HandleSelectionChanged;
            DataContext = this;
        }

        /// <summary>
        /// Handles all button clicks in this application
        /// </summary>
        /// <param name="sender">The caller of the event</param>
        /// <param name="e">Routed event arguments</param>
        private void HandleClick(object sender, RoutedEventArgs e)
        {
            CardTransactionResult result = CardTransactionResult.Approved;

            if (e.OriginalSource is Button button)
            {
                // Order Logic
                if (button.Name == "NewButton")
                {
                    OrderSummary.DataContext = new Order();
                }
                else if (button.Name == "AddEditButton")
                {
                    if (OrderSummary.DataContext is Order order && ItemCustomization.DataContext is Data.MenuItem item && !order.Contains(item))
                    {
                        order.Add(item);
                    }
                    OrderSummary.OrderListView.SelectedItem = null;
                }
                else if(button.Name == "CancelDeleteButton")
                {
                    if (OrderSummary.DataContext is Order order && SelectionContainer.Child is ItemCustomizationControl && ItemCustomization.DataContext is Data.MenuItem item)
                    {
                        order.Remove(item);
                    }
                }
                else if(button.Name == "CardButton")
                {
                    result = CardReader.RunCard();
                    if(result == CardTransactionResult.Approved)
                    {
                        // Print recipt
                        OrderSummary.DataContext = new Order();
                    }
                    else if(SelectionContainer.Child is PaymentOptionsControl poc)
                    {
                        poc.ErrorTextBlock.Text = (result) switch
                        {
                            CardTransactionResult.Declined => "Error! Card declined!",
                            CardTransactionResult.ReadError => "Error! Could not read card!",
                            CardTransactionResult.InsufficientFunds => "Error! Insufficient funds!",
                            CardTransactionResult.IncorrectPin => "Error! Incorrect PIN!",
                            _ => "Error!"
                        };
                    }
                }
                else if(button.Name == "CompleteButton")
                {
                    if(SelectionContainer.Child is CashDrawerControl cd && cd.DataContext is CashDrawerDataContext dc)
                    {
                        if(dc.FullyPaid)
                        {
                            dc.FinalizeSale();
                            OrderSummary.DataContext = new Order();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else if(button.Name == "CashButton")
                {
                    DrawerControl = new CashDrawerControl();
                    if (OrderSummary.DataContext is Order order)
                    {
                        DrawerControl.SetTotal(order.Total);
                    }
                }

                // Screen Switching
                switch (button.Name)
                {
                    case "NewButton":
                    case "AddEditButton":
                    case "CancelDeleteButton":
                    case "CardButton":
                        if(result == CardTransactionResult.Approved)
                        {
                            SelectionContainer.Child = MenuSelect;
                            AddEditButton.IsEnabled = false;
                            CancelDeleteButton.IsEnabled = false;
                            AddEditButton.Visibility = Visibility.Visible;
                        }
                        ChangeButtonText(CompleteButton, "Complete Order");
                        NewButton.Visibility = Visibility.Visible;
                        break;
                    case "CompleteButton":
                        if(SelectionContainer.Child is CashDrawerControl)
                        {
                            SelectionContainer.Child = MenuSelect;
                            AddEditButton.IsEnabled = false;
                            CancelDeleteButton.IsEnabled = false;
                            AddEditButton.Visibility = Visibility.Visible;
                            NewButton.Visibility = Visibility.Visible;
                            ChangeButtonText(CompleteButton, "Complete Order");
                        }
                        else
                        {
                            SelectionContainer.Child = new PaymentOptionsControl();
                            CancelDeleteButton.IsEnabled = true;
                            AddEditButton.Visibility = Visibility.Hidden;
                        }
                        break;
                    case "CashButton":
                        SelectionContainer.Child = DrawerControl;
                        CancelDeleteButton.IsEnabled = true;
                        ChangeButtonText(CompleteButton, "Complete Sale");
                        NewButton.Visibility = Visibility.Hidden;
                        AddEditButton.Visibility = Visibility.Hidden;
                        break;
                    default:
                        ItemCustomization = new ItemCustomizationControl(button.Name);
                        SelectionContainer.Child = ItemCustomization;
                        AddEditButton.IsEnabled = true;
                        CancelDeleteButton.IsEnabled = true;
                        break;
                }
                ChangeButtonText(AddEditButton, "Add");
                ChangeButtonText(CancelDeleteButton, "Cancel");

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
                AddEditButton.IsEnabled = true;
                CancelDeleteButton.IsEnabled = true;
                ChangeButtonText(AddEditButton, "Edit");
                ChangeButtonText(CancelDeleteButton, "Delete");
            }
        }

        /// <summary>
        /// Changes the text inside a button
        /// </summary>
        /// <param name="b">The button to update</param>
        /// <param name="text">The text to change to</param>
        private void ChangeButtonText(Button b, string text)
        {
            if(b.Content is TextBlock tb)
            {
                tb.Text = text;
            }
        }
    }
}
