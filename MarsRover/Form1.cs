using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public LocationVector MakeLocationVector(string Location)
        {
            string[] Locations = Location.Split(" ");
            if (Locations.Count() == 3)
            {
                try
                {
                    LocationVector LocationVector = new LocationVector()
                    {
                        LocationX = int.Parse(Locations[0]),
                        LocationY = int.Parse(Locations[1]),
                        Direction = Locations[2]
                    };
                    return LocationVector;
                }
                catch
                {
                    return null;
                }
            }
            else
                return null;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Calcute calcute = new Calcute();
            string[] ValueList = richTextBox1.Text.Split("\n");
            //Start 1 because first rove is platformsize
            for (int i = 1; i < ValueList.Count(); i += 2)
            {
                //Find the rover start vector
                LocationVector locationVector = MakeLocationVector(ValueList[i]);
                if (i+1<ValueList.Length && locationVector!=null)
                   listBox1.Items.Add(calcute.LocationCalcute(locationVector, ValueList[i + 1]));
            }
        }
    }
}
