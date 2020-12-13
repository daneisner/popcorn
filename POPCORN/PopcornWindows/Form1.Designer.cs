namespace PopcornWindows
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
            this.startClock = new System.Windows.Forms.Button();
            this.callPopcorn = new System.Windows.Forms.Button();
            this.popcornBox = new System.Windows.Forms.RichTextBox();
            this.clockBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startClock
            // 
            this.startClock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startClock.Location = new System.Drawing.Point(257, 352);
            this.startClock.Name = "startClock";
            this.startClock.Size = new System.Drawing.Size(155, 64);
            this.startClock.TabIndex = 0;
            this.startClock.Text = "Start Clock";
            this.startClock.UseVisualStyleBackColor = true;
            this.startClock.Click += new System.EventHandler(this.button1_Click);
            // 
            // callPopcorn
            // 
            this.callPopcorn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.callPopcorn.Location = new System.Drawing.Point(39, 352);
            this.callPopcorn.Name = "callPopcorn";
            this.callPopcorn.Size = new System.Drawing.Size(155, 64);
            this.callPopcorn.TabIndex = 1;
            this.callPopcorn.Text = "Call Popcorn";
            this.callPopcorn.UseVisualStyleBackColor = true;
            this.callPopcorn.Click += new System.EventHandler(this.button2_Click);
            // 
            // popcornBox
            // 
            this.popcornBox.Location = new System.Drawing.Point(12, 12);
            this.popcornBox.Name = "popcornBox";
            this.popcornBox.Size = new System.Drawing.Size(776, 304);
            this.popcornBox.TabIndex = 2;
            this.popcornBox.Text = "Popcorn";
            this.popcornBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // clockBox
            // 
            this.clockBox.Location = new System.Drawing.Point(437, 322);
            this.clockBox.Name = "clockBox";
            this.clockBox.Size = new System.Drawing.Size(351, 116);
            this.clockBox.TabIndex = 3;
            this.clockBox.Text = "Clock";
            this.clockBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clockBox);
            this.Controls.Add(this.popcornBox);
            this.Controls.Add(this.callPopcorn);
            this.Controls.Add(this.startClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startClock;
        private System.Windows.Forms.Button callPopcorn;
        private System.Windows.Forms.RichTextBox popcornBox;
        private System.Windows.Forms.RichTextBox clockBox;
    }
}

