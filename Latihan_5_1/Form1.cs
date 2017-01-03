using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        string filename;
        Boolean newfile = false;
        public Form1()
        {
            InitializeComponent();
            textboxArea.Enabled = false;
            buttonSave.Enabled = false;
            labelFilename.Text = "";

            ContextMenu klikkananmenu = new ContextMenu();
            klikkananmenu.MenuItems.Add("Cut", cutToolStripMenuItem_Click);
            klikkananmenu.MenuItems.Add("Copy", copyToolStripMenuItem_Click);
            klikkananmenu.MenuItems.Add("Paste", pasteToolStripMenuItem_Click);
            klikkananmenu.MenuItems.Add("Delete", deleteToolStripMenuItem_Click);

            textboxArea.ContextMenu = klikkananmenu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog window_open_dialog = new OpenFileDialog();

            if (window_open_dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream_read = new StreamReader(File.OpenRead(window_open_dialog.FileName));
                textboxArea.Text = stream_read.ReadToEnd();
                stream_read.Dispose();
                //
                textboxArea.Enabled = true;
                buttonSave.Enabled = true;
                filename = window_open_dialog.FileName;
                labelFilename.Text = filename;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newfile = true;
            textboxArea.Enabled = true;
            buttonSave.Enabled = true;
            textboxArea.Text = "";
            labelFilename.Text = "Filename : *untitled";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StreamWriter stream_write = new StreamWriter(filename);
            stream_write.Write(textboxArea.Text);
            stream_write.Dispose();
            //
            labelFilename.Text = filename;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = textboxArea.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textboxArea.SelectionFont = fd.Font;
            }
        }

        private void Color1_Click(object sender, EventArgs e)
        {
            DialogResult warna = colorDialog1.ShowDialog();
            if (warna == DialogResult.OK)
            {
                textboxArea.ForeColor = colorDialog1.Color;
            }
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ChildForm = new Form2();
            ChildForm.Show();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textboxArea.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textboxArea.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textboxArea.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textboxArea.Text = textboxArea.Text.Remove(textboxArea.SelectionStart, textboxArea.SelectionLength);
        }
    }
}
