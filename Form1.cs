using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Salman_proj
{


    public partial class Form1 : Form
    {
        double tax=0;
        double total = 0;
        double[] Beverages = new double[6];
        double[] Appetizers = new double[7];
        double[] MainCourse = new double[9];
        double[] Dessert = new double[5];
        public Form1()
        {
            InitializeComponent();
            Beverages[0]= 1.95;
            Beverages[1]= 1.50;
            Beverages[2] = 1.25;
            Beverages[3]= 2.95;
            Beverages[4]= 2.50;
            Beverages[5] = 1.50;
            Appetizers[0] = 5.95;
            Appetizers[1] = 6.95;
            Appetizers[2] = 8.95;
            Appetizers[3] = 8.95;
            Appetizers[4] = 10.95;
            Appetizers[5] = 12.95;
            Appetizers[6] = 6.95;
            MainCourse[0] = 13.95;
            MainCourse[1] = 13.95;
            MainCourse[2] = 11.95;
            MainCourse[3] = 19.95;
            MainCourse[4] = 20.95;
            MainCourse[5] = 18.95;
            MainCourse[6] = 13.95;
            MainCourse[7] = 14.95;
            MainCourse[8] = 15.95;
            Dessert[0] = 3.95;
            Dessert[1] = 5.95;
            Dessert[2] = 4.95;
            Dessert[3] = 5.95;
            Dessert[4] = 5.95;
            listBox1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price;
            int index = comboBox1.SelectedIndex;
            listBox1.Items.Add(comboBox1.SelectedItem+"                     "+(Beverages[index]).ToString());
            if (textBox1.Text == "")
            {
                textBox1.Text = Beverages[index].ToString();
            }
            else
            {
                price = double.Parse(textBox1.Text);
                price = price + Beverages[index];
                textBox1.Text = price.ToString();
            }
            
            tax = double.Parse(textBox1.Text)*(8.25/100);
            textBox2.Text = tax.ToString();
            total = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            textBox3.Text = total.ToString();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price;
            int index = comboBox2.SelectedIndex;
            listBox1.Items.Add(comboBox2.SelectedItem + "                     " + (Appetizers[index]).ToString());
            if (textBox1.Text == "")
            {
                textBox1.Text = Beverages[index].ToString();
            }
            else
            {
                price = double.Parse(textBox1.Text);
                price = price + Appetizers[index];
                textBox1.Text = price.ToString();
            }
            tax = double.Parse(textBox1.Text) * (8.25 / 100);
            textBox2.Text = tax.ToString();
            total = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            textBox3.Text = total.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price;
            int index = comboBox3.SelectedIndex;
            listBox1.Items.Add(comboBox3.SelectedItem + "                     " + (MainCourse[index]).ToString());
            if (textBox1.Text == "")
            {
                textBox1.Text = Beverages[index].ToString();
            }
            else
            {
                price = double.Parse(textBox1.Text);
                price = price + MainCourse[index];
                textBox1.Text = price.ToString();
            }
            tax = double.Parse(textBox1.Text) * (8.25 / 100);
            textBox2.Text = tax.ToString();
            total = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            textBox3.Text = total.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price;
            int index = comboBox4.SelectedIndex;
            listBox1.Items.Add(comboBox4.SelectedItem + "                     " + (Dessert[index]).ToString());
            if (textBox1.Text == "")
            {
                textBox1.Text = Beverages[index].ToString();
            }
            else
            {
                price = double.Parse(textBox1.Text);
                price = price + Dessert[index];
                textBox1.Text = price.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            textBox1.Text = "0";// = "";
            textBox2.Text = "0";//.Clear();//.Text = "";
            textBox3.Text = "0";//.Clear();//.Text = "";
            total = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
