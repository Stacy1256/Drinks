using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drinks.Models;

namespace Drinks
{
    public partial class SampleForm : Form
    {
        SortableBindingList<OverAllLiqudData> datas = new SortableBindingList<OverAllLiqudData>();
        public SampleForm(SortableBindingList<OverAllLiqudData> data ,String Size, string type)
        {

            //HAAAAAAARDcor *cod 
            switch(type)
            {
                case "Drink":
                   
                     var d = from X in data
                            where( X.Fruit == "" )&& (X.SortOfCoffee=="") && X.Size==Size
                            select X;
                    foreach(OverAllLiqudData dat in d )
                    {
                        datas.Add(dat);
                        MessageBox.Show("sssss");
                    }
                
                    break;
                case "Fresh":
                    var d1 = from X in data
                            where (X.Fruit != "") && (X.SortOfCoffee == "") && X.Size == Size
                            select X;
                    foreach (OverAllLiqudData dat in d1)
                    {
                        datas.Add(dat);
                    }
                    break;
                case "Coffie":
                    var d2 = from X in data
                             where (X.Fruit == "") && (X.Coffeine != "") 
                             select X;
                    foreach (OverAllLiqudData dat in d2)
                    {
                        datas.Add(dat);
                    }
                    break;

            }




            this.datas = data;
            
            InitializeComponent();
            RangeDataGridView.AllowUserToAddRows = false;
            
            RangeDataGridView.DataSource = data;
        }

        private void SampleForm_Load(object sender, EventArgs e)
        {

        }

        private void RangeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RangeDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
