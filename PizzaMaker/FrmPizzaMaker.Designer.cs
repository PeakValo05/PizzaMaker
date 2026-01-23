namespace PizzaMaker
{
    partial class FrmPizzaMaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            grpIngredients = new GroupBox();
            chbTomatoes = new CheckBox();
            chbPeppers = new CheckBox();
            chbSausage = new CheckBox();
            chbPineapple = new CheckBox();
            chbMushrooms = new CheckBox();
            chbOlives = new CheckBox();
            chbBacon = new CheckBox();
            chbPepperoni = new CheckBox();
            label2 = new Label();
            lsbStrangeAddOns = new ListBox();
            groupBox1 = new GroupBox();
            rdoGlutenFree = new RadioButton();
            rdoStuffedCrust = new RadioButton();
            rdoDeepDish = new RadioButton();
            rdoThinCrust = new RadioButton();
            groupBox2 = new GroupBox();
            label3 = new Label();
            lblCheese = new Label();
            label4 = new Label();
            lblSauce = new Label();
            hsbSauce = new HScrollBar();
            hsbCheese = new HScrollBar();
            label5 = new Label();
            dtpDeliveryTime = new DateTimePicker();
            label6 = new Label();
            picPizzaBoxColor = new PictureBox();
            lblPizzaPrice = new Label();
            label8 = new Label();
            btnResetForm = new Button();
            btnCreatePizza = new Button();
            txtName = new TextBox();
            grpIngredients.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 20);
            label1.Name = "label1";
            label1.Size = new Size(55, 18);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // grpIngredients
            // 
            grpIngredients.Controls.Add(chbTomatoes);
            grpIngredients.Controls.Add(chbPeppers);
            grpIngredients.Controls.Add(chbSausage);
            grpIngredients.Controls.Add(chbPineapple);
            grpIngredients.Controls.Add(chbMushrooms);
            grpIngredients.Controls.Add(chbOlives);
            grpIngredients.Controls.Add(chbBacon);
            grpIngredients.Controls.Add(chbPepperoni);
            grpIngredients.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpIngredients.Location = new Point(5, 44);
            grpIngredients.Name = "grpIngredients";
            grpIngredients.Size = new Size(282, 149);
            grpIngredients.TabIndex = 2;
            grpIngredients.TabStop = false;
            grpIngredients.Text = "Ingredients";
            // 
            // chbTomatoes
            // 
            chbTomatoes.AutoSize = true;
            chbTomatoes.Location = new Point(163, 109);
            chbTomatoes.Name = "chbTomatoes";
            chbTomatoes.Size = new Size(109, 22);
            chbTomatoes.TabIndex = 10;
            chbTomatoes.Text = "Tomatoes";
            chbTomatoes.UseVisualStyleBackColor = true;
            chbTomatoes.CheckedChanged += CbhIngredientCheckedChangedEH;
            // 
            // chbPeppers
            // 
            chbPeppers.AutoSize = true;
            chbPeppers.Location = new Point(163, 81);
            chbPeppers.Name = "chbPeppers";
            chbPeppers.Size = new Size(94, 22);
            chbPeppers.TabIndex = 9;
            chbPeppers.Text = "Peppers";
            chbPeppers.UseVisualStyleBackColor = true;
            chbPeppers.CheckedChanged += CbhIngredientCheckedChangedEH;
            // 
            // chbSausage
            // 
            chbSausage.AutoSize = true;
            chbSausage.Location = new Point(163, 53);
            chbSausage.Name = "chbSausage";
            chbSausage.Size = new Size(94, 22);
            chbSausage.TabIndex = 8;
            chbSausage.Text = "Sausage";
            chbSausage.UseVisualStyleBackColor = true;
            chbSausage.CheckedChanged += CbhIngredientCheckedChangedEH;
            // 
            // chbPineapple
            // 
            chbPineapple.AutoSize = true;
            chbPineapple.Location = new Point(163, 25);
            chbPineapple.Name = "chbPineapple";
            chbPineapple.Size = new Size(111, 22);
            chbPineapple.TabIndex = 7;
            chbPineapple.Text = "Pineapple";
            chbPineapple.UseVisualStyleBackColor = true;
            chbPineapple.CheckedChanged += CbhIngredientCheckedChangedEH;
            // 
            // chbMushrooms
            // 
            chbMushrooms.AutoSize = true;
            chbMushrooms.Location = new Point(6, 109);
            chbMushrooms.Name = "chbMushrooms";
            chbMushrooms.Size = new Size(124, 22);
            chbMushrooms.TabIndex = 6;
            chbMushrooms.Text = "Mushrooms";
            chbMushrooms.UseVisualStyleBackColor = true;
            chbMushrooms.CheckedChanged += CbhIngredientCheckedChangedEH;
            // 
            // chbOlives
            // 
            chbOlives.AutoSize = true;
            chbOlives.Location = new Point(6, 81);
            chbOlives.Name = "chbOlives";
            chbOlives.Size = new Size(78, 22);
            chbOlives.TabIndex = 5;
            chbOlives.Text = "Olives";
            chbOlives.UseVisualStyleBackColor = true;
            chbOlives.CheckedChanged += CbhIngredientCheckedChangedEH;
            // 
            // chbBacon
            // 
            chbBacon.AutoSize = true;
            chbBacon.Location = new Point(6, 53);
            chbBacon.Name = "chbBacon";
            chbBacon.Size = new Size(78, 22);
            chbBacon.TabIndex = 4;
            chbBacon.Text = "Bacon";
            chbBacon.UseVisualStyleBackColor = true;
            chbBacon.CheckedChanged += CbhIngredientCheckedChangedEH;
            // 
            // chbPepperoni
            // 
            chbPepperoni.AutoSize = true;
            chbPepperoni.Location = new Point(6, 25);
            chbPepperoni.Name = "chbPepperoni";
            chbPepperoni.Size = new Size(113, 22);
            chbPepperoni.TabIndex = 3;
            chbPepperoni.Text = "Pepperoni";
            chbPepperoni.UseVisualStyleBackColor = true;
            chbPepperoni.CheckedChanged += CbhIngredientCheckedChangedEH;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 198);
            label2.Name = "label2";
            label2.Size = new Size(146, 18);
            label2.TabIndex = 3;
            label2.Text = "Strange Add Ons";
            // 
            // lsbStrangeAddOns
            // 
            lsbStrangeAddOns.FormattingEnabled = true;
            lsbStrangeAddOns.Items.AddRange(new object[] { "Hotdogs", "Eggplants", "Artichoke Hearts", "Eggs", "Peanut Butter", "Prosciutto", "Honey", "Chili Thread", "Olive Oil", "Arugula", "Garlic", "Chicken", "Anchovies", "BBQ Sauce", "Green Onion", "Red Onion", "Carrots", "Peanuts" });
            lsbStrangeAddOns.Location = new Point(5, 219);
            lsbStrangeAddOns.Name = "lsbStrangeAddOns";
            lsbStrangeAddOns.SelectionMode = SelectionMode.MultiSimple;
            lsbStrangeAddOns.Size = new Size(146, 148);
            lsbStrangeAddOns.TabIndex = 4;
            lsbStrangeAddOns.SelectedIndexChanged += LsbStrangeAddOnsSelectedIndexChangedEH;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoGlutenFree);
            groupBox1.Controls.Add(rdoStuffedCrust);
            groupBox1.Controls.Add(rdoDeepDish);
            groupBox1.Controls.Add(rdoThinCrust);
            groupBox1.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(157, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(130, 168);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crust";
            // 
            // rdoGlutenFree
            // 
            rdoGlutenFree.AutoSize = true;
            rdoGlutenFree.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoGlutenFree.Location = new Point(6, 109);
            rdoGlutenFree.Name = "rdoGlutenFree";
            rdoGlutenFree.Size = new Size(111, 22);
            rdoGlutenFree.TabIndex = 3;
            rdoGlutenFree.TabStop = true;
            rdoGlutenFree.Text = "Gluten Free";
            rdoGlutenFree.UseVisualStyleBackColor = true;
            rdoGlutenFree.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoStuffedCrust
            // 
            rdoStuffedCrust.AutoSize = true;
            rdoStuffedCrust.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoStuffedCrust.Location = new Point(6, 81);
            rdoStuffedCrust.Name = "rdoStuffedCrust";
            rdoStuffedCrust.Size = new Size(120, 22);
            rdoStuffedCrust.TabIndex = 2;
            rdoStuffedCrust.TabStop = true;
            rdoStuffedCrust.Text = "Stuffed Crust";
            rdoStuffedCrust.UseVisualStyleBackColor = true;
            rdoStuffedCrust.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoDeepDish
            // 
            rdoDeepDish.AutoSize = true;
            rdoDeepDish.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoDeepDish.Location = new Point(6, 53);
            rdoDeepDish.Name = "rdoDeepDish";
            rdoDeepDish.Size = new Size(97, 22);
            rdoDeepDish.TabIndex = 1;
            rdoDeepDish.TabStop = true;
            rdoDeepDish.Text = "Deep Dish";
            rdoDeepDish.UseVisualStyleBackColor = true;
            rdoDeepDish.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // rdoThinCrust
            // 
            rdoThinCrust.AutoSize = true;
            rdoThinCrust.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoThinCrust.Location = new Point(6, 25);
            rdoThinCrust.Name = "rdoThinCrust";
            rdoThinCrust.Size = new Size(102, 22);
            rdoThinCrust.TabIndex = 0;
            rdoThinCrust.TabStop = true;
            rdoThinCrust.Text = "Thin Crust";
            rdoThinCrust.UseVisualStyleBackColor = true;
            rdoThinCrust.CheckedChanged += RdoCrustCheckedChangedEH;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lblCheese);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lblSauce);
            groupBox2.Controls.Add(hsbSauce);
            groupBox2.Controls.Add(hsbCheese);
            groupBox2.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(5, 373);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 155);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Extra Goodies";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(152, 96);
            label3.Name = "label3";
            label3.Size = new Size(28, 18);
            label3.TabIndex = 12;
            label3.Text = "00";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCheese
            // 
            lblCheese.AutoSize = true;
            lblCheese.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCheese.Location = new Point(9, 96);
            lblCheese.Name = "lblCheese";
            lblCheese.Size = new Size(136, 18);
            lblCheese.TabIndex = 11;
            lblCheese.Text = "Amount of Cheese";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(142, 34);
            label4.Name = "label4";
            label4.Size = new Size(28, 18);
            label4.TabIndex = 10;
            label4.Text = "00";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSauce
            // 
            lblSauce.AutoSize = true;
            lblSauce.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSauce.Location = new Point(9, 34);
            lblSauce.Name = "lblSauce";
            lblSauce.Size = new Size(127, 18);
            lblSauce.TabIndex = 7;
            lblSauce.Text = "Amount of Sauce";
            // 
            // hsbSauce
            // 
            hsbSauce.Location = new Point(9, 56);
            hsbSauce.Name = "hsbSauce";
            hsbSauce.Size = new Size(263, 20);
            hsbSauce.TabIndex = 9;
            hsbSauce.ValueChanged += HsbExtraGoodiesValueChangedEH;
            // 
            // hsbCheese
            // 
            hsbCheese.Location = new Point(9, 116);
            hsbCheese.Name = "hsbCheese";
            hsbCheese.Size = new Size(263, 20);
            hsbCheese.TabIndex = 8;
            hsbCheese.ValueChanged += HsbExtraGoodiesValueChangedEH;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(353, 20);
            label5.Name = "label5";
            label5.Size = new Size(123, 18);
            label5.TabIndex = 7;
            label5.Text = "Delivery Time";
            // 
            // dtpDeliveryTime
            // 
            dtpDeliveryTime.CustomFormat = "MM/dd/yyyy hh:mm";
            dtpDeliveryTime.Format = DateTimePickerFormat.Custom;
            dtpDeliveryTime.Location = new Point(353, 44);
            dtpDeliveryTime.Name = "dtpDeliveryTime";
            dtpDeliveryTime.Size = new Size(237, 26);
            dtpDeliveryTime.TabIndex = 8;
            dtpDeliveryTime.ValueChanged += DtpDeliveryTimeValueChangedEH;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(353, 73);
            label6.Name = "label6";
            label6.Size = new Size(137, 18);
            label6.TabIndex = 9;
            label6.Text = "Pizza Box Color";
            // 
            // picPizzaBoxColor
            // 
            picPizzaBoxColor.BorderStyle = BorderStyle.FixedSingle;
            picPizzaBoxColor.Location = new Point(353, 97);
            picPizzaBoxColor.Name = "picPizzaBoxColor";
            picPizzaBoxColor.Size = new Size(237, 96);
            picPizzaBoxColor.TabIndex = 10;
            picPizzaBoxColor.TabStop = false;
            picPizzaBoxColor.Click += PicPizzaBoxColorClickEH;
            // 
            // lblPizzaPrice
            // 
            lblPizzaPrice.AutoSize = true;
            lblPizzaPrice.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPizzaPrice.Location = new Point(353, 199);
            lblPizzaPrice.Name = "lblPizzaPrice";
            lblPizzaPrice.Size = new Size(106, 18);
            lblPizzaPrice.TabIndex = 11;
            lblPizzaPrice.Text = "Pizza Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.IndianRed;
            label8.Location = new Point(465, 199);
            label8.Name = "label8";
            label8.Size = new Size(28, 18);
            label8.TabIndex = 12;
            label8.Text = "$0";
            // 
            // btnResetForm
            // 
            btnResetForm.Location = new Point(353, 224);
            btnResetForm.Name = "btnResetForm";
            btnResetForm.Size = new Size(106, 23);
            btnResetForm.TabIndex = 13;
            btnResetForm.Text = "Reset Form";
            btnResetForm.UseVisualStyleBackColor = true;
            btnResetForm.Click += BtnResetFormClickEH;
            // 
            // btnCreatePizza
            // 
            btnCreatePizza.Location = new Point(484, 224);
            btnCreatePizza.Name = "btnCreatePizza";
            btnCreatePizza.Size = new Size(106, 23);
            btnCreatePizza.TabIndex = 14;
            btnCreatePizza.Text = "Create Pizza";
            btnCreatePizza.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(60, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 26);
            txtName.TabIndex = 1;
            txtName.Leave += TxtNameLeaveEH;
            // 
            // FrmPizzaMaker
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(btnCreatePizza);
            Controls.Add(btnResetForm);
            Controls.Add(label8);
            Controls.Add(lblPizzaPrice);
            Controls.Add(picPizzaBoxColor);
            Controls.Add(label6);
            Controls.Add(dtpDeliveryTime);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lsbStrangeAddOns);
            Controls.Add(label2);
            Controls.Add(grpIngredients);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmPizzaMaker";
            Text = "Pizza Maker";
            Load += FrmPizzaMaker_Load;
            grpIngredients.ResumeLayout(false);
            grpIngredients.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaBoxColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grpIngredients;
        private CheckBox chbPeppers;
        private CheckBox chbSausage;
        private CheckBox chbPineapple;
        private CheckBox chbMushrooms;
        private CheckBox chbOlives;
        private CheckBox chbBacon;
        private CheckBox chbPepperoni;
        private CheckBox chbTomatoes;
        private Label label2;
        private ListBox lsbStrangeAddOns;
        private GroupBox groupBox1;
        private RadioButton rdoThinCrust;
        private RadioButton rdoGlutenFree;
        private RadioButton rdoStuffedCrust;
        private RadioButton rdoDeepDish;
        private GroupBox groupBox2;
        private HScrollBar hsbCheese;
        private Label lblCheese;
        private Label label4;
        private Label lblSauce;
        private HScrollBar hsbSauce;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpDeliveryTime;
        private Label label6;
        private PictureBox picPizzaBoxColor;
        private Label lblPizzaPrice;
        private Label label8;
        private Button btnResetForm;
        private Button btnCreatePizza;
        private TextBox txtName;
    }
}
