using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BasicThreading
{
    public partial class BasicThread : Form
    {
        public BasicThread()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");
            label1.Text = "-Before starting thread-";
            ThreadStart Thread1 = new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(Thread1);
            Thread ThreadB = new Thread(Thread1);

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadA.Priority = ThreadPriority.Lowest;

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("End of Thread-");
            label1.Text = "-End of Thread-";
        }
    }
}
