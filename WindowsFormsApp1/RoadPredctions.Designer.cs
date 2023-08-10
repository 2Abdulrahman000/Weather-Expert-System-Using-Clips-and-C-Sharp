namespace WindowsFormsApp1
{
    partial class RoadPredctions
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_prections = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_exit = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.cb_road = new System.Windows.Forms.ComboBox();
            this.timer_exit = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lb_prections);
            this.panel1.Location = new System.Drawing.Point(229, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 82);
            this.panel1.TabIndex = 50;
            // 
            // lb_prections
            // 
            this.lb_prections.AutoSize = true;
            this.lb_prections.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prections.ForeColor = System.Drawing.Color.Snow;
            this.lb_prections.Location = new System.Drawing.Point(69, 29);
            this.lb_prections.Name = "lb_prections";
            this.lb_prections.Size = new System.Drawing.Size(247, 29);
            this.lb_prections.TabIndex = 37;
            this.lb_prections.Text = "The Road Predction";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(264, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Road Name";
            // 
            // lb_exit
            // 
            this.lb_exit.AutoSize = true;
            this.lb_exit.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exit.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_exit.Location = new System.Drawing.Point(743, 9);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(40, 40);
            this.lb_exit.TabIndex = 52;
            this.lb_exit.Text = "X";
            this.lb_exit.Click += new System.EventHandler(this.lb_exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Location = new System.Drawing.Point(296, 398);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(219, 50);
            this.btn_back.TabIndex = 49;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cb_road
            // 
            this.cb_road.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.cb_road.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_road.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_road.ForeColor = System.Drawing.SystemColors.Info;
            this.cb_road.FormattingEnabled = true;
            this.cb_road.ItemHeight = 24;
            this.cb_road.Items.AddRange(new object[] {
            "Cairo-Portsaid",
            "Mit ghamr-Mansoura",
            "Aswan-Minia",
            "Luxor-Alex",
            "Cairo-Alex",
            "Mit ghamr-Cairo",
            "Benha-Tanta",
            "Dametta-Cairo",
            "My Home-Alex"});
            this.cb_road.Location = new System.Drawing.Point(268, 255);
            this.cb_road.Name = "cb_road";
            this.cb_road.Size = new System.Drawing.Size(273, 32);
            this.cb_road.TabIndex = 51;
            this.cb_road.SelectedIndexChanged += new System.EventHandler(this.cb_road_SelectedIndexChanged);
            // 
            // timer_exit
            // 
            this.timer_exit.Interval = 80;
            this.timer_exit.Tick += new System.EventHandler(this.timer_exit_Tick);
            // 
            // RoadPredctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(795, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.cb_road);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoadPredctions";
            this.Text = "RoadPredctions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_prections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cb_road;
        private System.Windows.Forms.Timer timer_exit;
    }
}