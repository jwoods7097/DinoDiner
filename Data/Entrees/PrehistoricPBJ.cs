namespace DinoDiner.Data.Entrees
{
    /// <summary>
    /// A class representing a Prehistoric PBJ sandwich
    /// </summary>
    public class PrehistoricPBJ
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
        public decimal Price { get; } = 3.75m;

        /// <summary>
        /// The calories of the PBJ
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 148;
                if (PeanutButter) calories += 188;
                if (Jelly) calories += 62;
                return calories;
            }
        }
    }
}