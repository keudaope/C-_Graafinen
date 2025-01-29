namespace Tehtävä1
{
    partial class Harjoitus1
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
            this.tekstiLB = new System.Windows.Forms.Label();
            this.VaihtoBT = new System.Windows.Forms.Button();
            this.TextLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tekstiLB
            // 
            this.tekstiLB.Location = new System.Drawing.Point(0, 0);
            this.tekstiLB.Name = "tekstiLB";
            this.tekstiLB.Size = new System.Drawing.Size(100, 23);
            this.tekstiLB.TabIndex = 2;
            // 
            // VaihtoBT
            // 
            this.VaihtoBT.Location = new System.Drawing.Point(162, 129);
            this.VaihtoBT.Name = "VaihtoBT";
            this.VaihtoBT.Size = new System.Drawing.Size(75, 40);
            this.VaihtoBT.TabIndex = 1;
            this.VaihtoBT.Text = "Vaihda teksti";
            this.VaihtoBT.UseVisualStyleBackColor = true;
            this.VaihtoBT.Click += new System.EventHandler(this.VaihtoBT_Click);
            // 
            // TextLB
            // 
            this.TextLB.AutoSize = true;
            this.TextLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextLB.Location = new System.Drawing.Point(156, 68);
            this.TextLB.Name = "TextLB";
            this.TextLB.Size = new System.Drawing.Size(216, 32);
            this.TextLB.TabIndex = 3;
            this.TextLB.Text = "Jotain uutta tekstiä";
            // 
            // Harjoitus1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextLB);
            this.Controls.Add(this.VaihtoBT);
            this.Controls.Add(this.tekstiLB);
            this.Name = "Harjoitus1";
            this.Text = "Harjoitus1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tekstiLB;
        private Button VaihtoBT;
        private Label TextLB;
    }
}