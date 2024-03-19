using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Splacsh : Form
    {
        public Splacsh()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progress.Value = startpoint;
            if (progress.Value == 100)
            {
                progress.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void progress_Click(object sender, EventArgs e)
        {

        }

        private void Splacsh_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
