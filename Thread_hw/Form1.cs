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
        Thread _threadPrimeNumber;
        Thread _threadFibonacciNumber;
        public Form1()
        {
            InitializeComponent();

            StopPrime.Enabled = false;
            SuspendPrime.Enabled = false;
            ResumePrime.Enabled = false;
            RestartPrime.Enabled = false;
        }

        private void StartPrime_Click(object sender, EventArgs e)
        {
            PrimeNumberTextBox.Clear();

            ThreadStart threadStart = new ThreadStart(GeneratePrimeNumbers);
            _threadPrimeNumber = new Thread(threadStart);
            _threadPrimeNumber.Start();

            StopPrime.Enabled = true;
            SuspendPrime.Enabled = true;
            RestartPrime.Enabled = true;
        }
        void GeneratePrimeNumbers()
        {
            for (int x = (int)numericPrimeMin.Value; x < (int)numericPrimeMax.Value; x++)
            {
                if (PrimeNumber(x))
                {
                    PrimeNumberTextBox.AppendText(x.ToString() + "\r\n");
                }

                Thread.Sleep(500);
            }

            _threadPrimeNumber.Abort();
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
            _threadPrimeNumber.Abort();

            SuspendPrime.Enabled = false;
            ResumePrime.Enabled = false;
        }
        private void SuspendPrime_Click(object sender, EventArgs e)
        {
            _threadPrimeNumber.Suspend();

            SuspendPrime.Enabled = false;
            StopPrime.Enabled = false;
            RestartPrime.Enabled = false;
            ResumePrime.Enabled = true;
        }
        private void ResumePrime_Click(object sender, EventArgs e)
        {
            _threadPrimeNumber.Resume();

            StopPrime.Enabled = true;
            RestartPrime.Enabled = true;
            ResumePrime.Enabled = false;
        }
        private void RestartPrime_Click(object sender, EventArgs e)
        {
            _threadPrimeNumber.Abort();

            PrimeNumberTextBox.Clear();

            StartPrime_Click(sender, e);
        }
        private void StartFibonacci_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart1 = new ThreadStart(GenerateFibonacciNumbers);
            _threadFibonacciNumber = new Thread(threadStart1);
            _threadFibonacciNumber.Start();
        }
        private void StopFibonacci_Click(object sender, EventArgs e)
        {
            _threadFibonacciNumber.Abort();
        }
        void GenerateFibonacciNumbers()
        {
            ulong num1 = 1;
            ulong num2 = 1;
            ulong res = 0;

            FibonacciTextBox.AppendText(num1.ToString() + "\r\n");
            FibonacciTextBox.AppendText(num2.ToString() + "\r\n");

            while (true)
            {
                res = num1 + num2;

                FibonacciTextBox.AppendText(res.ToString() + "\r\n");

                num1 = num2;
                num2 = res;

                Thread.Sleep(500);
            }
        }
    }
}
