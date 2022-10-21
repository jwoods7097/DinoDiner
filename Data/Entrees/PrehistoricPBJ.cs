using System.ComponentModel;

namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a Prehistoric PBJ sandwich
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Indicates if the PBJ was made with peanut butter
        /// </summary>
        private bool _peanutButter = true;

        /// <summary>
        /// Public property for _peanutButter, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool PeanutButter
        {
            get => _peanutButter;
            set
            {
                if(_peanutButter != value)
                {
                    _peanutButter = value;
                    AddToSpecialInstructions("Peanut Butter", _peanutButter);
                    OnPropertyChanged(nameof(PeanutButter));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the PBJ was made with jelly
        /// </summary>
        private bool _jelly = true;

        /// <summary>
        /// Public property for _jelly, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Jelly
        {
            get => _jelly;
            set
            {
                if(_jelly != value)
                {
                    _jelly = value;
                    AddToSpecialInstructions("Jelly", _jelly);
                    OnPropertyChanged(nameof(Jelly));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// Indicates the PBJ is served toasted
        /// </summary>
        private bool _toasted = true;

        /// <summary>
        /// Public property for _toasted, invokes PropertyChanged for necessary properties
        /// </summary>
        public bool Toasted
        {
            get => _toasted;
            set
            {
                if (_toasted != value)
                {
                    _toasted = value;

                    // This is hard coded because it is grammatically different than the other properties
                    if (_toasted)
                    {
                        if (SpecialInstructions.Contains("Not Toasted"))
                        {
                            SpecialInstructions.Remove("Not Toasted");
                        }
                        else
                        {
                            SpecialInstructions.Add("Toasted");
                        }
                    }
                    else
                    {
                        if (SpecialInstructions.Contains("Toasted"))
                        {
                            SpecialInstructions.Remove("Toasted");
                        }
                        else
                        {
                            SpecialInstructions.Add("Not Toasted");
                        }
                    }

                    OnPropertyChanged(nameof(Toasted));
                }
            }
        }

        /// <summary>
        /// The price of the PBJ
        /// </summary>
        public override decimal Price { get; } = 3.75m;

        /// <summary>
        /// The calories of the PBJ
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calories = 148;
                if (PeanutButter) calories += 188;
                if (Jelly) calories += 62;
                return calories;
            }
        }

        /// <summary>
        /// The name of the PBJ
        /// </summary>
        public override string Name { get; } = "Prehistoric PBJ";
    }
}