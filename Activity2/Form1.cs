using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // codes for disabling the textboxes
            itemnameTxtbox.Enabled = false;
            priceTxtbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changeboxtxtbox.Enabled = false;

            // codes for loading the images in picture boxes
            pictureBox19.Image = Properties.Resources.jollibee_family_meal_1;
            pictureBox14.Image = Properties.Resources.breakfast_mcdo_11;
            pictureBox9.Image = Properties.Resources.inasal_1;
            pictureBox2.Image = Properties.Resources.sisigsilog;
            pictureBox26.Image = Properties.Resources.kfc_chicken_sandwich;
            pictureBox18.Image = Properties.Resources.coffee_float;
            pictureBox13.Image = Properties.Resources.Family_Lauriat_for_6_pax;
            pictureBox8.Image = Properties.Resources.chowfan;
            pictureBox3.Image = Properties.Resources.kfc_family_meal_a;
            pictureBox30.Image = Properties.Resources.fmaily_meal_b_kfc;
            pictureBox17.Image = Properties.Resources.supermeal_a;
            pictureBox12.Image = Properties.Resources.supermeal_b;
            pictureBox7.Image = Properties.Resources.jollibee_family_meal_B;
            pictureBox4.Image = Properties.Resources.bf_meal_c;
            PictureBox34.Image = Properties.Resources.mcdo_group_meal;
            pictureBox16.Image = Properties.Resources.burger_fmaily_bundle;
            pictureBox11.Image = Properties.Resources.nuggets_family_bundle;
            pictureBox6.Image = Properties.Resources.jollibee_breakfast;
            pictureBox5.Image = Properties.Resources.lumpia_breakfast;
            pictureBox38.Image = Properties.Resources.Jollibee_Beef_Tapa_Breakfast_700x700;  

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Jollibee Lumpia Breakfast";
            priceTxtbox.Text = "110.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "KFC Family meal 1";
            priceTxtbox.Text = "575.00";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Sisigsilog";
            priceTxtbox.Text = "100.00";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Jollibee Family meal 1";
            priceTxtbox.Text = "750.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Mcdo Breakfast 1";
            priceTxtbox.Text = "75.00";
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Coffee Float";
            priceTxtbox.Text = "45.00";

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Chicksilog Breakfast ";
            priceTxtbox.Text = "115.00";
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "KFC Chicken Sandwich";
            priceTxtbox.Text = "45.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Family Lauriat";
            priceTxtbox.Text = "775.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Spicy Chowfan";
            priceTxtbox.Text = "115.00";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Jollibee Super Meal A";
            priceTxtbox.Text = "175.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Jollibee Super Meal B";
            priceTxtbox.Text = "175.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Jollibee Family Meal 2";
            priceTxtbox.Text = "675.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Jollibee Breakfast 1";
            priceTxtbox.Text = "105.00";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "MCDO Burger Family Meal";
            priceTxtbox.Text = "775.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "MCDO Nuggets Family Meal";
            priceTxtbox.Text = "675.00";
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Jollibee Cornbeed Breakfast";
            priceTxtbox.Text = "175.00";
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "KFC Family Meal 2";
            priceTxtbox.Text = "675.00";
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "MCDO Group Meal";
            priceTxtbox.Text = "775.00";
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            // Code for inserting or assigning a value to the text property of a textbox
            itemnameTxtbox.Text = "Jollibee Beeftapa Breakfast B";
            priceTxtbox.Text = "115.00";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
