﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save this file ?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (richTextBox1.Text != null)
            {
                if (dr == DialogResult.Yes) saveFile(richTextBox1);
                else if (dr == DialogResult.No)
                {
                    richTextBox1.Focus();
                }
                else if (dr == DialogResult.Cancel) return;
                richTextBox1.Text = "";
            }
        }
        private void saveFile(RichTextBox rb)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = "*.rtf";
            sf.Filter = "RTF Files|*.rtf";
            if (richTextBox1.Text == null) return;
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK & sf.FileName.Length > 0)
                rb.SaveFile(sf.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(richTextBox1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save this files ?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (richTextBox1.Text != null)
            {
                if (dr == DialogResult.Yes) saveFile(richTextBox1);
                else if (dr == DialogResult.No) Application.Exit();
                else if (dr == DialogResult.Cancel) return;
            }
        }

        private void sizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult warna = colorDialog1.ShowDialog();
            if (warna == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }

        }
    }
}
