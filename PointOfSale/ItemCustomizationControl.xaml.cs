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
    /// Interaction logic for ItemCustomizationControl.xaml
    /// </summary>
    public partial class ItemCustomizationControl : UserControl
    {
        public ItemCustomizationControl(string buttonName)
        {
            InitializeComponent();
            ItemControlBorder.Child = buttonName switch
            {
                "AllosaurusAllAmericanButton" or "CarnotaurusCheeseburgerButton" or "DeinonychusDoubleButton" or "TRexTripleBurgerButton" or "CustomBurgerButton" => new BurgerCustomizationControl(buttonName),
                "BrontowurstButton" => new BrontowurstCustomizationControl(),
                "PrehistoricPBJButton" => new PrehistoricPBJCustomizationControl(),
                "PterodactylWingsButton" => new PterodactylWingsCustomizationControl(),
                "VelociWraptorButton" => new VelociWraptorCustomizationControl(),
                "DinoNuggetsButton" => new DinoNuggetsCustomizationControl(),
                "FryceritopsButton" or "MeteorMacAndCheeseButton" or "MezzorellaSticksButton" or "TriceritotsButton" => new SideCustomizationControl(buttonName),
                "PlilosodaButton" => new PlilosodaCustomizationControl(),
                "CretaceousCoffeeButton" => new CretaceousCoffeeCustomizationControl(),
                _ => throw new ArgumentException("Invalid button name!")
            };
        }
    }
}
