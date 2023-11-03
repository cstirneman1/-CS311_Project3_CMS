namespace CS311_Project3_CMS
{
    partial class Form1
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
            lblName = new Label();
            pictPizza = new PictureBox();
            cboPizzaSize = new ComboBox();
            groupBox1 = new GroupBox();
            lblCrust = new Label();
            rdoRegular = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            lblSize = new Label();
            lblToppings = new Label();
            ckbPepperoni = new CheckBox();
            ckbSausage = new CheckBox();
            ckbBacon = new CheckBox();
            ckbItalianSausage = new CheckBox();
            ckbOnion = new CheckBox();
            ckbGreenPepper = new CheckBox();
            ckbBlackOlives = new CheckBox();
            ckbGreenOlives = new CheckBox();
            ckbBannanaPeppers = new CheckBox();
            ckbJalepeno = new CheckBox();
            ckbExtraCheese = new CheckBox();
            ckbMushroom = new CheckBox();
            rtfOrderSummary = new RichTextBox();
            lblOrderSummary = new Label();
            lblSubTotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtSubTotal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictPizza).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe Script", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblName.Location = new Point(325, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(739, 159);
            lblName.TabIndex = 0;
            lblName.Text = "Chris's Pizza";
            // 
            // pictPizza
            // 
            pictPizza.Image = Properties.Resources.Pizza;
            pictPizza.Location = new Point(62, 33);
            pictPizza.Name = "pictPizza";
            pictPizza.Size = new Size(257, 179);
            pictPizza.SizeMode = PictureBoxSizeMode.StretchImage;
            pictPizza.TabIndex = 1;
            pictPizza.TabStop = false;
            // 
            // cboPizzaSize
            // 
            cboPizzaSize.FormattingEnabled = true;
            cboPizzaSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboPizzaSize.Location = new Point(173, 247);
            cboPizzaSize.Name = "cboPizzaSize";
            cboPizzaSize.Size = new Size(182, 33);
            cboPizzaSize.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCrust);
            groupBox1.Controls.Add(rdoRegular);
            groupBox1.Controls.Add(rdoThick);
            groupBox1.Controls.Add(rdoThin);
            groupBox1.Location = new Point(427, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 34);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // lblCrust
            // 
            lblCrust.AutoSize = true;
            lblCrust.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCrust.Location = new Point(0, 4);
            lblCrust.Name = "lblCrust";
            lblCrust.Size = new Size(117, 28);
            lblCrust.TabIndex = 3;
            lblCrust.Text = "Crust Type:";
            lblCrust.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Location = new Point(303, 7);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(96, 29);
            rdoRegular.TabIndex = 2;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Location = new Point(209, 7);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(77, 29);
            rdoThick.TabIndex = 1;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Location = new Point(123, 7);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(70, 29);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(62, 246);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(110, 28);
            lblSize.TabIndex = 4;
            lblSize.Text = "Pizza Size:";
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblToppings.Location = new Point(70, 308);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(102, 28);
            lblToppings.TabIndex = 5;
            lblToppings.Text = "Toppings:";
            // 
            // ckbPepperoni
            // 
            ckbPepperoni.AutoSize = true;
            ckbPepperoni.Location = new Point(152, 340);
            ckbPepperoni.Name = "ckbPepperoni";
            ckbPepperoni.Size = new Size(120, 29);
            ckbPepperoni.TabIndex = 6;
            ckbPepperoni.Text = "Pepporoni";
            ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Location = new Point(151, 375);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(104, 29);
            ckbSausage.TabIndex = 7;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbBacon
            // 
            ckbBacon.AutoSize = true;
            ckbBacon.Location = new Point(152, 410);
            ckbBacon.Name = "ckbBacon";
            ckbBacon.Size = new Size(164, 29);
            ckbBacon.TabIndex = 8;
            ckbBacon.Text = "Canadian Bacon";
            ckbBacon.UseVisualStyleBackColor = true;
            // 
            // ckbItalianSausage
            // 
            ckbItalianSausage.AutoSize = true;
            ckbItalianSausage.Location = new Point(152, 445);
            ckbItalianSausage.Name = "ckbItalianSausage";
            ckbItalianSausage.Size = new Size(203, 29);
            ckbItalianSausage.TabIndex = 9;
            ckbItalianSausage.Text = "Spicy Italian Sausage";
            ckbItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Location = new Point(451, 340);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(87, 29);
            ckbOnion.TabIndex = 10;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            ckbGreenPepper.AutoSize = true;
            ckbGreenPepper.Location = new Point(451, 375);
            ckbGreenPepper.Name = "ckbGreenPepper";
            ckbGreenPepper.Size = new Size(144, 29);
            ckbGreenPepper.TabIndex = 11;
            ckbGreenPepper.Text = "Green Pepper";
            ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            ckbBlackOlives.AutoSize = true;
            ckbBlackOlives.Location = new Point(451, 410);
            ckbBlackOlives.Name = "ckbBlackOlives";
            ckbBlackOlives.Size = new Size(131, 29);
            ckbBlackOlives.TabIndex = 12;
            ckbBlackOlives.Text = "Black Olives";
            ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            ckbGreenOlives.AutoSize = true;
            ckbGreenOlives.Location = new Point(451, 445);
            ckbGreenOlives.Name = "ckbGreenOlives";
            ckbGreenOlives.Size = new Size(137, 29);
            ckbGreenOlives.TabIndex = 13;
            ckbGreenOlives.Text = "Green Olives";
            ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBannanaPeppers
            // 
            ckbBannanaPeppers.AutoSize = true;
            ckbBannanaPeppers.Location = new Point(703, 340);
            ckbBannanaPeppers.Name = "ckbBannanaPeppers";
            ckbBannanaPeppers.Size = new Size(163, 29);
            ckbBannanaPeppers.TabIndex = 14;
            ckbBannanaPeppers.Text = "Banana Peppers";
            ckbBannanaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            ckbJalepeno.AutoSize = true;
            ckbJalepeno.Location = new Point(703, 375);
            ckbJalepeno.Name = "ckbJalepeno";
            ckbJalepeno.Size = new Size(107, 29);
            ckbJalepeno.TabIndex = 15;
            ckbJalepeno.Text = "Jalepeno";
            ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            ckbExtraCheese.AutoSize = true;
            ckbExtraCheese.Location = new Point(703, 410);
            ckbExtraCheese.Name = "ckbExtraCheese";
            ckbExtraCheese.Size = new Size(137, 29);
            ckbExtraCheese.TabIndex = 16;
            ckbExtraCheese.Text = "Extra Cheese";
            ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Location = new Point(703, 445);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(126, 29);
            ckbMushroom.TabIndex = 17;
            ckbMushroom.Text = "Mushroom";
            ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // rtfOrderSummary
            // 
            rtfOrderSummary.Location = new Point(70, 537);
            rtfOrderSummary.Name = "rtfOrderSummary";
            rtfOrderSummary.Size = new Size(573, 300);
            rtfOrderSummary.TabIndex = 18;
            rtfOrderSummary.Text = "";
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderSummary.Location = new Point(70, 506);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(167, 28);
            lblOrderSummary.TabIndex = 19;
            lblOrderSummary.Text = "Order Summary:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(672, 549);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(99, 28);
            lblSubTotal.TabIndex = 20;
            lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTax.Location = new Point(720, 594);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(49, 28);
            lblTax.TabIndex = 21;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(705, 638);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 28);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "Total:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(775, 553);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(231, 31);
            txtSubTotal.TabIndex = 23;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(775, 594);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(231, 31);
            txtTax.TabIndex = 24;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(775, 638);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(231, 31);
            txtTotal.TabIndex = 25;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(672, 717);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(334, 102);
            btnCalculate.TabIndex = 26;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 849);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubTotal);
            Controls.Add(lblOrderSummary);
            Controls.Add(rtfOrderSummary);
            Controls.Add(ckbMushroom);
            Controls.Add(ckbExtraCheese);
            Controls.Add(ckbJalepeno);
            Controls.Add(ckbBannanaPeppers);
            Controls.Add(ckbGreenOlives);
            Controls.Add(ckbBlackOlives);
            Controls.Add(ckbGreenPepper);
            Controls.Add(ckbOnion);
            Controls.Add(ckbItalianSausage);
            Controls.Add(ckbBacon);
            Controls.Add(ckbSausage);
            Controls.Add(ckbPepperoni);
            Controls.Add(lblToppings);
            Controls.Add(lblSize);
            Controls.Add(groupBox1);
            Controls.Add(cboPizzaSize);
            Controls.Add(pictPizza);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Chris's Pizza";
            ((System.ComponentModel.ISupportInitialize)pictPizza).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblName;
        private PictureBox pictPizza;
        private ComboBox cboPizzaSize;
        private GroupBox groupBox1;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private RadioButton rdoRegular;
        private Label lblCrust;
        private Label lblSize;
        private Label lblToppings;
        private CheckBox ckbPepperoni;
        private CheckBox ckbSausage;
        private CheckBox ckbBacon;
        private CheckBox ckbItalianSausage;
        private CheckBox ckbOnion;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbBannanaPeppers;
        private CheckBox ckbJalepeno;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbMushroom;
        private RichTextBox rtfOrderSummary;
        private Label lblOrderSummary;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnCalculate;
    }
}