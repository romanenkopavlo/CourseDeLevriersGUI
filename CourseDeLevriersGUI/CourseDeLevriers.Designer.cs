namespace CourseDeLevriersGUI
{
    partial class CourseDeLevriers
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
            buttonDepart = new Button();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            trackBar4 = new TrackBar();
            trackBar5 = new TrackBar();
            listBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            SuspendLayout();
            // 
            // buttonDepart
            // 
            buttonDepart.Location = new Point(646, 12);
            buttonDepart.Name = "buttonDepart";
            buttonDepart.Size = new Size(128, 67);
            buttonDepart.TabIndex = 0;
            buttonDepart.Text = "Depart";
            buttonDepart.UseVisualStyleBackColor = true;
            buttonDepart.Click += buttonDepart_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 106);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(776, 45);
            trackBar1.TabIndex = 1;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(12, 175);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(776, 45);
            trackBar2.TabIndex = 2;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(12, 246);
            trackBar3.Maximum = 100;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(776, 45);
            trackBar3.TabIndex = 3;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(12, 307);
            trackBar4.Maximum = 100;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(776, 45);
            trackBar4.TabIndex = 4;
            // 
            // trackBar5
            // 
            trackBar5.Location = new Point(12, 368);
            trackBar5.Maximum = 100;
            trackBar5.Name = "trackBar5";
            trackBar5.Size = new Size(776, 45);
            trackBar5.TabIndex = 5;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(901, 137);
            listBox.Name = "listBox";
            listBox.Size = new Size(237, 244);
            listBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 450);
            Controls.Add(listBox);
            Controls.Add(trackBar5);
            Controls.Add(trackBar4);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(buttonDepart);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDepart;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private TrackBar trackBar5;
        private ListBox listBox;
    }
}
