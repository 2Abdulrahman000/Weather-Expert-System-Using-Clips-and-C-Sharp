namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cb_wind = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_sun = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_month = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tb_temprature = new System.Windows.Forms.TextBox();
            this.lb_exit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_prections = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.timer_exit = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_predctions2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_wind
            // 
            this.cb_wind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.cb_wind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_wind.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_wind.ForeColor = System.Drawing.SystemColors.Info;
            this.cb_wind.FormattingEnabled = true;
            this.cb_wind.ItemHeight = 24;
            this.cb_wind.Items.AddRange(new object[] {
            "high ",
            "medium",
            "low ",
            "not Found"});
            this.cb_wind.Location = new System.Drawing.Point(48, 462);
            this.cb_wind.Name = "cb_wind";
            this.cb_wind.Size = new System.Drawing.Size(273, 32);
            this.cb_wind.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(43, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Wind";
            // 
            // cb_sun
            // 
            this.cb_sun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.cb_sun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_sun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sun.ForeColor = System.Drawing.SystemColors.Info;
            this.cb_sun.FormattingEnabled = true;
            this.cb_sun.ItemHeight = 24;
            this.cb_sun.Items.AddRange(new object[] {
            "high ",
            "medium",
            "low ",
            "not Found"});
            this.cb_sun.Location = new System.Drawing.Point(47, 344);
            this.cb_sun.Name = "cb_sun";
            this.cb_sun.Size = new System.Drawing.Size(273, 32);
            this.cb_sun.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(44, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Sun level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(44, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Month";
            // 
            // cb_month
            // 
            this.cb_month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.cb_month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_month.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_month.ForeColor = System.Drawing.SystemColors.Info;
            this.cb_month.FormattingEnabled = true;
            this.cb_month.ItemHeight = 24;
            this.cb_month.Items.AddRange(new object[] {
            "january",
            "febrary",
            "march",
            "april",
            "may",
            "june ",
            "july",
            "august",
            "september",
            "october",
            "november",
            "december"});
            this.cb_month.Location = new System.Drawing.Point(47, 229);
            this.cb_month.Name = "cb_month";
            this.cb_month.Size = new System.Drawing.Size(273, 32);
            this.cb_month.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Temprature";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.GhostWhite;
            this.panel8.Location = new System.Drawing.Point(47, 133);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(273, 1);
            this.panel8.TabIndex = 35;
            // 
            // tb_temprature
            // 
            this.tb_temprature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tb_temprature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_temprature.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_temprature.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_temprature.Location = new System.Drawing.Point(47, 97);
            this.tb_temprature.Name = "tb_temprature";
            this.tb_temprature.Size = new System.Drawing.Size(273, 33);
            this.tb_temprature.TabIndex = 34;
            // 
            // lb_exit
            // 
            this.lb_exit.AutoSize = true;
            this.lb_exit.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exit.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_exit.Location = new System.Drawing.Point(1195, 9);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(40, 40);
            this.lb_exit.TabIndex = 46;
            this.lb_exit.Text = "X";
            this.lb_exit.Click += new System.EventHandler(this.lb_exit_Click);
            this.lb_exit.MouseLeave += new System.EventHandler(this.lb_exit_MouseLeave);
            this.lb_exit.MouseHover += new System.EventHandler(this.lb_exit_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(775, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 45;
            this.label5.Text = "The Predction ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lb_predctions2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lb_prections);
            this.panel1.Location = new System.Drawing.Point(779, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 397);
            this.panel1.TabIndex = 44;
            // 
            // lb_prections
            // 
            this.lb_prections.AutoSize = true;
            this.lb_prections.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prections.ForeColor = System.Drawing.Color.Snow;
            this.lb_prections.Location = new System.Drawing.Point(15, 64);
            this.lb_prections.Name = "lb_prections";
            this.lb_prections.Size = new System.Drawing.Size(201, 29);
            this.lb_prections.TabIndex = 37;
            this.lb_prections.Text = "The Predction 1";
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_show.FlatAppearance.BorderSize = 0;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_show.Location = new System.Drawing.Point(255, 592);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(219, 50);
            this.btn_show.TabIndex = 43;
            this.btn_show.Text = "Show Prediction";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // timer_exit
            // 
            this.timer_exit.Interval = 80;
            this.timer_exit.Tick += new System.EventHandler(this.timer_exit_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "Today :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(12, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "Week :";
            // 
            // lb_predctions2
            // 
            this.lb_predctions2.AutoSize = true;
            this.lb_predctions2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_predctions2.ForeColor = System.Drawing.Color.Snow;
            this.lb_predctions2.Location = new System.Drawing.Point(12, 252);
            this.lb_predctions2.Name = "lb_predctions2";
            this.lb_predctions2.Size = new System.Drawing.Size(208, 29);
            this.lb_predctions2.TabIndex = 40;
            this.lb_predctions2.Text = "The Predction  2";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Location = new System.Drawing.Point(639, 592);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(167, 50);
            this.btn_back.TabIndex = 47;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1247, 685);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.cb_wind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_sun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.tb_temprature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_wind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_sun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tb_temprature;
        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_prections;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Timer timer_exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_predctions2;
        private System.Windows.Forms.Button btn_back;

    }
}

