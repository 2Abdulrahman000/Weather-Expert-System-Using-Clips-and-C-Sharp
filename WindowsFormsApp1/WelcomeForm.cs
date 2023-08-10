using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WelcomeForm : Form
    {
        string letter;
        int len;
        int counter = 0;
        public WelcomeForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            letter = lab_title.Text;
            len = letter.Length;
            lab_title.Text = "";
            timer_letter.Start();
            timer_loading.Start();
        }

        private void timer_loading_Tick(object sender, EventArgs e)
        {
            panel_loading.Width+=16;
            if (panel_loading.Width > this.Width)
            {
                Options frm = new Options();
                frm.Show();
                this.Hide();
                timer_loading.Stop();
            }
        }

        private void timer_letter_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                timer_letter.Stop();
            }
            else
            {
                lab_title.Text = letter.Substring(0, counter);
            }
        }
    }
}
