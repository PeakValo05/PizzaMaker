using PizzaMakerClassLibrary.Services.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using PizzaMaker.Models;

namespace PizzaMakerClassLibrary.Services.BusinessLogicLayer
{
    public class PizzaLogic
    {
        // Declare class level variables
        private PizzaDAO _pizzaDAO;


        /// <summary>
        /// Default constructor for PizzaLogic
        /// </summary>

        public PizzaLogic()
        {
            // Initialize the pizza DAO object
            _pizzaDAO = new PizzaDAO();
        }

        public (bool isValidPizza, int pizzasInOrder) AddPizzaToOrder(PizzaModels newPizza)
        {
            // Validate pizza
            if (newPizza == null ||
                string.IsNullOrWhiteSpace(newPizza.ClientName) ||
                string.IsNullOrWhiteSpace(newPizza.Crust) ||
                newPizza.Crust == "Unknown" ||
                newPizza.Ingredients.Count == 0 ||
                newPizza.CheeseQty <= 0 ||
                newPizza.SauceQty <= 0)
            {
                // Invalid pizza
                return (false, -1);
            }

            // Valid pizza — add to order
            int pizzas = _pizzaDAO.AddPizzaToOrder(newPizza);

            return (true, pizzas);
        }
    }
}
