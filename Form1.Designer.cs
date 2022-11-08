namespace CS311_Project3_CBN
{
    partial class PizzaNation
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
            this.lblPizzaNation = new System.Windows.Forms.Label();
            this.pictPizza = new System.Windows.Forms.PictureBox();
            this.panOptions = new System.Windows.Forms.Panel();
            this.cbkMushroom = new System.Windows.Forms.CheckBox();
            this.cbkExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbkJalapeno = new System.Windows.Forms.CheckBox();
            this.cbkBananaPeppers = new System.Windows.Forms.CheckBox();
            this.cbkGreenOlives = new System.Windows.Forms.CheckBox();
            this.cbkBlackOlives = new System.Windows.Forms.CheckBox();
            this.cbkGreenPepper = new System.Windows.Forms.CheckBox();
            this.cbkOnion = new System.Windows.Forms.CheckBox();
            this.cbkSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.cbkCanadianBacon = new System.Windows.Forms.CheckBox();
            this.cbkSausage = new System.Windows.Forms.CheckBox();
            this.cbkPepperoni = new System.Windows.Forms.CheckBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.grpCrust = new System.Windows.Forms.GroupBox();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.rtfOutput = new System.Windows.Forms.RichTextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).BeginInit();
            this.panOptions.SuspendLayout();
            this.grpCrust.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPizzaNation
            // 
            this.lblPizzaNation.AutoSize = true;
            this.lblPizzaNation.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPizzaNation.Location = new System.Drawing.Point(265, 29);
            this.lblPizzaNation.Name = "lblPizzaNation";
            this.lblPizzaNation.Size = new System.Drawing.Size(410, 75);
            this.lblPizzaNation.TabIndex = 0;
            this.lblPizzaNation.Text = "Pizza Nation";
            // 
            // pictPizza
            // 
            this.pictPizza.Image = global::CS311_Project3_CBN.Properties.Resources.pizza2;
            this.pictPizza.Location = new System.Drawing.Point(130, 21);
            this.pictPizza.Name = "pictPizza";
            this.pictPizza.Size = new System.Drawing.Size(120, 86);
            this.pictPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPizza.TabIndex = 1;
            this.pictPizza.TabStop = false;
            // 
            // panOptions
            // 
            this.panOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panOptions.Controls.Add(this.cbkMushroom);
            this.panOptions.Controls.Add(this.cbkExtraCheese);
            this.panOptions.Controls.Add(this.cbkJalapeno);
            this.panOptions.Controls.Add(this.cbkBananaPeppers);
            this.panOptions.Controls.Add(this.cbkGreenOlives);
            this.panOptions.Controls.Add(this.cbkBlackOlives);
            this.panOptions.Controls.Add(this.cbkGreenPepper);
            this.panOptions.Controls.Add(this.cbkOnion);
            this.panOptions.Controls.Add(this.cbkSpicyItalianSausage);
            this.panOptions.Controls.Add(this.cbkCanadianBacon);
            this.panOptions.Controls.Add(this.cbkSausage);
            this.panOptions.Controls.Add(this.cbkPepperoni);
            this.panOptions.Controls.Add(this.lblToppings);
            this.panOptions.Controls.Add(this.grpCrust);
            this.panOptions.Controls.Add(this.cboSize);
            this.panOptions.Controls.Add(this.lblSize);
            this.panOptions.Location = new System.Drawing.Point(30, 117);
            this.panOptions.Name = "panOptions";
            this.panOptions.Size = new System.Drawing.Size(734, 220);
            this.panOptions.TabIndex = 3;
            // 
            // cbkMushroom
            // 
            this.cbkMushroom.AutoSize = true;
            this.cbkMushroom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkMushroom.Location = new System.Drawing.Point(492, 187);
            this.cbkMushroom.Name = "cbkMushroom";
            this.cbkMushroom.Size = new System.Drawing.Size(110, 23);
            this.cbkMushroom.TabIndex = 15;
            this.cbkMushroom.Text = "Mushroom";
            this.cbkMushroom.UseVisualStyleBackColor = true;
            // 
            // cbkExtraCheese
            // 
            this.cbkExtraCheese.AutoSize = true;
            this.cbkExtraCheese.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkExtraCheese.Location = new System.Drawing.Point(492, 158);
            this.cbkExtraCheese.Name = "cbkExtraCheese";
            this.cbkExtraCheese.Size = new System.Drawing.Size(130, 23);
            this.cbkExtraCheese.TabIndex = 14;
            this.cbkExtraCheese.Text = "Extra Cheese";
            this.cbkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // cbkJalapeno
            // 
            this.cbkJalapeno.AutoSize = true;
            this.cbkJalapeno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkJalapeno.Location = new System.Drawing.Point(492, 129);
            this.cbkJalapeno.Name = "cbkJalapeno";
            this.cbkJalapeno.Size = new System.Drawing.Size(98, 23);
            this.cbkJalapeno.TabIndex = 13;
            this.cbkJalapeno.Text = "Jalapeno";
            this.cbkJalapeno.UseVisualStyleBackColor = true;
            // 
            // cbkBananaPeppers
            // 
            this.cbkBananaPeppers.AutoSize = true;
            this.cbkBananaPeppers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkBananaPeppers.Location = new System.Drawing.Point(492, 100);
            this.cbkBananaPeppers.Name = "cbkBananaPeppers";
            this.cbkBananaPeppers.Size = new System.Drawing.Size(155, 23);
            this.cbkBananaPeppers.TabIndex = 12;
            this.cbkBananaPeppers.Text = "Banana Peppers";
            this.cbkBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // cbkGreenOlives
            // 
            this.cbkGreenOlives.AutoSize = true;
            this.cbkGreenOlives.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkGreenOlives.Location = new System.Drawing.Point(289, 187);
            this.cbkGreenOlives.Name = "cbkGreenOlives";
            this.cbkGreenOlives.Size = new System.Drawing.Size(125, 23);
            this.cbkGreenOlives.TabIndex = 11;
            this.cbkGreenOlives.Text = "Green Olives";
            this.cbkGreenOlives.UseVisualStyleBackColor = true;
            // 
            // cbkBlackOlives
            // 
            this.cbkBlackOlives.AutoSize = true;
            this.cbkBlackOlives.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkBlackOlives.Location = new System.Drawing.Point(289, 158);
            this.cbkBlackOlives.Name = "cbkBlackOlives";
            this.cbkBlackOlives.Size = new System.Drawing.Size(122, 23);
            this.cbkBlackOlives.TabIndex = 10;
            this.cbkBlackOlives.Text = "Black Olives";
            this.cbkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // cbkGreenPepper
            // 
            this.cbkGreenPepper.AutoSize = true;
            this.cbkGreenPepper.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkGreenPepper.Location = new System.Drawing.Point(289, 129);
            this.cbkGreenPepper.Name = "cbkGreenPepper";
            this.cbkGreenPepper.Size = new System.Drawing.Size(133, 23);
            this.cbkGreenPepper.TabIndex = 9;
            this.cbkGreenPepper.Text = "Green Pepper";
            this.cbkGreenPepper.UseVisualStyleBackColor = true;
            // 
            // cbkOnion
            // 
            this.cbkOnion.AutoSize = true;
            this.cbkOnion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkOnion.Location = new System.Drawing.Point(289, 100);
            this.cbkOnion.Name = "cbkOnion";
            this.cbkOnion.Size = new System.Drawing.Size(74, 23);
            this.cbkOnion.TabIndex = 8;
            this.cbkOnion.Text = "Onion";
            this.cbkOnion.UseVisualStyleBackColor = true;
            // 
            // cbkSpicyItalianSausage
            // 
            this.cbkSpicyItalianSausage.AutoSize = true;
            this.cbkSpicyItalianSausage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkSpicyItalianSausage.Location = new System.Drawing.Point(61, 187);
            this.cbkSpicyItalianSausage.Name = "cbkSpicyItalianSausage";
            this.cbkSpicyItalianSausage.Size = new System.Drawing.Size(191, 23);
            this.cbkSpicyItalianSausage.TabIndex = 7;
            this.cbkSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.cbkSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // cbkCanadianBacon
            // 
            this.cbkCanadianBacon.AutoSize = true;
            this.cbkCanadianBacon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkCanadianBacon.Location = new System.Drawing.Point(61, 158);
            this.cbkCanadianBacon.Name = "cbkCanadianBacon";
            this.cbkCanadianBacon.Size = new System.Drawing.Size(155, 23);
            this.cbkCanadianBacon.TabIndex = 6;
            this.cbkCanadianBacon.Text = "Canadian Bacon";
            this.cbkCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // cbkSausage
            // 
            this.cbkSausage.AutoSize = true;
            this.cbkSausage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkSausage.Location = new System.Drawing.Point(61, 129);
            this.cbkSausage.Name = "cbkSausage";
            this.cbkSausage.Size = new System.Drawing.Size(95, 23);
            this.cbkSausage.TabIndex = 5;
            this.cbkSausage.Text = "Sausage";
            this.cbkSausage.UseVisualStyleBackColor = true;
            // 
            // cbkPepperoni
            // 
            this.cbkPepperoni.AutoSize = true;
            this.cbkPepperoni.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbkPepperoni.Location = new System.Drawing.Point(61, 100);
            this.cbkPepperoni.Name = "cbkPepperoni";
            this.cbkPepperoni.Size = new System.Drawing.Size(107, 23);
            this.cbkPepperoni.TabIndex = 4;
            this.cbkPepperoni.Text = "Pepperoni";
            this.cbkPepperoni.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(23, 67);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(87, 19);
            this.lblToppings.TabIndex = 3;
            this.lblToppings.Text = "Toppings:";
            // 
            // grpCrust
            // 
            this.grpCrust.Controls.Add(this.rdoRegular);
            this.grpCrust.Controls.Add(this.rdoThick);
            this.grpCrust.Controls.Add(this.rdoThin);
            this.grpCrust.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpCrust.Location = new System.Drawing.Point(289, 16);
            this.grpCrust.Name = "grpCrust";
            this.grpCrust.Size = new System.Drawing.Size(356, 39);
            this.grpCrust.TabIndex = 2;
            this.grpCrust.TabStop = false;
            this.grpCrust.Text = "Crust Type:";
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(263, 12);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(87, 23);
            this.rdoRegular.TabIndex = 2;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(182, 12);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(69, 23);
            this.rdoThick.TabIndex = 1;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(111, 12);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(61, 23);
            this.rdoThin.TabIndex = 0;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // cboSize
            // 
            this.cboSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(81, 19);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 26);
            this.cboSize.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSize.Location = new System.Drawing.Point(23, 22);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(52, 19);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size: ";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSummary.Location = new System.Drawing.Point(54, 355);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(135, 19);
            this.lblSummary.TabIndex = 4;
            this.lblSummary.Text = "Order Summary:";
            // 
            // rtfOutput
            // 
            this.rtfOutput.Location = new System.Drawing.Point(30, 386);
            this.rtfOutput.Name = "rtfOutput";
            this.rtfOutput.Size = new System.Drawing.Size(541, 275);
            this.rtfOutput.TabIndex = 5;
            this.rtfOutput.Text = "";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(577, 403);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(83, 19);
            this.lblSubTotal.TabIndex = 6;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubTotal.Location = new System.Drawing.Point(664, 401);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 26);
            this.txtSubTotal.TabIndex = 7;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.Window;
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTax.Location = new System.Drawing.Point(664, 448);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 26);
            this.txtTax.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(664, 500);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 9;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(618, 450);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(42, 19);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(608, 502);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 19);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(583, 560);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(181, 98);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // PizzaNation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 685);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.rtfOutput);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.panOptions);
            this.Controls.Add(this.pictPizza);
            this.Controls.Add(this.lblPizzaNation);
            this.Name = "PizzaNation";
            this.Text = "Pizza Nation";
            this.Load += new System.EventHandler(this.PizzaNation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).EndInit();
            this.panOptions.ResumeLayout(false);
            this.panOptions.PerformLayout();
            this.grpCrust.ResumeLayout(false);
            this.grpCrust.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPizzaNation;
        private PictureBox pictPizza;
        private Panel panOptions;
        private ComboBox cboSize;
        private Label lblSize;
        private GroupBox grpCrust;
        private RadioButton rdoRegular;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private CheckBox cbkMushroom;
        private CheckBox cbkExtraCheese;
        private CheckBox cbkJalapeno;
        private CheckBox cbkBananaPeppers;
        private CheckBox cbkGreenOlives;
        private CheckBox cbkBlackOlives;
        private CheckBox cbkGreenPepper;
        private CheckBox cbkOnion;
        private CheckBox cbkSpicyItalianSausage;
        private CheckBox cbkCanadianBacon;
        private CheckBox cbkSausage;
        private CheckBox cbkPepperoni;
        private Label lblToppings;
        private Label lblSummary;
        private RichTextBox rtfOutput;
        private Label lblSubTotal;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Label lblTax;
        private Label lblTotal;
        private Button btnCalculate;
    }
}