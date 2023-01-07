namespace I_hate_this
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ask = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.cardNumber = new System.Windows.Forms.TextBox();
            this.ExpMonth = new System.Windows.Forms.TextBox();
            this.ExpYear = new System.Windows.Forms.TextBox();
            this.CVV = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 339);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ask
            // 
            this.ask.Location = new System.Drawing.Point(268, 12);
            this.ask.Name = "ask";
            this.ask.ReadOnly = true;
            this.ask.Size = new System.Drawing.Size(520, 27);
            this.ask.TabIndex = 1;
            this.ask.Text = "c-could i please have your c-card information?... >//<";
            this.ask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(399, 50);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(389, 27);
            this.Name.TabIndex = 2;
            // 
            // cardNumber
            // 
            this.cardNumber.Location = new System.Drawing.Point(399, 83);
            this.cardNumber.Name = "cardNumber";
            this.cardNumber.Size = new System.Drawing.Size(389, 27);
            this.cardNumber.TabIndex = 3;
            // 
            // ExpMonth
            // 
            this.ExpMonth.Location = new System.Drawing.Point(399, 149);
            this.ExpMonth.Name = "ExpMonth";
            this.ExpMonth.Size = new System.Drawing.Size(192, 27);
            this.ExpMonth.TabIndex = 4;
            // 
            // ExpYear
            // 
            this.ExpYear.Location = new System.Drawing.Point(597, 149);
            this.ExpYear.Name = "ExpYear";
            this.ExpYear.Size = new System.Drawing.Size(191, 27);
            this.ExpYear.TabIndex = 5;
            // 
            // CVV
            // 
            this.CVV.Location = new System.Drawing.Point(399, 116);
            this.CVV.Name = "CVV";
            this.CVV.Size = new System.Drawing.Size(389, 27);
            this.CVV.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Card Number";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "CVV";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(268, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Expiry (MM/YYYY)";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(430, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thanks....";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CVV);
            this.Controls.Add(this.ExpYear);
            this.Controls.Add(this.ExpMonth);
            this.Controls.Add(this.cardNumber);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ask);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Totally Not Malware";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox ask;
        private TextBox Name;
        private TextBox cardNumber;
        private TextBox ExpMonth;
        private TextBox ExpYear;
        private TextBox CVV;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}