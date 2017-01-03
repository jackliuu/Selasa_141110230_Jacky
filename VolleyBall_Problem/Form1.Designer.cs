namespace VolleyBall_Problem
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
            this.Buttonhasil = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Buttonhasil
            // 
            this.Buttonhasil.BackColor = System.Drawing.Color.Black;
            this.Buttonhasil.ForeColor = System.Drawing.Color.White;
            this.Buttonhasil.Location = new System.Drawing.Point(118, 92);
            this.Buttonhasil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Buttonhasil.Name = "Buttonhasil";
            this.Buttonhasil.Size = new System.Drawing.Size(112, 35);
            this.Buttonhasil.TabIndex = 13;
            this.Buttonhasil.Text = "Result";
            this.Buttonhasil.UseVisualStyleBackColor = false;
            this.Buttonhasil.Click += new System.EventHandler(this.Buttonhasil_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(87, 56);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(178, 26);
            this.txt2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Score B";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(87, 17);
            this.txt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(178, 26);
            this.txt1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Score A";
            // 
            // txthasil
            // 
            this.txthasil.Location = new System.Drawing.Point(130, 135);
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(100, 26);
            this.txthasil.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 188);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.Buttonhasil);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buttonhasil;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthasil;
    }
}

