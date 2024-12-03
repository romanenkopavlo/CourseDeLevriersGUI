using System.Threading;
using System;

namespace CourseDeLevriersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDepart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ManualResetEvent[] events = new ManualResetEvent[10];
            ManualResetEvent depart = new ManualResetEvent(false);
            for (int i = 0; i < 5; i++)
            {
                Levrier levrier = new Levrier();
                levrier.InstanceNumber = i;
                switch (i)
                {
                    case 0:
                        levrier.trackBar = trackBar1;
                        break;
                    case 1:
                        levrier.trackBar = trackBar2;
                        break;
                }
                levrier.Random = random;
                levrier.arrivee = new ManualResetEvent(false);
                levrier.depart = depart;
                events[i] = levrier.arrivee;

                Thread thread = new Thread(levrier.Run);
                thread.Start();
            }
        }
    }
}
