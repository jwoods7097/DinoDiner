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
        public bool PeanutButter { get; set; } = true;

        /// <summary>
        /// Indicates the PBJ was made with jelly
        /// </summary>
        public bool Jelly { get; set; } = true;

        /// <summary>
        /// Indicates the PBJ is served toasted
        /// </summary>
        public bool Toasted { get; set; } = true;

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