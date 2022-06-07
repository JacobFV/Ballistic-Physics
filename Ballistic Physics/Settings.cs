using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballistic_Physics
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        double Xspeed = 0;
        double X = 0;
        double Yspeed = 0;
        double Y = 0;
        double gravity = 0;
        int intervals = 0;
        double time = 0;
        double units = 0;
        double accelTime = 0;
        double converter = Math.PI/180;
        bool working = false;

        void write(string text)
        {
            bigTextBox.Text += "\n" + text;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (working == false)
            {
                //setting up variables
                time = 0;
                units = (double)resNum.Value;
                gravity = (double)gravityNum.Value;
                intervals = (int)deciamlsNum.Value;
                accelTime = (double)accelTimeNum.Value;

                //resetting cordinates
                X = 0;
                Y = (double)heightNum.Value;
                working = true;

                //loop-de-loop
                while ((double)updatesNum.Value>=time-units)
                {
                    updateHeight();
                    time += units;
                    time = Math.Round(time, intervals);
                }
                working = false;
            }
        }
        void updateHeight()
        {
            //accellerating
            if (accelTime >= time)
            {
                Xspeed = (double)accelNum.Value * Math.Cos((double)angleNum.Value * converter) * units;
                Yspeed = (double)accelNum.Value * Math.Sin((double)angleNum.Value * converter) * units;
            }

            //logic here
            Yspeed += gravity * Math.Sin(Math.Atan2(Y, X))*units;
            Xspeed += gravity * Math.Cos(Math.Atan2(Y, X))*units;

            X += Xspeed*units;
            Y += Yspeed*units;

            //output results
            write(time + "\t" + Math.Round(X, intervals) + "\t" + Math.Round(Y, intervals));
        }
    }
}
