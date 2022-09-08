using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing Pterodactyl Wings chicken wings
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// The name of the wings
        /// </summary>
        public string Name
        {
            get
            {
                if (Sauce == WingSauce.HoneyGlaze) return "Honey Glaze Pterodactyl Wings";
                return $"{Sauce} Pterodactyl Wings";
            }
        }

        /// <summary>
        /// Indicates the sauce on the wings
        /// </summary>
        public WingSauce Sauce { get; set; } = WingSauce.Buffalo;

        /// <summary>
        /// The price of the wings
        /// </summary>
        public decimal Price { get; } = 8.95m;

        /// <summary>
        /// The calories of the wings
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Sauce == WingSauce.Buffalo) return 360;
                if (Sauce == WingSauce.Teriyaki) return 342;
                return 359;
            }
        }
    }
}
