using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongMind_Pizza
{
    public partial class Form1 : Form
    {
        bool[] Toppings = new bool[6];

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string PizzaToppings = "Cheese Pizza ";
            int cost = 7;
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked)
            {
                PizzaToppings += "with ";
            }
            if (checkBox1.Checked) { PizzaToppings += "Pepperoni "; cost++; }
            if (checkBox2.Checked) { PizzaToppings += "Mushroom "; cost++; }
            if (checkBox3.Checked) { PizzaToppings += "Chicken "; cost++; }
            if (checkBox4.Checked) { PizzaToppings += "Ham "; cost++; }
            if (checkBox5.Checked) { PizzaToppings += "Pineapple "; cost++; }
            if (checkBox6.Checked) { PizzaToppings += "Onion "; cost++; }
            ListViewItem item = listView1.FindItemWithText(PizzaToppings);
            if (item == null)
            {
                string[] newPizza = { PizzaToppings, "1", cost.ToString() };
                var listViewItem = new ListViewItem(newPizza);
                listView1.Items.Add(listViewItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.FocusedItem.Index);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //increase pizza count
                listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text = (Int32.Parse(listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text) + 1).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //decrease pizza count
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text = (Int32.Parse(listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text) - 1).ToString();
                if (Int32.Parse(listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text) < 1)
                {
                    listView1.Items.RemoveAt(listView1.FocusedItem.Index);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //edit
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = true;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //confirm edit
            listView1.Enabled = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = false;

            string PizzaToppings = "Cheese Pizza ";
            int cost = 7;
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked)
            {
                PizzaToppings += "with ";
            }
            if (checkBox1.Checked) { PizzaToppings += "Pepperoni "; cost++; }
            if (checkBox2.Checked) { PizzaToppings += "Mushroom "; cost++; }
            if (checkBox3.Checked) { PizzaToppings += "Chicken "; cost++; }
            if (checkBox4.Checked) { PizzaToppings += "Ham "; cost++; }
            if (checkBox5.Checked) { PizzaToppings += "Pineapple "; cost++; }
            if (checkBox6.Checked) { PizzaToppings += "Onion "; cost++; }
            ListViewItem item = listView1.FindItemWithText(PizzaToppings);
            if (item == null)
            {
                string[] newPizza = { PizzaToppings, "1", cost.ToString() };
                var listViewItem = new ListViewItem(newPizza);
                listView1.Items[listView1.FocusedItem.Index] = listViewItem;
            }
        }
    }
}
