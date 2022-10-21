using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data.Enums;
using System.ComponentModel;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing Pterodactyl Wings chicken wings
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// The name of the wings
        /// </summary>
        public override string Name
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
        private WingSauce _sauce = WingSauce.Buffalo;

        /// <summary>
        /// Public property for _sauce, invokes PropertyChanged for necessary properties
        /// </summary>
        public WingSauce Sauce
        {
            get => _sauce;
            set
            {
                if(_sauce != value)
                {
                    _sauce = value;
                    OnPropertyChanged(nameof(Sauce));
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// The price of the wings
        /// </summary>
        public override decimal Price { get; } = 8.95m;

        /// <summary>
        /// The calories of the wings
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sauce == WingSauce.HoneyGlaze) return 359;
                if (Sauce == WingSauce.Teriyaki) return 342;
                return 360;
            }
        }
    }
}
