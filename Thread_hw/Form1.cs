using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Thread_hw
{
    public partial class Form1 : Form
    {
        Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartPrime_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(GeneratePrimeNumbers);
            thread = new Thread(threadStart);
            thread.Start();
        }
        void GeneratePrimeNumbers()
        {
            string str = "";
            int pos = 0;

            for (int x = (int)numericPrimeMin.Value; x < (int)numericPrimeMax.Value; x++)
            {
                if (PrimeNumber(x))
                {
                    //str += x.ToString() + "\r\n";
                    PrimeNumberTextBox.AppendText(x.ToString() + "\r\n");
                }

                Thread.Sleep(500);
            }
        }
        static bool PrimeNumber(int x)
        {
            for (int d = 2; d <= Math.Sqrt(x); d++)
            {
                if (x % d == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void StopPrime_Click(object sender, EventArgs e)
        {
            thread.Abort();
        }
    }
}
