using System.Threading;
using System;
using System.Diagnostics;

namespace CourseDeLevriersGUI
{
    public partial class Form1 : Form
    {
        public static bool Dehors;
        public static ManualResetEvent[] events = new ManualResetEvent[5];

        public Form1()
        {
            InitializeComponent();
            this.Text = "Course de levriers";
            listBox.Items.Add("Commencer la course");
        }

        private void buttonDepart_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.Add("Les levriers courent...");
            Random random = new Random();
            
            List<int> ordreArrives = new List<int>();
            ManualResetEvent depart = new ManualResetEvent(false);
            ManualResetEvent[] events = new ManualResetEvent[5];
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            trackBar4.Value = 0;
            trackBar5.Value = 0;

            for (int i = 0; i < 5; i++)
            {
                Levrier levrier = new Levrier();
                levrier.InstanceNumber = i;
                levrier.Random = random;
                levrier.depart = depart;
                levrier.arrivee = new ManualResetEvent(false);
                events[i] = levrier.arrivee;

                switch (i)
                {
                    case 0:
                        levrier.trackBar = trackBar1;
                        break;
                    case 1:
                        levrier.trackBar = trackBar2;
                        break;
                    case 2:
                        levrier.trackBar = trackBar3;
                        break;
                    case 3:
                        levrier.trackBar = trackBar4;
                        break;
                    case 4:
                        levrier.trackBar = trackBar5;
                        break;
                    default:
                        break;
                }
                Thread thread = new Thread(levrier.Run);
                thread.Start();
            }

            depart.Set();

            Thread threadPosition = new Thread(() =>
            {
                int position;
                int arrives = 0;
                while (arrives < 5)
                {
                    position = WaitHandle.WaitAny(events);
                    if (Dehors)
                    {
                        break;
                    }
                    arrives++;

                    if (arrives == 1)
                    {
                        listBox.Invoke(new Action(() =>
                        {
                            listBox.Items.Clear();
                        }));
                    }

                    listBox.Invoke(new Action(() =>
                    {
                        listBox.Items.Add("Levrier " + position + " est arrive. Sa place est " + arrives);
                    }));
                    ordreArrives.Add(position);
                    events[position].Reset();
                }
            });

            threadPosition.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Dehors = true;
        }
    }
}