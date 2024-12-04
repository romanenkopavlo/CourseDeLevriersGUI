using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            if (!CourseDeLevriers.Dehors) {
                depart.WaitOne();
                for (int i = 0; i < 100; i++)
                {
                    if (CourseDeLevriers.Dehors)
                    {
                        break;
                    }

                    Thread.Sleep(Random.Next(50));

                    try
                    {
                        if (!CourseDeLevriers.Dehors)
                        {
                            trackBar.Invoke(new Action(() =>
                            {
                                trackBar.Value = i;
                            }));
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (InvalidAsynchronousStateException)
                    {
                        break;
                    }
                }

                if (!CourseDeLevriers.Dehors)
                {
                    arrivee.Set();
                }
            }
        }
    }
}
