namespace WindowsFormsApp1
{
    partial class CaptialPredctions
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_prections = new System.Windows.Forms.Label();
            this.cb_captial = new System.Windows.Forms.ComboBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.lb_exit = new System.Windows.Forms.Label();
            this.timer_exit = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(245, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Captial";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lb_prections);
            this.panel1.Location = new System.Drawing.Point(210, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 82);
            this.panel1.TabIndex = 45;
            // 
            // lb_prections
            // 
            this.lb_prections.AutoSize = true;
            this.lb_prections.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_prections.ForeColor = System.Drawing.Color.Snow;
            this.lb_prections.Location = new System.Drawing.Point(66, 29);
            this.lb_prections.Name = "lb_prections";
            this.lb_prections.Size = new System.Drawing.Size(269, 29);
            this.lb_prections.TabIndex = 37;
            this.lb_prections.Text = "The Captial Predction";
            // 
            // cb_captial
            // 
            this.cb_captial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.cb_captial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_captial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_captial.ForeColor = System.Drawing.SystemColors.Info;
            this.cb_captial.FormattingEnabled = true;
            this.cb_captial.ItemHeight = 24;
            this.cb_captial.Items.AddRange(new object[] {
            "Cairo",
            "Mexcic",
            "Roma",
            "Sudan",
            "Mosco",
            "Gana",
            "Alska",
            "Paris",
            "Tunsia"});
            this.cb_captial.Location = new System.Drawing.Point(249, 244);
            this.cb_captial.Name = "cb_captial";
            this.cb_captial.Size = new System.Drawing.Size(273, 32);
            this.cb_captial.TabIndex = 46;
            this.cb_captial.SelectedIndexChanged += new System.EventHandler(this.cb_captial_SelectedIndexChanged);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_show.FlatAppearance.BorderSize = 0;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_show.Location = new System.Drawing.Point(277, 387);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(219, 50);
            this.btn_show.TabIndex = 44;
            this.btn_show.Text = "Back";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lb_exit
            // 
            this.lb_exit.AutoSize = true;
            this.lb_exit.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exit.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_exit.Location = new System.Drawing.Point(743, 9);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(40, 40);
            this.lb_exit.TabIndex = 47;
            this.lb_exit.Text = "X";
            this.lb_exit.Click += new System.EventHandler(this.lb_exit_Click);
            // 
            // timer_exit
            // 
            this.timer_exit.Interval = 80;
            this.timer_exit.Tick += new System.EventHandler(this.timer_exit_Tick);
            // 
            // CaptialPredctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(795, 492);
            this.Controls.Add(this.lb_exit);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.cb_captial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptialPredctions";
            this.Text = "CaptialPredctions";
            this.Load += new System.EventHandler(this.CaptialPredctions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_prections;
        private System.Windows.Forms.ComboBox cb_captial;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.Timer timer_exit;
    }
}