using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Pizza_App
{
    public partial class Order_Pizza : Form
    {
       
        public Order_Pizza()
        {
            InitializeComponent();
        }



        //Price
        private int Get_Size_Price()
        {
            if (rbSmall.Checked)
                return Convert.ToInt32(rbSmall.Tag);
            else if (rbMeduim.Checked)
                return Convert.ToInt32(rbMeduim.Tag);
            else if(rbLarge.Checked)
                return Convert.ToInt32(rbLarge.Tag);
            return 0;

        }
        private int Get_Crust_Price()
        {
            if (rbThick.Checked)
                return Convert.ToInt32(rbThick.Tag);
            else if (rbThin.Checked)
                return Convert.ToInt32(rbThin.Tag);
            return 0;
        }
        private int Get_Topping_Price()
        {
            int toppings_price = 0;

            if (chCheese.Checked)
                toppings_price+= Convert.ToInt32(chCheese.Tag);
            if (chMashroom.Checked)
                toppings_price += Convert.ToInt32(chMashroom.Tag);
            if (chOlive.Checked)
                toppings_price += Convert.ToInt32(chOlive.Tag);
            if (chPineapple.Checked)
                toppings_price += Convert.ToInt32(chPineapple.Tag);
            if (chtomatoes.Checked)
                toppings_price += Convert.ToInt32(chtomatoes.Tag);
            if(chChicken.Checked)
                toppings_price += Convert.ToInt32(chChicken.Tag);
            return toppings_price;


        }
        private void Update_Total_Price()
        {
            int price = Get_Size_Price() + Get_Crust_Price() + Get_Topping_Price();
            lblPrice.Text = Convert.ToString(price)+" $";
        }
        //------------------------------------
        private void Disable_Screen()
        {
            Box_Size.Enabled = false;
            Box_Place.Enabled = false;
            Box_Topping.Enabled = false;
            Box_Crust.Enabled = false;
            btOrder_Pizza.Enabled = false;
        }
        private void Update_Topping()
        {
            Update_Total_Price();

            string toppings = "";

            if (chCheese.Checked)
                toppings += "Cheese / ";
            if (chChicken.Checked)
                toppings += "Chicken / ";
            if (chMashroom.Checked)
            {
                toppings += "Mashroom / ";
                if (toppings.Split(new string[] { " / "}, StringSplitOptions.RemoveEmptyEntries).Length == 3)
                    toppings = toppings.Insert(toppings.Length, "\n");
            }
            if (chOlive.Checked)
            {
                toppings += "Olive / ";
                if (toppings.Split(new string[] { " / " }, StringSplitOptions.RemoveEmptyEntries).Length == 3)
                    toppings = toppings.Insert(toppings.Length, "\n");
            }
            if (chtomatoes.Checked)
            {
                toppings += "Tomatoes / ";
                if (toppings.Split(new string[] { " / " }, StringSplitOptions.RemoveEmptyEntries).Length == 3)
                    toppings = toppings.Insert(toppings.Length, "\n");
            }
            if (chPineapple.Checked)
                toppings += "Pineapple / ";


            if(toppings.EndsWith("/ "))
            {
                toppings = toppings.Substring(0, toppings.Length - 2);
            }
            

            if (toppings == "")
                toppings = "No Toppings";
            

            



            lblToppings.Text = toppings;
            
        }

        private void Confirm_Order()
        {
            Box_Order_Summery.Visible = true;
            if (MessageBox.Show("Are you sure confirm?","Confirm Order",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                
                MessageBox.Show("Your order is prepering", "", MessageBoxButtons.OK);
                Disable_Screen();
            }
        }
        private bool Check_Requierment()
        {
            if ((rbSmall.Checked == false) && (rbMeduim.Checked == false) && (rbLarge.Checked == false))
            {
                MessageBox.Show("You Must Choice Size.", "return", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if ((rbThick.Checked == false) && (rbThin.Checked == false))
            {
                MessageBox.Show("You Must Choice Crust Type.", "return", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if ((rbEat_In.Checked == false) && (rbTake_Away.Checked == false))
            {
                MessageBox.Show("You Must Choice Place To Eat.", "return", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
       //------------------------------------------------------------------


        //Size
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Update_Total_Price();
            lblSize.Text = "Medium";
            
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            Update_Total_Price();
            lblSize.Text = "Small";
            
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            Update_Total_Price();

            lblSize.Text = "Large";
            
        }

        //Crust
        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            Update_Total_Price();
            lblCrust.Text = "Thin";
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            Update_Total_Price();
            lblCrust.Text = "Thick";
        }

        //Place
        private void rbEat_In_CheckedChanged(object sender, EventArgs e)
        {
           
            lblPlace.Text = "Eat In";
        }

        private void rbTake_Away_CheckedChanged(object sender, EventArgs e)
        {
            
            lblPlace.Text = "Take Away";
        }


        //--------------------------------------------------------

        //Toppings
        private void chCheese_CheckedChanged(object sender, EventArgs e)
        {
            Update_Topping();

        }

        private void chChicken_CheckedChanged(object sender, EventArgs e)
        {
            Update_Topping();
        }

        private void chMashroom_CheckedChanged(object sender, EventArgs e)
        {
            Update_Topping();
        }

        private void chOlive_CheckedChanged(object sender, EventArgs e)
        {
            Update_Topping();
        }

        private void chtomatoes_CheckedChanged(object sender, EventArgs e)
        {
            Update_Topping();
        }

        private void chPineapple_CheckedChanged(object sender, EventArgs e)
        {
            Update_Topping();

        }

        //Order button
        private void btOrder_Pizza_Click(object sender, EventArgs e)
        {


            if(Check_Requierment())
            {
                Confirm_Order();
            }

        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            rbSmall.Checked = false;
            rbMeduim.Checked = false;
            rbLarge.Checked = false;

            rbThick.Checked = false;
            rbThin.Checked = false;

            rbTake_Away.Checked = false;
            rbEat_In.Checked = false;

            chCheese.Checked = false;
            chChicken.Checked = false;
            chMashroom.Checked = false;
            chOlive.Checked = false;
            chPineapple.Checked = false;
            chtomatoes.Checked = false;

            lblCrust.Text = "_";
            lblPlace.Text = "_";
            lblPrice.Text = "_";
            lblSize.Text = "_";
            lblToppings.Text = "No Toppings";

        }




        private void lblPrice_Click(object sender, EventArgs e)
        {
            
        }
        private void label7_Click(object sender, EventArgs e)
        {
            
        }
       
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Order_Pizza_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }


        private void lblCrust_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblToppings_Click(object sender, EventArgs e)
        {

        }

        
    }
}
