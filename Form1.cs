using System.Text;

namespace CS311_Project3_CMS
{
    public partial class Form1 : Form
    {

        private enum PizzaSize // assigning price to the size options
        {
            Small = 2,
            medium = 5,
            large = 10,
            xLarge = 15,
            Ginormous = 20
        }

        private enum TwoDollarToppings // assigning price to the two dollar toppings
        {
            Pepperoni, Sausage, CanadianBacon, SpicyItalianSausage = 2
        }

        private enum OtherToppings //assigning price to other toppings
        {
            Onion, GreenPepper, BlackOlives, GreenOlives, BananaPeppers, Jalepeno, Cheese, Mushroom = 1
        }
        public Form1()
        {
            InitializeComponent();
        }

        //method to calculate subtotal and total. Also adds the selections to the rich textbox
        private void Summarize()
        {
            StringBuilder summary = new StringBuilder();
            float subTotal = 0;

            String size = cboPizzaSize.GetItemText(cboPizzaSize.SelectedItem); //selected item from the combobox is assigned a string value
            string crust = ""; //variable to hold crust radio button selection

            if (rdoRegular.Checked)
            {
                crust = "regular";
            }
            if (rdoThick.Checked)
            {
                crust = "thick";
            }
            if (rdoThin.Checked)
            {
                crust = "thin";
            }

            //add the crust and size to stringBuilder
            summary.Append("You ordered a " + size + " pizza with " + crust + " crust and these toppings:" + Environment.NewLine);

            //adds the selected option from the combo box to variable called data
            String data = cboPizzaSize.GetItemText(cboPizzaSize.SelectedItem);
            if (data == "Small")
            {
                subTotal += (float)PizzaSize.Small;
            }
            if (data == "Medium")
            {
                subTotal += (float)PizzaSize.medium;
            }
            if (data == "Large")
            {
                subTotal += (float)PizzaSize.large;
            }
            if (data == "X-Large")
            {
                subTotal += (float)PizzaSize.xLarge;
            }
            if (data == "Ginormous")
            {
                subTotal += (float)PizzaSize.Ginormous;
            }

            //Dictionaries holding key-value pairs. Ckb is the key, float is the value.
            Dictionary<CheckBox, float> twoDollarToppingsMap = new Dictionary<CheckBox, float>
            {
                { ckbPepperoni, 2 },
                { ckbSausage, 2 },
                { ckbBacon, 2 },
                { ckbItalianSausage, 2 }
            };

            Dictionary<CheckBox, float> otherToppingsMap = new Dictionary<CheckBox, float>
            {
                { ckbOnion, 1 },
                { ckbGreenPepper, 1 },
                { ckbBlackOlives, 1 },
                { ckbGreenOlives, 1 },
                { ckbBannanaPeppers, 1 },
                { ckbJalepeno, 1 },
                { ckbExtraCheese, 1 },
                { ckbMushroom, 1 }
            };

            //This loop iterates through each kvp in both dictionaries.
            //If CheckBox object is checked,appends  text to the summary variable
            //Adds the value to subTotal.
            foreach (var kvp in twoDollarToppingsMap)
            {
                if (kvp.Key.Checked)
                {
                    summary.Append("• " + kvp.Key.Text + Environment.NewLine);
                    subTotal += kvp.Value;
                }
            }

            foreach (var kvp in otherToppingsMap)
            {
                if (kvp.Key.Checked)
                {
                    summary.Append("• " + kvp.Key.Text + Environment.NewLine);

                    subTotal += kvp.Value;
                }
            }//end foreach

            //created a string variable to hold the stringbuilder toString
            string toString = summary.ToString();

            //assigned the stringbuilder to the rich text field
            rtfOrderSummary.Text = toString;

            //calculate the subtotal,total,tax
            txtSubTotal.Text = subTotal.ToString("C");

            float tax = subTotal * 0.06F;
            txtTax.Text = tax.ToString("C");

            float total = subTotal + tax;
            txtTotal.Text = total.ToString("C");

        }//end summarize

        //method that runs the summarize method when the calculate button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();

        }//end btnCalculate_Click


    }//end form

}//end namespace