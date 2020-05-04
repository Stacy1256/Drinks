using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Security;
using Drinks.Models;

namespace Drinks
{
    public partial class MainForm : Form
    {
        const string messageWarningCreatenew = "Your data is not saved! Do you want to close it and create new document? (Your changes won't be saved)";
        const string messageWarningSaveNothing = "Nothing to save. Add your data!";

        string fileContent = string.Empty;
        string filePath = string.Empty;
        IList<Liquid> liquidOrders = new List<Liquid>();
        BindingList<Liquid> bindingList;
        BindingSource source;// = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            dataGridView.Visible = false;
            //dataGridView.Columns.Add("number", "№");
            //dataGridView.Columns.Add("name", "Name");
            //dataGridView.Columns.Add("size", "Size");
            //dataGridView.Columns.Add("price", "Price");
            //dataGridView.Columns.Add("sort", "Sort of coffee");
            //dataGridView.Columns.Add("coffeine", "Coffeine");
            //dataGridView.Columns.Add("fruit", "Fruit");


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Title = "Select a document";
                openFile.Filter = "txt files (*.txt)|*.txt";
                openFile.Multiselect = false;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filePath = openFile.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFile.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            while (reader.Peek() >= 0)
                            {
                                fileContent = reader.ReadLine();
                                liquidOrders.Add(ParseToLiquid(fileContent));
                               // DataSet ds = new DataSet();
                                //ds.Tables.Add("Store");
                                //string[] str = new string[5];
                                //str = fileContent.Split('-');
                                //if (str[0] == "Drink")
                                //{
                                //    Volume volume = new Volume();
                                //    if (str[2] == "S")
                                //    {
                                //        volume = Volume.S;
                                //    }
                                //    else if (str[2] == "M")
                                //    {
                                //        volume = Volume.M;
                                //    }
                                //    if (str[2] == "L")
                                //    {
                                //        volume = Volume.L;
                                //    }
                                //    Drink item = new Drink(str[1], volume);
                                //    item.SetPrice(volume);
                                //    dataGridView.Rows.Add(item.Name,item.Size,0,0,0,item.Price);
                           

                                //}

                                //else if (str[0] == "Fresh")
                                //{
                                //    Volume volume = new Volume();
                                //    if (str[2] == "S")
                                //    {
                                //        volume = Volume.S;
                                //    }
                                //    else if (str[2] == "M")
                                //    {
                                //        volume = Volume.M;
                                //    }
                                //    if (str[2] == "L")
                                //    {
                                //        volume = Volume.L;
                                //    }
                                //    Fresh item = new Fresh(str[1], str[3], volume);
                                //    item.SetPrice(volume);
                                //    dataGridView.Rows.Add(item.Name, item.Size, item.Fruit, 0, 0, item.Price);
                                //}


                                //else if (str[0] == "Coffee")
                                //{
                                //    CoffeeDrink item = new CoffeeDrink(str[1], Convert.ToBoolean(str[2]));
                                //    dataGridView.Rows.Add(0,0,0,item.SortOfCoffee,item.Coffeine,0);
                                //}
                                
                            }
                        }
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                            $"Details:\n\n{ex.StackTrace}");
                    }
                }
            }
            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            foreach (Liquid drink in liquidOrders)
            {

                MessageBox.Show($"{drink.GetType().ToString()}::{(drink as Drink)?.Name}", "TEEEEEEEEEEST", MessageBoxButtons.OK);
            }
            // Add data from file to dataGridView
            //source.DataSource = liquidOrders;
            //dataGridView.DataSource = source;
            //dataGridView.Visible = true;

            var anonLiquid = liquidOrders
                .Select((x) => new
                {
                    Name = (x as Drink)?.Name ?? string.Empty,
                    Size = (x as Drink)?.Size.ToString() ?? string.Empty,
                    Price = (x as Drink)?.Price.ToString() ?? string.Empty,
                    Fruit = (x as Fresh)?.Fruit.ToString() ?? string.Empty,
                    SortOfCoffee = (x as CoffeeDrink)?.SortOfCoffee ?? string.Empty,
                    Coffeine = (x as CoffeeDrink)?.Coffeine.ToString() ?? string.Empty,
                }).ToList();

            source = new BindingSource();
            source.DataSource = anonLiquid;

            dataGridView.DataSource = source;
            dataGridView.Visible = true;


        }

        public static Volume ParseToVolume(string size)
        {
            Volume volume;
            try
            {
                volume = (Volume)Enum.Parse(typeof(Volume), size);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return 0;
                // Отуууут фііііігняяяяя
            }
            return volume;
        }

        public static Liquid ParseToLiquid(string fileContent)
        {
            var fileString = fileContent.Split('-');
            Liquid item;
            switch (fileString[0])
            {
                case ("Drink"):
                    item = new Drink(fileString[1], ParseToVolume(fileString[2]));
                    return item;
                case ("Fresh"):
                    item = new Fresh(fileString[1], fileString[3], ParseToVolume(fileString[2]));
                    return item;
                case ("CoffeeDrink"):
                    item = new CoffeeDrink(fileString[1], bool.Parse(fileString[2]));
                    return item;
                default:
                    return new Liquid();
            }
        }
        

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (liquidOrders.Any())
            {

                var result = MessageBox.Show(messageWarningCreatenew, "Warning", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    // Something TO DO
                }

            }
            else
            {
                // Something TO DO
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!liquidOrders.Any())
            {
                MessageBox.Show(messageWarningSaveNothing, "Warning", MessageBoxButtons.OK);
            }
            else
            {
                // Write data from LIST to file which was opened
                // Use SaveFileDialog
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Write data from dataGridview to file with new name
            // Use SaveFileDialog
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Maybe add warning (MassageBox) ???
            this.Close();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm newItem = new ItemForm();
            newItem.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = false;
            // Something TO DO
            View_help help = new View_help();
            help.ShowDialog();
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Visible = false;
            // Something TO DO
            About_author about = new About_author();
            about.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // string name = ItemForm
            //string size = comboBoxSize.Text;
            //string fruit = textBoxFruit.Text;
            //string sort = textBoxSortOfCoffee.Text;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SampleForm sample = new SampleForm();
            sample.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double min = Convert.ToDouble(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double max = Convert.ToDouble(textBox1.Text);
        }
    }
}