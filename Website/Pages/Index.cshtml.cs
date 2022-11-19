using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoDiner.Data;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Drinks;

namespace Website.Pages
{
    /// <summary>
    /// Menu Page for Dino Diner website
    /// </summary>
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The parts of the item name to search for
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// The types of items to filter
        /// </summary>
        public string[] ItemTypes { get; set; } = { nameof(Entree), nameof(Side), nameof(Drink) };

        /// <summary>
        /// The minimum calories to search for
        /// </summary>
        public uint? CaloriesMin { get; set; }

        /// <summary>
        /// The maximum calories to search for
        /// </summary>
        public uint? CaloriesMax { get; set; }

        /// <summary>
        /// The minimum price to search for
        /// </summary>
        public decimal? PriceMin { get; set; }

        /// <summary>
        /// The maximum price to search for
        /// </summary>
        public decimal? PriceMax { get; set; }

        /// <summary>
        /// The filtered list of items
        /// </summary>
        public IEnumerable<MenuItem> Items { get; set; }

        /// <summary>
        /// Parses HTML GET requests
        /// </summary>
        /// <param name="searchTerms">The parts of the item name to search for</param>
        /// <param name="itemTypes">The type of menu item (entree, side, or drink)</param>
        /// <param name="caloriesMin">The minimum calories</param>
        /// <param name="caloriesMax">The maximum calories</param>
        /// <param name="priceMin">The minimum price</param>
        /// <param name="priceMax">The maximum price</param>
        public void OnGet(string searchTerms, string[] itemTypes, uint? caloriesMin, uint? caloriesMax, decimal? priceMin, decimal? priceMax)
        {
            this.SearchTerms = searchTerms;
            if(itemTypes != null && itemTypes.Length != 0)
            {
                this.ItemTypes = itemTypes;
            }
            this.CaloriesMin = caloriesMin;
            this.CaloriesMax = caloriesMax;
            this.PriceMin = priceMin;
            this.PriceMax = priceMax;
            Items = Menu.FullMenu;
            if (ItemTypes != null)
            {
                if(!ItemTypes.Contains(nameof(Entree)))
                {
                    Items = Items.Where(item => item is not Entree);
                }
                if (!ItemTypes.Contains(nameof(Side)))
                {
                    Items = Items.Where(item => item is not Side);
                }
                if (!ItemTypes.Contains(nameof(Drink)))
                {
                    Items = Items.Where(item => item is not Drink);
                }
            }
            if (SearchTerms != null)
            {
                foreach(string term in searchTerms.Split(" "))
                {
                    Items = Items.Where(item => item.Name.Contains(term, StringComparison.InvariantCultureIgnoreCase));
                }
            }
            if(CaloriesMin != null)
            {
                Items = Items.Where(item => item.Calories >= CaloriesMin);
            }
            if(CaloriesMax != null)
            {
                Items = Items.Where(item => item.Calories <= CaloriesMax);
            }
            if (PriceMin != null)
            {
                Items = Items.Where(item => item.Price >= PriceMin);
            }
            if(PriceMax != null)
            {
                Items = Items.Where(item => item.Price <= PriceMax);
            }
        }
    }
}
