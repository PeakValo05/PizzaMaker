using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaMaker.Models
{
    internal class PizzaModels
    {
        // Class properties
        public string ClientName { get; set; }

        public List<string> Ingredients { get; set; }

        public List<string> StrangeAddOns { get; set; }

        public string Crust { get; set; }

        public int SauceQty { get; set; }

        public int CheeseQty { get; set; }

        public DateTime DeliveryTime { get; set; }

        public Color PizzaBoxColor { get; set; }

        public decimal Price { get; set; }
    
        /// <summary>
        ///  Default Constructors for pizza model
        /// </summary>
    public PizzaModels()
        {

            // Declare 1the default properties
            ClientName = "Unknown";
            Ingredients = new List<string>();
            StrangeAddOns = new List<string>();
            Crust = "Unknown";
            SauceQty = 0;
            CheeseQty = 0;
            DeliveryTime = DateTime.Now;
            PizzaBoxColor = Color.White;
            Price = 15m;
        }
    }
}
