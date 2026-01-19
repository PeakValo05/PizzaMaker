/* Jackson Wiser
 * CST-250
 * 01/19/2026
 * Pizza Maker
 * Activity 4
 */

using PizzaMaker.Models;

namespace PizzaMaker
{
    public partial class FrmPizzaMaker : Form
    {
        private PizzaModels pizza;

        /// <summary>
        ///  Default constructor for FrmPizzaMaker
        /// </summary>
        public FrmPizzaMaker()
        {
            InitializeComponent();
            // Initialize the current order
            pizza = new PizzaModels();
            // Disable the create pizza order
            btnCreatePizza.Enabled = false;
            // Disbale the reset form button
            btnResetForm.Enabled = false;

            UpdatePrice();
        }
        /// <summary>
        /// Enables the reset and create buttons
        /// for the order pizza form
        /// </summary>
        public void EnablePizzaCreation()
        {
            // Enable the create pizza button
            btnCreatePizza.Enabled = true;
            // Enable the reset form button
            btnResetForm.Enabled = false;
        }

        private void FrmPizzaMaker_Load(object sender, EventArgs e)
        {

        }

        private void TxtNameLeaveEH(object sender, EventArgs e)
        {
            // Set the pizzas client name to the text of txtName
            pizza.ClientName = txtName.Text;
            // Call the Enable pizza creation method
            EnablePizzaCreation();

        }
        /// <summary>
        /// Update the price of the pizza
        /// </summary>
        public void UpdatePrice()
        {
            // Declare and initialize
            decimal price = 15;
            // Add 50 cents for each ingredient
            price += (pizza.Ingredients.Count * .50m);
            // Add 50 cents for each special add on
            price += (pizza.StrangeAddOns.Count * .50m);
            // add 1$ if the crust if gluten free
            if (pizza.Crust == "Gluten Free")
            {
                price += 1;
            }
            // Update the price of the pizza
            pizza.Price = price;
            // Update lblPizzaPrice
            lblPizzaPrice.Text = $"{price:C2}";
        }
    }
}
