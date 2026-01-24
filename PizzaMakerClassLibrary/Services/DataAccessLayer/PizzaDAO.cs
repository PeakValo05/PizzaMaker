using System;
using System.Collections.Generic;
using System.IO;
using PizzaMaker.Models;

namespace PizzaMakerClassLibrary.Services.DataAccessLayer
{
    /// <summary>
    /// Data Access Object (DAO) for handling pizza orders.
    /// Responsible for storing and retrieving pizza order data.
    /// </summary>
    public class PizzaDAO
    {
        // Class level list to hold all pizza orders
        private List<PizzaModels> _pizzaOrder;

        /// <summary>
        /// Default constructor for the PizzaDAO class.
        /// Initializes the pizza order list.
        /// </summary>
        public PizzaDAO()
        {
            _pizzaOrder = new List<PizzaModels>();
        }

        /// <summary>
        /// Adds a new pizza to the current order list.
        /// </summary>
        /// <param name="newPizza">The PizzaModels object representing the pizza to add.</param>
        /// <returns>Returns the total number of pizzas in the current order after adding the new pizza.</returns>
        public int AddPizzaToOrder(PizzaModels newPizza)
        {
            // Add the new pizza to the list
            _pizzaOrder.Add(newPizza);

            // Return the count of pizzas in the order
            return _pizzaOrder.Count;
        }

        /// <summary>
        /// Returns the current list of pizza orders.
        /// </summary>
        /// <returns>List of PizzaModels representing all pizzas in the current order.</returns>
        public List<PizzaModels> GetPizzaOrder()
        {
            return _pizzaOrder;
        }

        /// <summary>
        /// Writes all current pizza orders to a text file.
        /// </summary>
        /// <remarks>
        /// The file is stored in an "App_Data" folder in the application base directory.
        /// Each pizza order is written in a readable format.  
        /// This method handles creating the directory if it does not exist.
        /// </remarks>
        /// <returns>
        /// Returns true if the file was written successfully, false if an exception occurred.
        /// </returns>
        public bool WriteOrderToFile()
        {
            // Construct the file path for storing pizza orders
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data");

            try
            {
                // Ensure the directory exists; create if it does not
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                // Open the file for writing (overwrites existing file)
                using (StreamWriter writer = new StreamWriter(Path.Combine(filePath, "PizzaOrder.txt")))
                {
                    // Loop through each pizza in the order
                    foreach (PizzaModels pizza in _pizzaOrder)
                    {
                        // Build a readable string for each pizza
                        string pizzaString =
                            $"Name: {pizza.ClientName}\n" +
                            $"Ingredients: {string.Join(", ", pizza.Ingredients)}\n" +
                            $"Strange Add Ons: {string.Join(", ", pizza.StrangeAddOns)}\n" +
                            $"Crust: {pizza.Crust}\n" +
                            $"Sauce: {pizza.SauceQty}\n" +
                            $"Cheese: {pizza.CheeseQty}\n" +
                            $"Delivery Time: {pizza.DeliveryTime}\n" +
                            $"Pizza Box Color: {pizza.PizzaBoxColor}\n" +
                            $"Price: {pizza.Price}\n";

                        // Write the pizza string to the file
                        writer.WriteLine(pizzaString);

                        // Optional: separate each pizza visually
                        writer.WriteLine("----------------------------------");
                    }
                }

                // Return success
                return true;
            }
            catch (Exception ex)
            {
                // Optional: log exception to console or debug
                // Console.WriteLine(ex.Message);

                // Return failure
                return false;
            }
        }
    }
}
