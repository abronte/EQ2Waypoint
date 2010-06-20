using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace EQWaypoint
{
    class Pather
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int extraInfo);

        [DllImport("user32.dll")]
        static extern short MapVirtualKey(int wCode, int wMapType);

        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(IntPtr hWnd);

        private EQmemory eqmem;
        private Form2 output;

        public Pather(EQmemory mem, Form2 o)
        {
            eqmem = mem;
            output = o;
        }

        public void startPathing(System.Windows.Forms.ListBox wp)
        {
            output.Show();
            output.addMsg("Started");

            for (int i = 0; i < wp.Items.Count; i++)
            {
                double h1 = eqmem.getHeading();
                output.addMsg("Current heading: " + h1);

                string[] waypoint = wp.Items[i].ToString().Split(',');

                output.addMsg("Next waypoint: x:" + waypoint[0] + " y: " + waypoint[1]);

                double wph = nextHeading(float.Parse(waypoint[0]), float.Parse(waypoint[1]));

                output.addMsg("Next waypoint is at heading: " + wph);

                int turn = (int)(h1 - (wph * -1));

                output.addMsg("TURN: " + turn);

                if (turn < 0)
                {
                    output.addMsg("Turning right");
                    turnRight(turn * -1);
                }
                else
                {
                    output.addMsg("Turning left");
                    turnLeft(turn);
                }

                output.addMsg("Moving to waypoint");
                moveForward(float.Parse(waypoint[0]), float.Parse(waypoint[1]));

                output.addMsg("At waypoint.");
            }

            output.addMsg("Finished.");
        }

        /* Big thanks to jeunetoujour @ Angelbot for this code 
         * http://angelbot.forumbuild.com
         */
        public double nextHeading(float x, float y)
        {
            double faceangle = Math.Atan2((y - eqmem.getYPos()), (x - eqmem.getXPos()));
            faceangle = faceangle * (180 / Math.PI);

            faceangle -= 90;
            if (faceangle > 180) faceangle -= 360;
            faceangle -= 180;
            if (faceangle < -180 && faceangle > -360) faceangle += 360;
            if (faceangle > 180) faceangle -= 360;
            if (faceangle < -360) faceangle += 360;

            return faceangle -180;
        }

        public void turnRight(int degree)
        {
            //aux.WinActivate("[CLASS:EQ2ApplicationClass]");
            SetForegroundWindow((IntPtr)eqmem.eqproc.MainWindowHandle);

            int next_heading = (int)eqmem.getHeading() + degree;

            keybd_event((int)Keys.D, (byte)MapVirtualKey((int)Keys.D, 0), 0, 0);

            while (((int)eqmem.getHeading() < next_heading - 1) || ((int)eqmem.getHeading() < next_heading + 1))
            //while((int)eqmem.getHeading() != next_heading)
            {
                System.Threading.Thread.Sleep(5);
            }
            keybd_event((int)Keys.D, (byte)MapVirtualKey((int)Keys.D, 0), 2, 0);
        }

        public void turnLeft(int degree)
        {
            SetForegroundWindow((IntPtr)eqmem.eqproc.MainWindowHandle);

            int next_heading = (int)eqmem.getHeading() - degree;

            keybd_event((int)Keys.A, (byte)MapVirtualKey((int)Keys.A, 0), 0, 0);

            while(((int)eqmem.getHeading() > next_heading - 2) || ((int)eqmem.getHeading() > next_heading + 2))
            //while((int)eqmem.getHeading() != next_heading)
            {
                System.Threading.Thread.Sleep(5);
            }
            keybd_event((int)Keys.A, (byte)MapVirtualKey((int)Keys.A, 0), 2, 0);
        }

        public void moveForward(float x, float y)
        {
            SetForegroundWindow((IntPtr)eqmem.eqproc.MainWindowHandle);

            keybd_event((int)Keys.W, (byte)MapVirtualKey((int)Keys.W, 0), 0, 0);

            //while((int)eqmem.getXPos() != (int)x && (int)eqmem.getYPos() != (int)y)
            while (!checkBetween(eqmem.getXPos(), x - 0.25, x + 0.25) && !checkBetween(eqmem.getYPos(), y - 0.25, y + 0.25))
            {
                System.Threading.Thread.Sleep(5);
            }

            keybd_event((int)Keys.W, (byte)MapVirtualKey((int)Keys.W, 0), 2, 0);
        }

        private bool checkBetween(double value, double left, double right)
        {
            return value > left && value < right; 
        }
    }
}
