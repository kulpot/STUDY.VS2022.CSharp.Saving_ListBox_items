using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Saving listBox items to file and copying them to clipboard.

namespace Saving_ListBox_items
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(txtInput.Text);
            txtInput.Clear();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("list.txt"))
                {
                    foreach (string itemText in listBox.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }

                Process.Start("list.txt");
            }
        }

        private void btnCopyToClip_Click(object sender, EventArgs e)
        {
            if(listBox.Items.Count > 0)
            {
                StringBuilder SB = new StringBuilder();

                foreach(string itemValue in listBox.Items)
                {
                    SB.AppendLine(itemValue);
                }

                // Further process text here, ex remove last newline
                string result = SB.ToString().TrimEnd('\n');

                Clipboard.SetText(result);
            }
        }
    }
}
