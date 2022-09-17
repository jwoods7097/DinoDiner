using DinoDiner.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Drinks
{
    /// <summary>
    /// A class representing the Plilosoda soda
    /// </summary>
    public class Plilosoda : Drink
    {
        /// <summary>
        /// The name of the soda
        /// </summary>
        public override string Name
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(Size);
                switch(Flavor)
                {
                    case SodaFlavor.Cola:
                        sb.Append(" Cola ");
                        break;
                    case SodaFlavor.CherryCola:
                        sb.Append(" Cherry Cola ");
                        break;
                    case SodaFlavor.DoctorDino:
                        sb.Append(" Doctor Dino ");
                        break;
                    case SodaFlavor.LemonLime:
                        sb.Append(" Lemon-Lime ");
                        break;
                    case SodaFlavor.DinoDew:
                        sb.Append(" Dino Dew ");
                        break;
                    default:
                        sb.Append($" {Flavor} ");
                        break;
                }
                sb.Append("Plilosoda");

                return sb.ToString();
            }
        }

        /// <summary>
        /// The price of the soda
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == ServingSize.Medium) return 1.75m;
                if (Size == ServingSize.Large) return 2.50m;
                return 1.00m;
            }
        }

        /// <summary>
        /// The calories of the soda
        /// </summary>
        public override uint Calories
        {
            get => (this) switch
            {
                { Size: ServingSize.Small, Flavor: SodaFlavor.Cola } => 180,
                { Size: ServingSize.Small, Flavor: SodaFlavor.CherryCola } => 100,
                { Size: ServingSize.Small, Flavor: SodaFlavor.DoctorDino } => 120,
                { Size: ServingSize.Small, Flavor: SodaFlavor.LemonLime } => 41,
                { Size: ServingSize.Small, Flavor: SodaFlavor.DinoDew } => 141,
                { Size: ServingSize.Medium, Flavor: SodaFlavor.Cola } => 288,
                { Size: ServingSize.Medium, Flavor: SodaFlavor.CherryCola } => 160,
                { Size: ServingSize.Medium, Flavor: SodaFlavor.DoctorDino } => 192,
                { Size: ServingSize.Medium, Flavor: SodaFlavor.LemonLime } => 66,
                { Size: ServingSize.Medium, Flavor: SodaFlavor.DinoDew } => 256,
                { Size: ServingSize.Large, Flavor: SodaFlavor.Cola } => 432,
                { Size: ServingSize.Large, Flavor: SodaFlavor.CherryCola } => 240,
                { Size: ServingSize.Large, Flavor: SodaFlavor.DoctorDino } => 288,
                { Size: ServingSize.Large, Flavor: SodaFlavor.LemonLime } => 98,
                { Size: ServingSize.Large, Flavor: SodaFlavor.DinoDew } => 338,
                _ => 0
            };
        }

        /// <summary>
        /// The flavor of the soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }
    }
}
