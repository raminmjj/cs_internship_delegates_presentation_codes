using System;
using System.Windows.Forms;

namespace EventsAndDelegatesSimplified
{
    public partial class Form1 : Form
    {
        Counter oCounter = null;

        public Form1()
        {
            InitializeComponent();

            oCounter = new Counter();
            oCounter.NumberReached += new NumberReachedEventHandler(oCounter_NumberReached);
            oCounter.NumberReached += new NumberReachedEventHandler(oCounter_NumberReached2);
        }

        private void cmdRun_Click(object sender, EventArgs e)
        {
            oCounter.CountTo(Convert.ToInt32(txtCountTo.Text), Convert.ToInt32(txtReachable.Text));
        }

        private void btnRemoveDelegate_Click(object sender, EventArgs e)
        {
            oCounter.NumberReached -= new NumberReachedEventHandler(oCounter_NumberReached2);
            oCounter.CountTo(Convert.ToInt32(txtCountTo.Text), Convert.ToInt32(txtReachable.Text));
        }

        private void oCounter_NumberReached(object sender, NumberReachedEventArgs e)
        {
            MessageBox.Show("Reached: " + e.ReachedNumber.ToString());
        }

        private void oCounter_NumberReached2(object sender, NumberReachedEventArgs e)
        {
            MessageBox.Show("Reached2: " + e.ReachedNumber.ToString());
        }

    }
}
