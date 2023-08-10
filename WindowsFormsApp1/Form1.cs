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
    public partial class Form1 : Form
    {
        private Mommosoft.ExpertSystem.Environment CLIPS;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CLIPS = new Mommosoft.ExpertSystem.Environment();
            CLIPS.Load("pp.clp");
            //CLIPS.Reset();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("\""+"GER"+"\"");
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            String tmp = Convert.ToString(CLIPS.Eval("(temp-predctions " + tb_temprature.Text +")"));
            String month = Convert.ToString(CLIPS.Eval("(month-predctions " + cb_month.SelectedIndex +")"));
            String sun = Convert.ToString(CLIPS.Eval("(sun-predctions " + cb_sun.SelectedIndex + ")"));
            String wind = Convert.ToString(CLIPS.Eval("(wind-predctions " + cb_wind.SelectedIndex + ")"));

            lb_prections.Text = "it may be in " + month + "\nthat the weather is "+tmp+"\n and "+sun+" and "+wind;

            int index=cb_month.SelectedIndex;
            index++;
            if (DateTime.Now.Month.ToString() == index.ToString())
            {
                lb_predctions2.Text = "the next days \nit may be that the temptature \nincreases in mornning\n and nearly static in night";
            }
            else 
            {
                lb_predctions2.Text = "There no week predctions \nabout this date \nin the current time";
            }
           // MessageBox.Show(tmp + " || " + month + " || " + sun + " || " + wind + " || " + DateTime.Now.Month.ToString() + " || " + index);

        }

        private void timer_exit_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.044;
            }
            else
            {
                Application.Exit();
            }
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            DialogResult resault = MessageBox.Show("Are you sure to exit?", "EXit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resault == DialogResult.Yes) timer_exit.Start();
            else return;
        }

        private void lb_exit_MouseHover(object sender, EventArgs e)
        {
            lb_exit.BackColor = Color.Firebrick;
            lb_exit.ForeColor =Color.White;
        }

        private void lb_exit_MouseLeave(object sender, EventArgs e)
        {
            lb_exit.BackColor = Color.Black;
            lb_exit.ForeColor = Color.Firebrick;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Options frm = new Options();
            frm.Show();
            this.Hide();
        }

    }
}
