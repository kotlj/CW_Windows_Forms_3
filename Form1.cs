namespace CW_Windows__Forms_3
{
    public partial class Form1 : Form
    {
        Panel pn;
        public Form1()
        {
            InitializeComponent();
            pn = new Panel();
            this.Controls.Add(pn);
            pn.Width = 100; ;
            pn.Dock = DockStyle.Fill;
            Button btn = new Button();
            btn.Location = new Point(0, menuStrip1.Height);
            btn.Width = 100;
            btn.Height = 100;
            btn.Text = "Clear";
            btn.Click += (sender, e) =>
            {
                richTextBox1.Text = string.Empty;
            };
            ToolTip tt = new ToolTip();
            tt.ToolTipTitle = "ThisIsTip";
            tt.ShowAlways = true;
            tt.SetToolTip(btn, "clear all, except your sins");
            pn.Controls.Add(btn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pn.BackColor = colorDialog1.Color;
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string pathToFile = openFileDialog1.FileName;
            if (pathToFile != null)
            {
                string content = File.ReadAllText(pathToFile);
                richTextBox1.Text = content;
            }
        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void progressBarFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void flyButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}