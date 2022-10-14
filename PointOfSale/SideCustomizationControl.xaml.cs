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
using DinoDiner.Data.Sides;

namespace DinoDiner.PointOfSale
{
    /// <summary>
    /// Interaction logic for SideCustomizationControl.xaml
    /// </summary>
    public partial class SideCustomizationControl : UserControl
    {
        public SideCustomizationControl(bool isFryceritops)
        {
            InitializeComponent();
            if(isFryceritops)
            {
                OptionsTextBlock.Visibility = Visibility.Visible;
                SaltCheckBox.Visibility = Visibility.Visible;
                SauceCheckBox.Visibility = Visibility.Visible;
            }
        }
    }
}
