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

            // Check the label first
            if (_pizzaOrder == null || _pizzaOrder.Count == 0)
            {

                lblOrderDetails.Text = "No pizzas in the order";
                return;
            }

            foreach (PizzaModels pizza in _pizzaOrder)
            {
                lblOrderDetails.Text +=
                $"Name: {pizza.ClientName}\n" +
                $"Ingredients: {string.Join(", ", pizza.Ingredients)}\n" +
                $"Strange Add Ons: {string.Join(", ", pizza.StrangeAddOns)}\n" +
                $"Crust: {pizza.Crust}\n" +
                $"Sauce: {pizza.SauceQty}\n" +
                $"Cheese: {pizza.CheeseQty}\n" +
                $"Delivery Time: {pizza.DeliveryTime}\n" +
                $"Pizza Box Color: {pizza.PizzaBoxColor}\n" +
                $"Price: {pizza.Price:C2}\n\n" +
                "---------------------------\n";
            }
        }

        private void FrmOrderDetails_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Click Event handler for btnSaveOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnSaveOrderClickEH(object sender, EventArgs e)
        {
            // Declare and initialize
            bool isSaveSuccess = false;

            // Write the order to the file
            isSaveSuccess = _pizzaLogic.WriteOrderToFIle();

            // Check if the save was successful
            if (isSaveSuccess)
            {
                // Show a success message to the user
                MessageBox.Show("The pizza order was saved.");
            }
            else
            {
                // show a failure message to the user
                MessageBox.Show("An error occurred while trying to save your order. Please try again later.");
            }

        }
        /// <summary>
        /// Back button to main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBackClickEH(object sender, EventArgs e)
        {
            // Back button
            this.Close();
        }
    }
}
