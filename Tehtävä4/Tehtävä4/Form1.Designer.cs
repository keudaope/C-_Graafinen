namespace Tehtävä4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.synttariDT = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VuosissaLB = new System.Windows.Forms.Label();
            this.KuukausissaLB = new System.Windows.Forms.Label();
            this.Paivissa = new System.Windows.Forms.Label();
            this.TunneissaLB = new System.Windows.Forms.Label();
            this.MinuuteissaLB = new System.Windows.Forms.Label();
            this.SekunneissaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(39, 30);
            this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(187, 30);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Anna syntymäaika:";
            // 
            // synttariDT
            // 
            this.synttariDT.Location = new System.Drawing.Point(45, 71);
            this.synttariDT.Name = "synttariDT";
            this.synttariDT.Size = new System.Drawing.Size(338, 35);
            this.synttariDT.TabIndex = 1;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(389, 71);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(92, 39);
            this.LaskeBT.TabIndex = 2;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VuosissaLB
            // 
            this.VuosissaLB.AutoSize = true;
            this.VuosissaLB.Location = new System.Drawing.Point(50, 130);
            this.VuosissaLB.Name = "VuosissaLB";
            this.VuosissaLB.Size = new System.Drawing.Size(23, 30);
            this.VuosissaLB.TabIndex = 3;
            this.VuosissaLB.Text = "x";
            this.VuosissaLB.Visible = false;
            this.VuosissaLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // KuukausissaLB
            // 
            this.KuukausissaLB.AutoSize = true;
            this.KuukausissaLB.Location = new System.Drawing.Point(50, 176);
            this.KuukausissaLB.Name = "KuukausissaLB";
            this.KuukausissaLB.Size = new System.Drawing.Size(23, 30);
            this.KuukausissaLB.TabIndex = 4;
            this.KuukausissaLB.Text = "x";
            this.KuukausissaLB.Visible = false;
            // 
            // Paivissa
            // 
            this.Paivissa.AutoSize = true;
            this.Paivissa.Location = new System.Drawing.Point(50, 225);
            this.Paivissa.Name = "Paivissa";
            this.Paivissa.Size = new System.Drawing.Size(23, 30);
            this.Paivissa.TabIndex = 5;
            this.Paivissa.Text = "x";
            this.Paivissa.Visible = false;
            // 
            // TunneissaLB
            // 
            this.TunneissaLB.AutoSize = true;
            this.TunneissaLB.Location = new System.Drawing.Point(220, 130);
            this.TunneissaLB.Name = "TunneissaLB";
            this.TunneissaLB.Size = new System.Drawing.Size(23, 30);
            this.TunneissaLB.TabIndex = 6;
            this.TunneissaLB.Text = "x";
            this.TunneissaLB.Visible = false;
            this.TunneissaLB.Click += new System.EventHandler(this.label4_Click);
            // 
            // MinuuteissaLB
            // 
            this.MinuuteissaLB.AutoSize = true;
            this.MinuuteissaLB.Location = new System.Drawing.Point(220, 176);
            this.MinuuteissaLB.Name = "MinuuteissaLB";
            this.MinuuteissaLB.Size = new System.Drawing.Size(23, 30);
            this.MinuuteissaLB.TabIndex = 7;
            this.MinuuteissaLB.Text = "x";
            this.MinuuteissaLB.Visible = false;
            // 
            // SekunneissaLB
            // 
            this.SekunneissaLB.AutoSize = true;
            this.SekunneissaLB.Location = new System.Drawing.Point(220, 225);
            this.SekunneissaLB.Name = "SekunneissaLB";
            this.SekunneissaLB.Size = new System.Drawing.Size(23, 30);
            this.SekunneissaLB.TabIndex = 8;
            this.SekunneissaLB.Text = "x";
            this.SekunneissaLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 283);
            this.Controls.Add(this.SekunneissaLB);
            this.Controls.Add(this.MinuuteissaLB);
            this.Controls.Add(this.TunneissaLB);
            this.Controls.Add(this.Paivissa);
            this.Controls.Add(this.KuukausissaLB);
            this.Controls.Add(this.VuosissaLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.synttariDT);
            this.Controls.Add(this.OtsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private DateTimePicker synttariDT;
        private Button LaskeBT;
        private Label VuosissaLB;
        private Label KuukausissaLB;
        private Label Paivissa;
        private Label TunneissaLB;
        private Label MinuuteissaLB;
        private Label SekunneissaLB;
    }
}