using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveNameUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> nameList = new List<string>();
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameList.Count < 10)
            {
                nameList.Add(nameTextBox.Text);
                
                if (nameList.Count == 10)
                {
                    foreach (string aName in nameList)
                    {
                        showListBox.Items.Add(aName);
                    }
                }
            }
            else
            {
                MessageBox.Show("You can't Save Data");
            }
            nameCountLabel.Text = nameList.Count.ToString();
            nameTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            foreach (string aName in nameList)
            {
                showListBox.Items.Add(aName);
            }
        }
    }
}
