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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            foreach(var lab in this.Controls.OfType<Label>())
            {
                lab.ForeColor = Color.FromArgb(255 - trackBarRed.Value, 255 - trackBarGreen.Value, 255 - trackBarBlue.Value);
            }
        }
    }
}
