namespace CW_Windows__Forms_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            readToolStripMenuItem = new ToolStripMenuItem();
            newFormToolStripMenuItem = new ToolStripMenuItem();
            progressBarFormToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            changeThemeToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            flyButtonToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem, readToolStripMenuItem, newFormToolStripMenuItem, progressBarFormToolStripMenuItem, flyButtonToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(224, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // readToolStripMenuItem
            // 
            readToolStripMenuItem.Name = "readToolStripMenuItem";
            readToolStripMenuItem.Size = new Size(224, 26);
            readToolStripMenuItem.Text = "Read";
            readToolStripMenuItem.Click += readToolStripMenuItem_Click;
            // 
            // newFormToolStripMenuItem
            // 
            newFormToolStripMenuItem.Name = "newFormToolStripMenuItem";
            newFormToolStripMenuItem.Size = new Size(224, 26);
            newFormToolStripMenuItem.Text = "New form";
            newFormToolStripMenuItem.Click += newFormToolStripMenuItem_Click;
            // 
            // progressBarFormToolStripMenuItem
            // 
            progressBarFormToolStripMenuItem.Name = "progressBarFormToolStripMenuItem";
            progressBarFormToolStripMenuItem.Size = new Size(224, 26);
            progressBarFormToolStripMenuItem.Text = "ProgressBarForm";
            progressBarFormToolStripMenuItem.Click += progressBarFormToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeThemeToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // changeThemeToolStripMenuItem
            // 
            changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
            changeThemeToolStripMenuItem.Size = new Size(188, 26);
            changeThemeToolStripMenuItem.Text = "Change theme";
            changeThemeToolStripMenuItem.Click += changeThemeToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(356, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 422);
            panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(444, 422);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // flyButtonToolStripMenuItem
            // 
            flyButtonToolStripMenuItem.Name = "flyButtonToolStripMenuItem";
            flyButtonToolStripMenuItem.Size = new Size(224, 26);
            flyButtonToolStripMenuItem.Text = "FlyButton";
            flyButtonToolStripMenuItem.Click += flyButtonToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem changeThemeToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem readToolStripMenuItem;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem newFormToolStripMenuItem;
        private ToolStripMenuItem progressBarFormToolStripMenuItem;
        private ToolStripMenuItem flyButtonToolStripMenuItem;
    }
}