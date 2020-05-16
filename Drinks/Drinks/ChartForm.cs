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
    public partial class ChartForm : Form
    {
        SortableBindingList<OverAllLiqudData> liqudDatas = new SortableBindingList<OverAllLiqudData>();

        public ChartForm(string propertyName, SortableBindingList<OverAllLiqudData> liqudDatas)
        {
           this.liqudDatas = liqudDatas;



            InitializeComponent();


            Dictionary<string, int> propertysAmount = new Dictionary<string, int>();

            foreach (OverAllLiqudData liq in this.liqudDatas)
            {
                if (GetPropValue(liq, propertyName) == null || GetPropValue(liq, propertyName) == "") continue; 
                if (propertysAmount.ContainsKey(GetPropValue(liq, propertyName)))
                {
                    propertysAmount[GetPropValue(liq, propertyName)]++;

                }
                else
                {
                    propertysAmount.Add(GetPropValue(liq, propertyName), 1);
                }
            }

            chart1.Titles.Add(propertyName);


            foreach (KeyValuePair<string, int> chartslice in propertysAmount)
            {

                chart1.Series["Series1"].Points.AddXY(chartslice.Key, chartslice.Value);
            }

           

        }
        public string GetPropValue(OverAllLiqudData src, string propName)
        {

            return (src.GetType().GetProperty(propName).GetValue(src, null)).ToString();
        }
    }
}
