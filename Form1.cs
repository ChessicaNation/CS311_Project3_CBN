namespace CS311_Project3_CBN
{
    public partial class PizzaNation : Form
    {
        public PizzaNation()
        {
            InitializeComponent();
        }

        
        private void PizzaNation_Load(object sender, EventArgs e)
        {

        }
        
        //This method makes sure the size and crust type have been chosen and if so,
        //it calls the Summarize method
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cboSize.SelectedIndex == -1 || string.IsNullOrEmpty(cboSize.Text))
            {
                MessageBox.Show("Select a size.");
            }//end if
            if (!rdoRegular.Checked && !rdoThick.Checked && !rdoThin.Checked)
            {
                MessageBox.Show("Select a crust type.");
            }//end if
            else if (cboSize.SelectedIndex != -1 && !string.IsNullOrEmpty(cboSize.Text) && rdoRegular.Checked || rdoThick.Checked || rdoThin.Checked)
            {
                Summarize();
            }//end else if

        }//end btnCalculate_Click

        //This method tracks the size, crust type, and toppings chosen and prints a summary and the subtotal, tax, and total
        private void Summarize()
        {
            double subtotal = 0.00;
            string crust = "";
            string toppings = "";

            if (cboSize.GetItemText(cboSize.SelectedItem) == "Small")
            {
                subtotal = 2.00;
            }//end if
            else if (cboSize.GetItemText(cboSize.SelectedItem) == "Medium")
            {
                subtotal = 5.00;
            }//end else if
            else if (cboSize.GetItemText(cboSize.SelectedItem) == "Large")
            {
                subtotal = 10.00;
            }//end else if
            else if (cboSize.GetItemText(cboSize.SelectedItem) == "X-Large")
            {
                subtotal = 15.00;
            }//end else if
            else if (cboSize.GetItemText(cboSize.SelectedItem) == "Ginormous")
            {
                subtotal = 20.00;
            }//end else if

            if (rdoThin.Checked)
                crust = "Thin";
            else if (rdoThick.Checked)
                crust = "Thick";
            else if (rdoRegular.Checked)
                crust = "Regular";

            if (cbkPepperoni.Checked)
            {
                subtotal += 2.00;
                toppings += "Pepperoni\n";
            }//end if
            if (cbkSausage.Checked)
            {
                subtotal += 2.00;
                toppings += "Sausage\n";
            }//end if
            if (cbkCanadianBacon.Checked)
            {
                subtotal += 2.00;
                toppings += "Canadian Bacon\n";
            }//end if
            if (cbkSpicyItalianSausage.Checked)
            {
                subtotal += 2.00;
                toppings += "Spicy Italian Sausage\n";
            }//end if
            if (cbkOnion.Checked)
            {
                subtotal += 1.00;
                toppings += "Onion\n";
            }//end if
            if (cbkGreenPepper.Checked)
            {
                subtotal += 1.00;
                toppings += "Green Pepper\n";
            }//end if
            if (cbkBlackOlives.Checked)
            {
                subtotal += 1.00;
                toppings += "Black Olives\n";
            }//end if
            if (cbkGreenOlives.Checked)
            {
                subtotal += 1.00;
                toppings += "Green Olives\n";
            }//end if
            if (cbkBananaPeppers.Checked)
            {
                subtotal += 1.00;
                toppings += "Banana Peppers\n";
            }//end if
            if (cbkJalapeno.Checked)
            {
                subtotal += 1.00;
                toppings += "Jalapeno\n";
            }//end if
            if (cbkExtraCheese.Checked)
            {
                subtotal += 1.00;
                toppings += "Extra Cheese\n";
            }//end if
            if (cbkMushroom.Checked)
            {
                subtotal += 1.00;
                toppings += "Mushroom\n";
            }//end if

            txtSubTotal.Text = subtotal.ToString("C");

            txtTax.Text = (subtotal * .06).ToString("C");

            txtTotal.Text = (subtotal * 1.06).ToString("C");

            rtfOutput.Clear();
            rtfOutput.SelectionFont = new Font("Arial", 12);
            rtfOutput.SelectedText = "You ordered a " + cboSize.GetItemText(cboSize.SelectedItem) + " pizza with " + 
                crust + " crust and the following toppings: \n";
            rtfOutput.SelectionFont = new Font("Arial", 12);
            rtfOutput.SelectionBullet = true;
            rtfOutput.SelectedText = toppings;
            rtfOutput.SelectionBullet = false;

        }//end Summarize
    }//end class
}//end namespace