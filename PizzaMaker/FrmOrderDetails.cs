using PizzaMakerClassLibrary.Services.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PizzaMaker.Models;

namespace PizzaMaker
{
    public partial class FrmOrderDetails : Form
    {
        /// <summary>
        /// Parameterized contructor for FrmOrderDetails
        /// </summary>
        /// <param name="pizzaOrder"></param>

        private List<PizzaModels> _pizzaOrder;
        private PizzaLogic _pizzaLogic;
        public FrmOrderDetails(List<PizzaModels> pizzaOrderList, PizzaLogic pizzaBusinessLogic)
        {
            InitializeComponent();

            _pizzaOrder = pizzaOrderList;
            _pizzaLogic = pizzaBusinessLogic;
        }
        public void DisplayPizzas()
        {
            // Clear the label
            lblOrderDetails.Text = "";

            // Loop through the pizza order list
            foreach (PizzaModels pizza in _pizzaOrder)
            {
                lblOrderDetails.Text +=
                    $"Name: {pizza.ClientName}\n" +
                    $"Ingredients: {string.Join(", ", pizza.Ingredients)}\n" +
                    $"Strange Add Ons: {string.Join(", ", pizza.StrangeAddOns)}\n" +
                    $"Crust: {pizza.Crust}\n" +
                    $"Sauce {pizza.SauceQty}\n" +
                    $"Cheese: {pizza.CheeseQty}\n" +
                    $"Delivery Time: {pizza.DeliveryTime}\n" +
                    $"Pizza Box Color: {pizza.PizzaBoxColor}\n" +
                    $"Price {pizza.Price}\n\n"; 



            }

        }

        private void FrmOrderDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
