using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaMakerClassLibrary.Services.DataAccessLayer
{
    public class PizzaDAO
    {
        // Class level variables
        private List<PizzaModel> _pizzaOrder

        ///<summary>
        /// Default constructor for the pizza DAO
        ///</summary>
        ///
        public PizzaDAO()
        {
            // Initialize the _pizzaOrder list
            _pizzaOrder = new lisr<PizzaModel>();

        }
    }
}
