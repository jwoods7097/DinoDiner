﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A base class representing the customizable burger
    /// </summary>
    public abstract class Burger : Entree
    {
        /// <summary>
        /// The price of the burger
        /// </summary>
        public override decimal Price
        {
            get
            {
                decimal sum = Patties * 1.50m;

                if (Ketchup) sum += 0.20m;
                if (Mustard) sum += 0.20m;
                if (Pickle) sum += 0.20m;
                if (Mayo) sum += 0.20m;
                if (BBQ) sum += 0.10m;
                if (Onion) sum += 0.40m;
                if (Tomato) sum += 0.40m;
                if (Lettuce) sum += 0.30m;
                if (AmericanCheese) sum += 0.25m;
                if (SwissCheese) sum += 0.25m;
                if (Bacon) sum += 0.50m;
                if (Mushrooms) sum += 0.40m;

                return sum;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint sum = Patties * 204;

                if (Ketchup) sum += 19;
                if (Mustard) sum += 3;
                if (Pickle) sum += 7;
                if (Mayo) sum += 94;
                if (BBQ) sum += 29;
                if (Onion) sum += 44;
                if (Tomato) sum += 22;
                if (Lettuce) sum += 5;
                if (AmericanCheese) sum += 104;
                if (SwissCheese) sum += 106;
                if (Bacon) sum += 43;
                if (Mushrooms) sum += 4;

                return sum;
            }
        }

        /// <summary>
        /// How many patties are on the burger
        /// </summary>
        public virtual uint Patties { get; set; }

        /// <summary>
        /// Indicates the burger is served with ketchup
        /// </summary>
        public virtual bool Ketchup { get; set; }

        /// <summary>
        /// Indicates the burger is served with mustard
        /// </summary>
        public virtual bool Mustard { get; set; }

        /// <summary>
        /// Indicates the burger is served with pickles
        /// </summary>
        public virtual bool Pickle { get; set; }

        /// <summary>
        /// Indicates the burger is served with mayo
        /// </summary>
        public virtual bool Mayo { get; set; }

        /// <summary>
        /// Indicates the burger is served with BBQ sauce
        /// </summary>
        public virtual bool BBQ { get; set; }

        /// <summary>
        /// Indicates the burger is served with onion
        /// </summary>
        public virtual bool Onion { get; set; }

        /// <summary>
        /// Indicates the burger is served with tomato
        /// </summary>
        public virtual bool Tomato { get; set; }

        /// <summary>
        /// Indicates the burger is served with lettuce
        /// </summary>
        public virtual bool Lettuce { get; set; }

        /// <summary>
        /// Indicates the burger is served with American cheese
        /// </summary>
        public virtual bool AmericanCheese { get; set; }

        /// <summary>
        /// Indicates the burger is served with Swiss cheese
        /// </summary>
        public virtual bool SwissCheese { get; set; }

        /// <summary>
        /// Indicates the burger is served with bacon
        /// </summary>
        public virtual bool Bacon { get; set; }

        /// <summary>
        /// Indicates the burger is served with mushrooms
        /// </summary>
        public virtual bool Mushrooms { get; set; }
    }
}
