namespace Latihan_1_2
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
            this.calender = new System.Windows.Forms.DateTimePicker();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Label();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // calender
            // 
            this.calender.Location = new System.Drawing.Point(-1, 2);
            this.calender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calender.Name = "calender";
            this.calender.Size = new System.Drawing.Size(642, 26);
            this.calender.TabIndex = 10;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(36, 48);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(48, 404);
            this.vScrollBar1.TabIndex = 11;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.Color.Maroon;
            this.min.Location = new System.Drawing.Point(124, 60);
            this.min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(151, 75);
            this.min.TabIndex = 12;
            this.min.Text = "MIN";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Palatino Linotype", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.ForeColor = System.Drawing.Color.Maroon;
            this.max.Location = new System.Drawing.Point(304, 60);
            this.max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(166, 75);
            this.max.TabIndex = 13;
            this.max.Text = "MAX";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.ForeColor = System.Drawing.Color.Black;
            this.test.Location = new System.Drawing.Point(274, 210);
            this.test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(58, 68);
            this.test.TabIndex = 14;
            this.test.Text = "-";
            this.test.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(522, 48);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(50, 448);
            this.vScrollBar2.TabIndex = 15;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 488);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.test);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.calender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker calender;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label test;
        private System.Windows.Forms.VScrollBar vScrollBar2;
    }
}

