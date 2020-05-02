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
        string fileContent = string.Empty;
        string filePath = string.Empty;
        IList<Liquid> liquidOrders = new List<Liquid>();
        BindingSource source = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            dataGridView.Visible = false;
            dataGridView.Columns.Add("number", "№");
            dataGridView.Columns.Add("name", "Name");
            dataGridView.Columns.Add("size", "Size");
            dataGridView.Columns.Add("price", "Price");
            dataGridView.Columns.Add("sort", "Sort of coffee");
            dataGridView.Columns.Add("coffeine", "Coffeine");
            dataGridView.Columns.Add("fruit", "Fruit");


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
                            fileContent = reader.ReadLine();
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

            // Add data from file to dataGridView
            //liquidOrders = fileContent.Parse;
            //source.DataSource = liquidOrders;
            //dataGridView.DataSource = source;
            //dataGridView.Visible = true;


        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Write data from dataGridview to file which was opened
            // Use SaveFileDialog


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
            string name = textBoxName.Text;
            string size = comboBoxSize.Text;
            string fruit = textBoxFruit.Text;
            string sort = textBoxSortOfCoffee.Text;
            dataGridViev.
        }
    }
}