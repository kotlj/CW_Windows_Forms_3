using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_Windows__Forms_3
{
    public partial class Form4 : Form
    {
        int diff = 1;
        bool down = true;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Tick += Timer1_tick;
            timer1.Start();
        }

        private void Timer1_tick(object sender, EventArgs e)
        {
            if (button1.Location.Y < (this.Height - button1.Height) && down)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + diff);
            }
            else if (button1.Location.Y > 0 && !down)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y - diff);
            }
            else if (button1.Location.Y == (this.Height - button1.Height))
            {
                down = false;
            }
            else if (button1.Location.Y == 0)
            {
                down = true;
            }
        }
    }
}
