namespace CW_Windows__Forms_3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackBarRed = new TrackBar();
            label1 = new Label();
            trackBarGreen = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            trackBarBlue = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(12, 12);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.Orientation = Orientation.Vertical;
            trackBarRed.Size = new Size(56, 130);
            trackBarRed.SmallChange = 5;
            trackBarRed.TabIndex = 0;
            trackBarRed.TickFrequency = 5;
            trackBarRed.Scroll += TrackBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 154);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 1;
            label1.Text = "R";
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(74, 12);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.Orientation = Orientation.Vertical;
            trackBarGreen.Size = new Size(56, 130);
            trackBarGreen.SmallChange = 5;
            trackBarGreen.TabIndex = 2;
            trackBarGreen.TickFrequency = 5;
            trackBarGreen.Scroll += TrackBar_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 154);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 3;
            label2.Text = "G";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 154);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 4;
            label3.Text = "B";
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(136, 12);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.Orientation = Orientation.Vertical;
            trackBarBlue.Size = new Size(56, 130);
            trackBarBlue.SmallChange = 5;
            trackBarBlue.TabIndex = 5;
            trackBarBlue.TickFrequency = 5;
            trackBarBlue.Scroll += TrackBar_Scroll;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBarBlue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trackBarGreen);
            Controls.Add(label1);
            Controls.Add(trackBarRed);
            Name = "Form2";
            Text = "ColorMania";
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBarRed;
        private Label label1;
        private TrackBar trackBarGreen;
        private Label label2;
        private Label label3;
        private TrackBar trackBarBlue;
    }
}