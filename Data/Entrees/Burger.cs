using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A base class representing the customizable burger
    /// </summary>
    public class Burger : Entree
    {
        /// <summary>
        /// The name of the burger
        /// </summary>
        public override string Name { get; } = "Burger";

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
        /// The default number of patties, used for generating special instructions
        /// </summary>
        protected uint DefaultPatties { get; set; } = 1;

        /// <summary>
        /// How many patties are on the burger
        /// </summary>
        private uint _patties = 1;

        /// <summary>
        /// Public property for _patties, invokes PropertyChanged for necessary properties
        /// </summary>
        public uint Patties
        {
            get => _patties;
            set
            {
                if (_patties != value)
                {
                    _patties = value;

                    for(int i = 0; i < SpecialInstructions.Count; i++)
                    {
                        if(SpecialInstructions[i].Contains("Patt"))
                        {
                            SpecialInstructions.RemoveAt(i);
                        }
                    }
                    if(_patties != DefaultPatties)
                    {
                        SpecialInstructions.Add(_patties == 1 ? $"{_patties} Patty" : $"{_patties} Patties");
                    }

                    OnPropertyChanged(nameof(Patties));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with ketchup
        /// </summary>
        private bool _ketchup;

        /// <summary>
        /// Public property for _ketchup, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Ketchup
        {
            get => _ketchup;
            set
            {
                if (_ketchup != value)
                {
                    _ketchup = value;
                    AddToSpecialInstructions("Ketchup", _ketchup);
                    OnPropertyChanged(nameof(Ketchup));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with mustard
        /// </summary>
        private bool _mustard;

        /// <summary>
        /// Public property for _mustard, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Mustard
        {
            get => _mustard;
            set
            {
                if (_mustard != value)
                {
                    _mustard = value;
                    AddToSpecialInstructions("Mustard", _mustard);
                    OnPropertyChanged(nameof(Mustard));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with pickles
        /// </summary>
        private bool _pickle;

        /// <summary>
        /// Public property for _pickle, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Pickle
        {
            get => _pickle;
            set
            {
                if (_pickle != value)
                {
                    _pickle = value;
                    AddToSpecialInstructions("Pickle", _pickle);
                    OnPropertyChanged(nameof(Pickle));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with mayo
        /// </summary>
        private bool _mayo;

        /// <summary>
        /// Public property for _mayo, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Mayo
        {
            get => _mayo;
            set
            {
                if (_mayo != value)
                {
                    _mayo = value;
                    AddToSpecialInstructions("Mayo", _mayo);
                    OnPropertyChanged(nameof(Mayo));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with BBQ sauce
        /// </summary>
        private bool _bbq;

        /// <summary>
        /// Public property for _bbq, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool BBQ
        {
            get => _bbq;
            set
            {
                if (_bbq != value)
                {
                    _bbq = value;
                    AddToSpecialInstructions("BBQ", _bbq);
                    OnPropertyChanged(nameof(BBQ));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with onion
        /// </summary>
        private bool _onion;

        /// <summary>
        /// Public property for _onion, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Onion
        {
            get => _onion;
            set
            {
                if (_onion != value)
                {
                    _onion = value;
                    AddToSpecialInstructions("Onion", _onion);
                    OnPropertyChanged(nameof(Onion));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with tomato
        /// </summary>
        private bool _tomato;

        /// <summary>
        /// Public property for _tomato, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Tomato
        {
            get => _tomato;
            set
            {
                if (_tomato != value)
                {
                    _tomato = value;
                    AddToSpecialInstructions("Tomato", _tomato);
                    OnPropertyChanged(nameof(Tomato));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with lettuce
        /// </summary>
        private bool _lettuce;

        /// <summary>
        /// Public property for _lettuce, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Lettuce
        {
            get => _lettuce;
            set
            {
                if (_lettuce != value)
                {
                    _lettuce = value;
                    AddToSpecialInstructions("Lettuce", _lettuce);
                    OnPropertyChanged(nameof(Lettuce));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with American cheese
        /// </summary>
        private bool _americanCheese;

        /// <summary>
        /// Public property for _americanCheese, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool AmericanCheese
        {
            get => _americanCheese;
            set
            {
                if (_americanCheese != value)
                {
                    _americanCheese = value;
                    AddToSpecialInstructions("American Cheese", _americanCheese);
                    OnPropertyChanged(nameof(AmericanCheese));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with Swiss cheese
        /// </summary>
        private bool _swissCheese;

        /// <summary>
        /// Public property for _swissCheese, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool SwissCheese
        {
            get => _swissCheese;
            set
            {
                if (_swissCheese != value)
                {
                    _swissCheese = value;
                    AddToSpecialInstructions("Swiss Cheese", _swissCheese);
                    OnPropertyChanged(nameof(SwissCheese));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with bacon
        /// </summary>
        private bool _bacon;

        /// <summary>
        /// Public property for _bacon, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Bacon
        {
            get => _bacon;
            set
            {
                if (_bacon != value)
                {
                    _bacon = value;
                    AddToSpecialInstructions("Bacon", _bacon);
                    OnPropertyChanged(nameof(Bacon));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the burger is served with mushrooms
        /// </summary>
        private bool _mushrooms;

        /// <summary>
        /// Public property for _mushrooms, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Mushrooms
        {
            get => _mushrooms;
            set
            {
                if (_mushrooms != value)
                {
                    _mushrooms = value;
                    AddToSpecialInstructions("Mushrooms", _mushrooms);
                    OnPropertyChanged(nameof(Mushrooms));
                    OnPropertyChanged(nameof(Price));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }
    }
}
