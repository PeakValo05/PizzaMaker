using System;
using System.Collections.Generic;
using System.Text;
using PizzaMaker.Models;


namespace PizzaMakerClassLibrary.Services.DataAccessLayer
{
    public class PizzaDAO
    {
        // Class level variables
        private List<PizzaModels> _pizzaOrder;

        ///<summary>
        /// Default constructor for the pizza DAO
        ///</summary>
        ///
        public PizzaDAO()
        {
            // Initialize the _pizzaOrder list
            _pizzaOrder = new List<PizzaModels>();

        }

        /// <summary>
        /// Add a pizza to the current order
        /// </summary>
        /// <param name="newPizza"></param>
        /// <return></return>
        
        public int AddPizzaToOrder(PizzaModels newPizza)
        {
            // Add the new pizza to the pizzaOrder list
            _pizzaOrder.Add(newPizza);
            // Return the number of pizzas in pizzaOrder
            return _pizzaOrder.Count;
        }
    }
}
