using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDeLevriersGUI
{
    public class Levrier
    {
        private int instanceNumber;

        public int InstanceNumber
        {
            set
            {
                this.instanceNumber = value;
            }
        }
        public Random Random { get; set; }
        public ManualResetEvent depart;
        public ManualResetEvent arrivee;
        public TrackBar trackBar;

        public void Run()
        {
            depart.WaitOne();
            for (int i = 0; i < 250; i++)
            {
                Thread.Sleep(this.Random.Next(10));
                trackBar.Invoke(new Action(() =>
                {
                    trackBar.Value = i;
                }));
            }
            arrivee.Set();
        }
    }
}
