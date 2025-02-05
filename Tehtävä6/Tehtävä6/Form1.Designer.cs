namespace Tehtävä6
{
    partial class SalasanaFM
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
            this.salasanaOikeinPL = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SalasanaPL = new System.Windows.Forms.Panel();
            this.virheViestiLB = new System.Windows.Forms.Label();
            this.tarkistaBT = new System.Windows.Forms.Button();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.kayttajatunnusTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salasanaOikeinPL.SuspendLayout();
            this.SalasanaPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // salasanaOikeinPL
            // 
            this.salasanaOikeinPL.BackColor = System.Drawing.Color.DarkRed;
            this.salasanaOikeinPL.Controls.Add(this.label3);
            this.salasanaOikeinPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaOikeinPL.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.salasanaOikeinPL.ForeColor = System.Drawing.Color.Snow;
            this.salasanaOikeinPL.Location = new System.Drawing.Point(0, 0);
            this.salasanaOikeinPL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.salasanaOikeinPL.Name = "salasanaOikeinPL";
            this.salasanaOikeinPL.Size = new System.Drawing.Size(733, 307);
            this.salasanaOikeinPL.TabIndex = 0;
            this.salasanaOikeinPL.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(574, 80);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaPL
            // 
            this.SalasanaPL.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPL.Controls.Add(this.virheViestiLB);
            this.SalasanaPL.Controls.Add(this.tarkistaBT);
            this.SalasanaPL.Controls.Add(this.salasanaTB);
            this.SalasanaPL.Controls.Add(this.kayttajatunnusTB);
            this.SalasanaPL.Controls.Add(this.label2);
            this.SalasanaPL.Controls.Add(this.label1);
            this.SalasanaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalasanaPL.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPL.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPL.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SalasanaPL.Name = "SalasanaPL";
            this.SalasanaPL.Size = new System.Drawing.Size(733, 307);
            this.SalasanaPL.TabIndex = 1;
            // 
            // virheViestiLB
            // 
            this.virheViestiLB.AutoSize = true;
            this.virheViestiLB.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.virheViestiLB.Location = new System.Drawing.Point(44, 186);
            this.virheViestiLB.Name = "virheViestiLB";
            this.virheViestiLB.Size = new System.Drawing.Size(86, 38);
            this.virheViestiLB.TabIndex = 5;
            this.virheViestiLB.Text = "Virhe";
            // 
            // tarkistaBT
            // 
            this.tarkistaBT.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarkistaBT.ForeColor = System.Drawing.Color.Black;
            this.tarkistaBT.Location = new System.Drawing.Point(505, 170);
            this.tarkistaBT.Name = "tarkistaBT";
            this.tarkistaBT.Size = new System.Drawing.Size(134, 51);
            this.tarkistaBT.TabIndex = 4;
            this.tarkistaBT.Text = "Tarkista";
            this.tarkistaBT.UseVisualStyleBackColor = true;
            this.tarkistaBT.Click += new System.EventHandler(this.tarkistaBT_Click);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(290, 115);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(349, 39);
            this.salasanaTB.TabIndex = 3;
            // 
            // kayttajatunnusTB
            // 
            this.kayttajatunnusTB.Location = new System.Drawing.Point(290, 53);
            this.kayttajatunnusTB.Name = "kayttajatunnusTB";
            this.kayttajatunnusTB.Size = new System.Drawing.Size(349, 39);
            this.kayttajatunnusTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(106, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // SalasanaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 307);
            this.Controls.Add(this.SalasanaPL);
            this.Controls.Add(this.salasanaOikeinPL);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SalasanaFM";
            this.Text = "Salasanan tarkastus";
            this.salasanaOikeinPL.ResumeLayout(false);
            this.salasanaOikeinPL.PerformLayout();
            this.SalasanaPL.ResumeLayout(false);
            this.SalasanaPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel salasanaOikeinPL;
        private Panel SalasanaPL;
        private Label virheViestiLB;
        private Button tarkistaBT;
        private TextBox salasanaTB;
        private TextBox kayttajatunnusTB;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}