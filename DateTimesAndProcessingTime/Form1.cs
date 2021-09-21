using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimesAndProcessingTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstDateTime.Items.Clear();

            //Start Date Time Initialization and formatting
            lstDateTime.Items.Add("Start Date Time Formated several different ways");
            lstDateTime.Items.Add("----------------------------------------------------");
            DateTime myDateTime1 = DateTime.Now;
            lstDateTime.Items.Add("ToString:\t\t" + myDateTime1.ToString());
            lstDateTime.Items.Add("ToLongTimeString:\t" + myDateTime1.ToLongTimeString());
            lstDateTime.Items.Add("Millisecond:\t" + myDateTime1.Millisecond);
            lstDateTime.Items.Add("ToShortDateString:\t" + myDateTime1.ToShortDateString());
            lstDateTime.Items.Add("ToShortTimeString:\t" + myDateTime1.ToShortTimeString());

            //End Date Time Initialization and formatting
            lstDateTime.Items.Add("");
            lstDateTime.Items.Add("End Date Time Formated several different ways");
            lstDateTime.Items.Add("----------------------------------------------------");
            DateTime myDateTime2 = DateTime.Now;
            lstDateTime.Items.Add("ToString:\t\t" + myDateTime2.ToString());
            lstDateTime.Items.Add("ToLongTimeString:\t" + myDateTime2.ToLongTimeString());
            lstDateTime.Items.Add("Millisecond:\t" + myDateTime2.Millisecond);

            //Comparison between the Start Time or the End Time
            lstDateTime.Items.Add("");
            lstDateTime.Items.Add("End Time - Start Time [hh:mm:ss:ms]");
            lstDateTime.Items.Add("----------------------------------------------------");
            lstDateTime.Items.Add("CompareTo:\t" + (myDateTime2 - myDateTime1).ToString());

        }
    }
}
