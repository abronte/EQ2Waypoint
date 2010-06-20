using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EQWaypoint
{
    public partial class Form1 : Form
    {
        private EQmemory eqmem;
        private Pather pather;
        Form2 output;

        private float curx = 0;
        private float cury = 0;

        public Form1()
        {
            output = new Form2();
            eqmem = new EQmemory();
            pather = new Pather(eqmem, output); 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (eqmem.findEQ())
            {
                //this.statusLabel.Text = eqmem.getHeading().ToString();
                this.xLabel.Text = eqmem.getXPos().ToString();
                this.yLabel.Text = eqmem.getYPos().ToString();
                this.zLabel.Text = eqmem.getZPos().ToString();

                curx = eqmem.getXPos();
                cury = eqmem.getYPos();
            }
        }

        private void addWpButton_Click(object sender, EventArgs e)
        {
            this.wpListBox.Items.Add(eqmem.getWaypointString());
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Started";
            pather.startPathing(this.wpListBox);
            statusLabel.Text = "Stopped";
        }
    }
}
