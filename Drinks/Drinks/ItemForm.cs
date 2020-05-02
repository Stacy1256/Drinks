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
        Liquid new_drink = new Liquid();

        public ItemForm()
        {
            InitializeComponent();
            comboBoxSize.Items.Add(Volume.S);
            comboBoxSize.Items.Add(Volume.M);
            comboBoxSize.Items.Add(Volume.L);

        }
        

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool caffeine = false;

        private void radioButtonCoffeine_CheckedChanged(object sender, EventArgs e)
        {
            caffeine = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Close();
            string name = textBoxName.Text;
            string size = comboBoxSize.Text;
            string fruit = textBoxFruit.Text;
            string sort = textBoxSortOfCoffee.Text;
            MainForm main = new MainForm();
            main.ShowDialog();
            if (comboBoxType.Text == "Drink")
            {
                Drink item = new Drink(name);
                // how to add volume and price?
            }
            if (comboBoxType.Text == "Fresh")
            {
                Fresh item = new Fresh(name, fruit);
            }
            // how to add volume and price?
            if(comboBoxType.Text == "Coffee")
            {
                CoffeeDrink item = new CoffeeDrink(sort, caffeine);
            }
          
           // dataGridViev.
        }

    }
}
