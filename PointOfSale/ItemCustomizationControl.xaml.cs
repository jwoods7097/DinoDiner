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
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Drinks;

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
            switch(buttonName)
            {
                case "AllosaurusAllAmericanButton":
                    ItemControlContainer.Child = new BurgerCustomizationControl();
                    this.DataContext = new AllosaurusAllAmericanBurger();
                    break;
                case "CarnotaurusCheeseburgerButton":
                    ItemControlContainer.Child = new BurgerCustomizationControl();
                    this.DataContext = new CarnotaurusCheeseburger();
                    break;
                case "DeinonychusDoubleButton":
                    ItemControlContainer.Child = new BurgerCustomizationControl();
                    this.DataContext = new DeinonychusDouble();
                    break;
                case "TRexTripleBurgerButton":
                    ItemControlContainer.Child = new BurgerCustomizationControl();
                    this.DataContext = new TRexTriple();
                    break;
                case "CustomBurgerButton":
                    ItemControlContainer.Child = new BurgerCustomizationControl();
                    this.DataContext = new Burger();
                    break;
                case "BrontowurstButton":
                    ItemControlContainer.Child = new BrontowurstCustomizationControl();
                    this.DataContext = new Brontowurst();
                    break;
                case "PrehistoricPBJButton":
                    ItemControlContainer.Child = new PrehistoricPBJCustomizationControl();
                    this.DataContext = new PrehistoricPBJ();
                    break;
                case "PterodactylWingsButton":
                    ItemControlContainer.Child = new PterodactylWingsCustomizationControl();
                    this.DataContext = new PterodactylWings();
                    break;
                case "VelociWraptorButton":
                    ItemControlContainer.Child = new VelociWraptorCustomizationControl();
                    this.DataContext = new VelociWraptor();
                    break;
                case "DinoNuggetsButton":
                    ItemControlContainer.Child = new DinoNuggetsCustomizationControl();
                    this.DataContext = new DinoNuggets();
                    break;
                case "FryceritopsButton":
                    ItemControlContainer.Child = new SideCustomizationControl(true);
                    this.DataContext = new Fryceritops();
                    break;
                case "MeteorMacAndCheeseButton":
                    ItemControlContainer.Child = new SideCustomizationControl(false);
                    this.DataContext = new MeteorMacAndCheese();
                    break;
                case "MezzorellaSticksButton":
                    ItemControlContainer.Child = new SideCustomizationControl(false);
                    this.DataContext = new MezzorellaSticks();
                    break;
                case "TriceritotsButton":
                    ItemControlContainer.Child = new SideCustomizationControl(false);
                    this.DataContext = new Triceritots();
                    break;
                case "PlilosodaButton":
                    ItemControlContainer.Child = new PlilosodaCustomizationControl();
                    this.DataContext = new Plilosoda();
                    break;
                case "CretaceousCoffeeButton":
                    ItemControlContainer.Child = new CretaceousCoffeeCustomizationControl();
                    this.DataContext = new CretaceousCoffee();
                    break;
                default:
                    throw new ArgumentException("Invalid button name!");
            }
        }

        public ItemCustomizationControl(Data.MenuItem item)
        {
            InitializeComponent();
            if(item is Burger)
            {
                ItemControlContainer.Child = new BurgerCustomizationControl();
            }
            else if(item is Brontowurst)
            {
                ItemControlContainer.Child = new BrontowurstCustomizationControl();
            }
            else if (item is DinoNuggets)
            {
                ItemControlContainer.Child = new DinoNuggetsCustomizationControl();
            }
            else if (item is PrehistoricPBJ)
            {
                ItemControlContainer.Child = new PrehistoricPBJCustomizationControl();
            }
            else if (item is PterodactylWings)
            {
                ItemControlContainer.Child = new PterodactylWingsCustomizationControl();
            }
            else if (item is VelociWraptor)
            {
                ItemControlContainer.Child = new VelociWraptorCustomizationControl();
            }
            else if (item is Side)
            {
                ItemControlContainer.Child = new SideCustomizationControl(item is Fryceritops);
            }
            else if (item is Plilosoda)
            {
                ItemControlContainer.Child = new PlilosodaCustomizationControl();
            }
            else if (item is CretaceousCoffee)
            {
                ItemControlContainer.Child = new CretaceousCoffeeCustomizationControl();
            }
            else
            {
                throw new ArgumentException("Invalid Menu Item!");
            }
            this.DataContext = item;
        }
    }
}
