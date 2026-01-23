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
            // Declare and initialize
            int pizzas = -1;
            // Call the DAO AddPizzaToOrder
            pizzas = _pizzaDAO.AddPizzaToOrder(newPizza);
            // Return the pizzas variable
            return (true, pizzas);

        }
    }
}
