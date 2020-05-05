using Drinks.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks
{
    public partial class ItemForm : Form
    {
        Liquid new_drink;

        public ItemForm()
        {
            InitializeComponent();
            //comboBoxSize.Items.Add(Volume.S);
            //comboBoxSize.Items.Add(Volume.M);
            //comboBoxSize.Items.Add(Volume.L);

        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        //bool caffeine = false;

        private void radioButtonCoffeine_CheckedChanged(object sender, EventArgs e)
        {
            //caffeine = true;
        }

       
          

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.Text == "Drink")
            {
                textBoxName.Enabled = true;
                comboBoxSize.Enabled = true;
                textBoxFruit.Enabled = false;
                textBoxSortOfCoffee.Enabled = false;
                radioButtonCoffeine.Enabled = false;
                buttonSave.Enabled = true;
            }
            else if (comboBoxType.Text == "Fresh")
            {
                textBoxName.Enabled = true;
                comboBoxSize.Enabled = true;
                textBoxFruit.Enabled = true;
                textBoxSortOfCoffee.Enabled = false;
                radioButtonCoffeine.Enabled = false;
                buttonSave.Enabled = true;
            }
            else if (comboBoxType.Text == "Coffee")
            {
                textBoxName.Enabled = false;
                comboBoxSize.Enabled = false;
                textBoxFruit.Enabled = false;
                textBoxSortOfCoffee.Enabled = true;
                radioButtonCoffeine.Enabled = true;
                buttonSave.Enabled = true;
            }
            else if (comboBoxType.Text != "Coffee" || comboBoxType.Text != "Drink" || comboBoxType.Text != "Fresh")
            {
                textBoxName.Enabled = false;
                comboBoxSize.Enabled = false;
                textBoxFruit.Enabled = false;
                textBoxSortOfCoffee.Enabled = false;
                radioButtonCoffeine.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void textBoxFruit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch))
            {
                e.Handled = true;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBoxFruit))
                    {
                        buttonSave.Focus();
                    }
                }

            }
        }

        Volume volume = new Volume();
        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSize.Text == "S")
            {
                volume = Volume.S;
            }
            else if (comboBoxSize.Text == "M")
            {
                volume = Volume.M;
            }
            if (comboBoxSize.Text == "L")
            {
                volume = Volume.L;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            //buttonSave.Enabled = false;
            if (!String.IsNullOrEmpty(textBoxFruit.Text))
            {
                buttonSave.Enabled = true;
            }
        }

        private void textBoxFruit_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxFruit.Text)&&comboBoxType.Text=="Fresh")
            {
                buttonSave.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Close();
            if (String.IsNullOrEmpty(textBoxName.Text) && comboBoxType.Text != "Coffee")
            {
                MessageBox.Show("name is empty", "Warning", MessageBoxButtons.OK);
            }
            if (String.IsNullOrEmpty(textBoxSortOfCoffee.Text) && comboBoxType.Text == "Coffee")
            {
                MessageBox.Show("Sort is empty", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                Liquid item;
                string name = textBoxName.Text;
                string size = comboBoxSize.Text;
                string fruit = textBoxFruit.Text;
                string sort = textBoxSortOfCoffee.Text;
               // MainForm main = new MainForm();
               // main.ShowDialog();

                if (comboBoxType.Text == "Drink")
                {
                    item = new Drink(name, volume);
                    //item.SetPrice(volume);
                    //dataGridView.Rows.Add();
                    var liquid = new Drink(name, volume) as Liquid;
                    //liquidOrders.Add(liquid);
                    //source.Add(GetAnonymous(liquid));
                }

                else if (comboBoxType.Text == "Fresh")
                {
                    item = new Fresh(name, fruit, volume);
                   // item.SetPrice(volume);
                }

                else if (comboBoxType.Text == "Coffee")
                {
                     item = new CoffeeDrink(sort, radioButtonCoffeine.Checked);
                }

                // dataGridViev.
            }
        }

        private void textBoxSortOfCoffee_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
