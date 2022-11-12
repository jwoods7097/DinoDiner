using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Drinks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data
{
    /// <summary>
    /// Represents the entire menu for Dino Diner
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets a list of all the entrees served at Dino Diner
        /// </summary>
        public static IEnumerable<MenuItem> Entrees
        {
            get
            {
                List<MenuItem> entrees = new();
                entrees.Add(new AllosaurusAllAmericanBurger());
                entrees.Add(new CarnotaurusCheeseburger());
                entrees.Add(new DeinonychusDouble());
                entrees.Add(new TRexTriple());
                entrees.Add(new Burger());
                entrees.Add(new Brontowurst());
                entrees.Add(new PrehistoricPBJ());
                entrees.Add(new PterodactylWings());
                entrees.Add(new VelociWraptor());
                entrees.Add(new DinoNuggets());
                return entrees;
            }
        }

        /// <summary>
        /// Gets a list of all the sides served at Dino Diner
        /// </summary>
        public static IEnumerable<MenuItem> Sides
        {
            get
            {
                List<MenuItem> sides = new();
                foreach (ServingSize size in Enum.GetValues(typeof(ServingSize)))
                {
                    sides.Add(new Fryceritops() { Size = size });
                    sides.Add(new MeteorMacAndCheese() { Size = size });
                    sides.Add(new MezzorellaSticks() { Size = size });
                    sides.Add(new Triceritots() { Size = size });
                }
                return sides;
            }
        }

        /// <summary>
        /// Gets a list of all the drinks served at Dino Diner
        /// </summary>
        public static IEnumerable<MenuItem> Drinks
        {
            get
            {
                List<MenuItem> drinks = new();
                foreach (ServingSize size in Enum.GetValues(typeof(ServingSize)))
                {
                    foreach(SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                    {
                        drinks.Add(new Plilosoda() { Size = size, Flavor = flavor });
                    }
                }
                // Less efficient, but displays better on the webpage
                foreach(ServingSize size in Enum.GetValues(typeof(ServingSize)))
                {
                    drinks.Add(new CretaceousCoffee() { Size = size });
                }
                return drinks;
            }
        }

        /// <summary>
        /// Gets a list of all items served at Dino Diner
        /// </summary>
        public static IEnumerable<MenuItem> FullMenu
        {
            get
            {
                List<MenuItem> menu = new();
                menu.AddRange(Entrees);
                menu.AddRange(Sides);
                menu.AddRange(Drinks);
                return menu;
            }
        }
    }
}
