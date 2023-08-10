using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mommosoft.ExpertSystem;

namespace WindowsFormsApp1
{
    public partial class CaptialPredctions : Form
    {
        Mommosoft.ExpertSystem.Environment CLIPS;
        public CaptialPredctions()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CLIPS = new Mommosoft.ExpertSystem.Environment();
            CLIPS.Load("Captial.clp");
        }

        private void CaptialPredctions_Load(object sender, EventArgs e)
        {

        }

        private void cb_captial_SelectedIndexChanged(object sender, EventArgs e)
        {
            String weather = Convert.ToString(CLIPS.Eval("(captial-predctions " + cb_captial.SelectedIndex + ")"));
            lb_prections.Text = weather.Substring(1, weather.Length - 2);
            //MessageBox.Show(cb_captial.SelectedIndex + "");
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            Options frm = new Options();
            frm.Show();
            this.Hide();
        }


        private void lb_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Exit ?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) timer_exit.Start();
            else return;
        }

        private void timer_exit_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.044;
            }
            else Application.Exit();
        }

    }
}
