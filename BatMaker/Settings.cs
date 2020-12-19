using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatMaker
{
    public partial class Settings : Form
    {

        public string pathToSave = Application.StartupPath;
        public string fileName;

        public Settings()
        {
            InitializeComponent();
            textBox2.Text = pathToSave;
            textBox1.Text = fileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathToSave = folder.SelectedPath;
                textBox2.Text = pathToSave;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("You didn't enter a name for your file.", "Error");
            } else
            {
                fileName = textBox1.Text;
                pathToSave = textBox2.Text;
            }
        }
    }
}
