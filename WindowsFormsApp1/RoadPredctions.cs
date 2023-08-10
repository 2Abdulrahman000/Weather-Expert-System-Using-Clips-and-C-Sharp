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
    public partial class RoadPredctions : Form
    {
        Mommosoft.ExpertSystem.Environment CLIPS;
        public RoadPredctions()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CLIPS = new Mommosoft.ExpertSystem.Environment();
            CLIPS.Load("pp.clp");
        }



        private void lb_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            Options frm = new Options();
            frm.Show();
            this.Hide();
        }

        private void cb_road_SelectedIndexChanged(object sender, EventArgs e)
        {
            String weather = Convert.ToString(CLIPS.Eval("(road-predctions " + cb_road.SelectedIndex + ")"));
            String withoutQ = weather.Substring(1, weather.Length - 2);
            lb_prections.Text = weather.Substring(1,weather.Length-2);

            if (withoutQ == "Safe")
            {
                MessageBox.Show("The Road " + cb_road.Text + " is Safe ,you can pass it", "Our Advice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (withoutQ == "Heavy rain")
            {
                MessageBox.Show("The Road " + cb_road.Text + " is Heavy rain ,you must Change your road if your car is full of Goods otherwise you should drive slowly", "Our Advice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (withoutQ == "Dusty")
            {
                MessageBox.Show("The Road " + cb_road.Text + " is Dusty , if you have medical probelm in breathing you should ignore this road", "Our Advice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (withoutQ == "Cloudy")
            {
                MessageBox.Show("The Road " + cb_road.Text + " is Cloudy , donnot walk in the early morning hours in this road", "Our Advice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
