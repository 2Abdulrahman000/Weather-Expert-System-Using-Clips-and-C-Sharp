namespace WindowsFormsApp1
{
    partial class WelcomeForm
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
            this.lab_title = new System.Windows.Forms.Label();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            this.timer_letter = new System.Windows.Forms.Timer(this.components);
            this.panel_loading = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lab_title.Location = new System.Drawing.Point(169, 143);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(599, 52);
            this.lab_title.TabIndex = 3;
            this.lab_title.Text = "Weather Expert System";
            // 
            // timer_loading
            // 
            this.timer_loading.Interval = 50;
            this.timer_loading.Tick += new System.EventHandler(this.timer_loading_Tick);
            // 
            // timer_letter
            // 
            this.timer_letter.Enabled = true;
            this.timer_letter.Tick += new System.EventHandler(this.timer_letter_Tick);
            // 
            // panel_loading
            // 
            this.panel_loading.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_loading.Location = new System.Drawing.Point(3, 343);
            this.panel_loading.Name = "panel_loading";
            this.panel_loading.Size = new System.Drawing.Size(56, 8);
            this.panel_loading.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(3, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 8);
            this.panel1.TabIndex = 4;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(882, 388);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.panel_loading);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Timer timer_loading;
        private System.Windows.Forms.Timer timer_letter;
        private System.Windows.Forms.Panel panel_loading;
        private System.Windows.Forms.Panel panel1;
    }
}