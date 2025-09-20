namespace Simple_Pizza_App
{
    partial class Order_Pizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.Box_Size = new System.Windows.Forms.GroupBox();
            this.Box_Crust = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.Box_Place = new System.Windows.Forms.GroupBox();
            this.rbTake_Away = new System.Windows.Forms.RadioButton();
            this.rbEat_In = new System.Windows.Forms.RadioButton();
            this.Box_Topping = new System.Windows.Forms.GroupBox();
            this.chPineapple = new System.Windows.Forms.CheckBox();
            this.chtomatoes = new System.Windows.Forms.CheckBox();
            this.chOlive = new System.Windows.Forms.CheckBox();
            this.chMashroom = new System.Windows.Forms.CheckBox();
            this.chChicken = new System.Windows.Forms.CheckBox();
            this.chCheese = new System.Windows.Forms.CheckBox();
            this.btOrder_Pizza = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Box_Order_Summery = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_Size.SuspendLayout();
            this.Box_Crust.SuspendLayout();
            this.Box_Place.SuspendLayout();
            this.Box_Topping.SuspendLayout();
            this.Box_Order_Summery.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.BackColor = System.Drawing.Color.Transparent;
            this.rbSmall.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.ForeColor = System.Drawing.Color.White;
            this.rbSmall.Location = new System.Drawing.Point(24, 29);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(97, 30);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = false;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.BackColor = System.Drawing.Color.Transparent;
            this.rbMeduim.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeduim.ForeColor = System.Drawing.Color.White;
            this.rbMeduim.Location = new System.Drawing.Point(24, 65);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(123, 30);
            this.rbMeduim.TabIndex = 1;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = false;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.BackColor = System.Drawing.Color.Transparent;
            this.rbLarge.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarge.ForeColor = System.Drawing.Color.White;
            this.rbLarge.Location = new System.Drawing.Point(24, 105);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(86, 30);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Larg";
            this.rbLarge.UseVisualStyleBackColor = false;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // Box_Size
            // 
            this.Box_Size.BackColor = System.Drawing.Color.Transparent;
            this.Box_Size.Controls.Add(this.rbSmall);
            this.Box_Size.Controls.Add(this.rbLarge);
            this.Box_Size.Controls.Add(this.rbMeduim);
            this.Box_Size.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Size.ForeColor = System.Drawing.Color.White;
            this.Box_Size.Location = new System.Drawing.Point(36, 119);
            this.Box_Size.Name = "Box_Size";
            this.Box_Size.Size = new System.Drawing.Size(207, 146);
            this.Box_Size.TabIndex = 3;
            this.Box_Size.TabStop = false;
            this.Box_Size.Text = "Size";
            this.Box_Size.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Box_Crust
            // 
            this.Box_Crust.BackColor = System.Drawing.Color.Transparent;
            this.Box_Crust.Controls.Add(this.rbThick);
            this.Box_Crust.Controls.Add(this.rbThin);
            this.Box_Crust.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Crust.ForeColor = System.Drawing.Color.White;
            this.Box_Crust.Location = new System.Drawing.Point(36, 281);
            this.Box_Crust.Name = "Box_Crust";
            this.Box_Crust.Size = new System.Drawing.Size(207, 134);
            this.Box_Crust.TabIndex = 4;
            this.Box_Crust.TabStop = false;
            this.Box_Crust.Text = "Crust Tybe";
            this.Box_Crust.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.BackColor = System.Drawing.Color.Transparent;
            this.rbThick.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThick.ForeColor = System.Drawing.Color.White;
            this.rbThick.Location = new System.Drawing.Point(24, 82);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(166, 30);
            this.rbThick.TabIndex = 2;
            this.rbThick.TabStop = true;
            this.rbThick.Tag = "10";
            this.rbThick.Text = "Thick Crust";
            this.rbThick.UseVisualStyleBackColor = false;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.BackColor = System.Drawing.Color.Transparent;
            this.rbThin.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.ForeColor = System.Drawing.Color.White;
            this.rbThin.Location = new System.Drawing.Point(24, 46);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(154, 30);
            this.rbThin.TabIndex = 1;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = false;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // Box_Place
            // 
            this.Box_Place.BackColor = System.Drawing.Color.Transparent;
            this.Box_Place.Controls.Add(this.rbTake_Away);
            this.Box_Place.Controls.Add(this.rbEat_In);
            this.Box_Place.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Place.ForeColor = System.Drawing.Color.White;
            this.Box_Place.Location = new System.Drawing.Point(36, 441);
            this.Box_Place.Name = "Box_Place";
            this.Box_Place.Size = new System.Drawing.Size(207, 124);
            this.Box_Place.TabIndex = 5;
            this.Box_Place.TabStop = false;
            this.Box_Place.Text = "Where To Eat";
            this.Box_Place.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbTake_Away
            // 
            this.rbTake_Away.AutoSize = true;
            this.rbTake_Away.BackColor = System.Drawing.Color.Transparent;
            this.rbTake_Away.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTake_Away.ForeColor = System.Drawing.Color.White;
            this.rbTake_Away.Location = new System.Drawing.Point(24, 82);
            this.rbTake_Away.Name = "rbTake_Away";
            this.rbTake_Away.Size = new System.Drawing.Size(152, 30);
            this.rbTake_Away.TabIndex = 2;
            this.rbTake_Away.TabStop = true;
            this.rbTake_Away.Text = "Take Away";
            this.rbTake_Away.UseVisualStyleBackColor = false;
            this.rbTake_Away.CheckedChanged += new System.EventHandler(this.rbTake_Away_CheckedChanged);
            // 
            // rbEat_In
            // 
            this.rbEat_In.AutoSize = true;
            this.rbEat_In.BackColor = System.Drawing.Color.Transparent;
            this.rbEat_In.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEat_In.ForeColor = System.Drawing.Color.White;
            this.rbEat_In.Location = new System.Drawing.Point(24, 50);
            this.rbEat_In.Name = "rbEat_In";
            this.rbEat_In.Size = new System.Drawing.Size(105, 30);
            this.rbEat_In.TabIndex = 1;
            this.rbEat_In.TabStop = true;
            this.rbEat_In.Text = "Eat In";
            this.rbEat_In.UseVisualStyleBackColor = false;
            this.rbEat_In.CheckedChanged += new System.EventHandler(this.rbEat_In_CheckedChanged);
            // 
            // Box_Topping
            // 
            this.Box_Topping.BackColor = System.Drawing.Color.Transparent;
            this.Box_Topping.Controls.Add(this.chPineapple);
            this.Box_Topping.Controls.Add(this.chtomatoes);
            this.Box_Topping.Controls.Add(this.chOlive);
            this.Box_Topping.Controls.Add(this.chMashroom);
            this.Box_Topping.Controls.Add(this.chChicken);
            this.Box_Topping.Controls.Add(this.chCheese);
            this.Box_Topping.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Topping.ForeColor = System.Drawing.Color.White;
            this.Box_Topping.Location = new System.Drawing.Point(328, 119);
            this.Box_Topping.Name = "Box_Topping";
            this.Box_Topping.Size = new System.Drawing.Size(210, 333);
            this.Box_Topping.TabIndex = 6;
            this.Box_Topping.TabStop = false;
            this.Box_Topping.Text = "Toppings";
            this.Box_Topping.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // chPineapple
            // 
            this.chPineapple.AutoSize = true;
            this.chPineapple.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chPineapple.Location = new System.Drawing.Point(18, 274);
            this.chPineapple.Name = "chPineapple";
            this.chPineapple.Size = new System.Drawing.Size(144, 30);
            this.chPineapple.TabIndex = 5;
            this.chPineapple.Tag = "10";
            this.chPineapple.Text = "Pineapple";
            this.chPineapple.UseVisualStyleBackColor = true;
            this.chPineapple.CheckedChanged += new System.EventHandler(this.chPineapple_CheckedChanged);
            // 
            // chtomatoes
            // 
            this.chtomatoes.AutoSize = true;
            this.chtomatoes.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chtomatoes.Location = new System.Drawing.Point(18, 228);
            this.chtomatoes.Name = "chtomatoes";
            this.chtomatoes.Size = new System.Drawing.Size(140, 30);
            this.chtomatoes.TabIndex = 4;
            this.chtomatoes.Tag = "10";
            this.chtomatoes.Text = "Tomatoes";
            this.chtomatoes.UseVisualStyleBackColor = true;
            this.chtomatoes.CheckedChanged += new System.EventHandler(this.chtomatoes_CheckedChanged);
            // 
            // chOlive
            // 
            this.chOlive.AutoSize = true;
            this.chOlive.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chOlive.Location = new System.Drawing.Point(18, 182);
            this.chOlive.Name = "chOlive";
            this.chOlive.Size = new System.Drawing.Size(92, 30);
            this.chOlive.TabIndex = 3;
            this.chOlive.Tag = "10";
            this.chOlive.Text = "Olive";
            this.chOlive.UseVisualStyleBackColor = true;
            this.chOlive.CheckedChanged += new System.EventHandler(this.chOlive_CheckedChanged);
            // 
            // chMashroom
            // 
            this.chMashroom.AutoSize = true;
            this.chMashroom.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chMashroom.Location = new System.Drawing.Point(18, 136);
            this.chMashroom.Name = "chMashroom";
            this.chMashroom.Size = new System.Drawing.Size(151, 30);
            this.chMashroom.TabIndex = 2;
            this.chMashroom.Tag = "10";
            this.chMashroom.Text = "Mushroom";
            this.chMashroom.UseVisualStyleBackColor = true;
            this.chMashroom.CheckedChanged += new System.EventHandler(this.chMashroom_CheckedChanged);
            // 
            // chChicken
            // 
            this.chChicken.AutoSize = true;
            this.chChicken.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chChicken.Location = new System.Drawing.Point(18, 90);
            this.chChicken.Name = "chChicken";
            this.chChicken.Size = new System.Drawing.Size(125, 30);
            this.chChicken.TabIndex = 1;
            this.chChicken.Tag = "10";
            this.chChicken.Text = "Chicken";
            this.chChicken.UseVisualStyleBackColor = true;
            this.chChicken.CheckedChanged += new System.EventHandler(this.chChicken_CheckedChanged);
            // 
            // chCheese
            // 
            this.chCheese.AllowDrop = true;
            this.chCheese.AutoSize = true;
            this.chCheese.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chCheese.Location = new System.Drawing.Point(18, 44);
            this.chCheese.Name = "chCheese";
            this.chCheese.Size = new System.Drawing.Size(181, 30);
            this.chCheese.TabIndex = 0;
            this.chCheese.Tag = "10";
            this.chCheese.Text = "Extra Cheese";
            this.chCheese.UseVisualStyleBackColor = true;
            this.chCheese.CheckedChanged += new System.EventHandler(this.chCheese_CheckedChanged);
            // 
            // btOrder_Pizza
            // 
            this.btOrder_Pizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btOrder_Pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder_Pizza.Location = new System.Drawing.Point(328, 463);
            this.btOrder_Pizza.Name = "btOrder_Pizza";
            this.btOrder_Pizza.Size = new System.Drawing.Size(103, 43);
            this.btOrder_Pizza.TabIndex = 7;
            this.btOrder_Pizza.Text = "Order Pizza";
            this.btOrder_Pizza.UseVisualStyleBackColor = false;
            this.btOrder_Pizza.Click += new System.EventHandler(this.btOrder_Pizza_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_Button.Location = new System.Drawing.Point(435, 463);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(103, 43);
            this.Reset_Button.TabIndex = 8;
            this.Reset_Button.Text = "Reset Order";
            this.Reset_Button.UseVisualStyleBackColor = false;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(327, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "Make Your Pizza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 36);
            this.label6.TabIndex = 10;
            // 
            // Box_Order_Summery
            // 
            this.Box_Order_Summery.BackColor = System.Drawing.Color.Transparent;
            this.Box_Order_Summery.Controls.Add(this.lblPrice);
            this.Box_Order_Summery.Controls.Add(this.lblPlace);
            this.Box_Order_Summery.Controls.Add(this.lblCrust);
            this.Box_Order_Summery.Controls.Add(this.lblToppings);
            this.Box_Order_Summery.Controls.Add(this.lblSize);
            this.Box_Order_Summery.Controls.Add(this.label7);
            this.Box_Order_Summery.Controls.Add(this.label6);
            this.Box_Order_Summery.Controls.Add(this.label5);
            this.Box_Order_Summery.Controls.Add(this.label4);
            this.Box_Order_Summery.Controls.Add(this.label3);
            this.Box_Order_Summery.Controls.Add(this.label2);
            this.Box_Order_Summery.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_Order_Summery.ForeColor = System.Drawing.Color.White;
            this.Box_Order_Summery.Location = new System.Drawing.Point(613, 119);
            this.Box_Order_Summery.Name = "Box_Order_Summery";
            this.Box_Order_Summery.Size = new System.Drawing.Size(422, 398);
            this.Box_Order_Summery.TabIndex = 10;
            this.Box_Order_Summery.TabStop = false;
            this.Box_Order_Summery.Text = "Order Summary";
            this.Box_Order_Summery.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(179, 348);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 43);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "_";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.ForeColor = System.Drawing.Color.Black;
            this.lblPlace.Location = new System.Drawing.Point(219, 287);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(25, 30);
            this.lblPlace.TabIndex = 16;
            this.lblPlace.Text = "_";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrust.ForeColor = System.Drawing.Color.Black;
            this.lblCrust.Location = new System.Drawing.Point(219, 225);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(23, 26);
            this.lblCrust.TabIndex = 15;
            this.lblCrust.Text = "_";
            this.lblCrust.Click += new System.EventHandler(this.lblCrust_Click);
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.ForeColor = System.Drawing.Color.Black;
            this.lblToppings.Location = new System.Drawing.Point(17, 162);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(130, 22);
            this.lblToppings.TabIndex = 14;
            this.lblToppings.Text = "No Toppings";
            this.lblToppings.Click += new System.EventHandler(this.lblToppings_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Black;
            this.lblSize.Location = new System.Drawing.Point(134, 43);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(23, 26);
            this.lblSize.TabIndex = 13;
            this.lblSize.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 39);
            this.label7.TabIndex = 11;
            this.label7.Text = "Price : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Where Eat : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Crust Tybe : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toppings : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Size : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Order_Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simple_Pizza_App.Properties.Resources.WhatsApp_Image_2025_09_18_at_08_00_25_714f834c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 668);
            this.Controls.Add(this.Box_Order_Summery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.btOrder_Pizza);
            this.Controls.Add(this.Box_Topping);
            this.Controls.Add(this.Box_Place);
            this.Controls.Add(this.Box_Crust);
            this.Controls.Add(this.Box_Size);
            this.Name = "Order_Pizza";
            this.Text = "Order_Pizza";
            this.Load += new System.EventHandler(this.Order_Pizza_Load);
            this.Box_Size.ResumeLayout(false);
            this.Box_Size.PerformLayout();
            this.Box_Crust.ResumeLayout(false);
            this.Box_Crust.PerformLayout();
            this.Box_Place.ResumeLayout(false);
            this.Box_Place.PerformLayout();
            this.Box_Topping.ResumeLayout(false);
            this.Box_Topping.PerformLayout();
            this.Box_Order_Summery.ResumeLayout(false);
            this.Box_Order_Summery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox Box_Size;
        private System.Windows.Forms.GroupBox Box_Crust;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox Box_Place;
        private System.Windows.Forms.RadioButton rbTake_Away;
        private System.Windows.Forms.RadioButton rbEat_In;
        private System.Windows.Forms.GroupBox Box_Topping;
        private System.Windows.Forms.CheckBox chPineapple;
        private System.Windows.Forms.CheckBox chtomatoes;
        private System.Windows.Forms.CheckBox chOlive;
        private System.Windows.Forms.CheckBox chMashroom;
        private System.Windows.Forms.CheckBox chChicken;
        private System.Windows.Forms.CheckBox chCheese;
        private System.Windows.Forms.Button btOrder_Pizza;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Box_Order_Summery;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}