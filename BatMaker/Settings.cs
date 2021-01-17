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

        public Settings()
        {
            InitializeComponent();
            textBox2.Text = Home.filePath;
            textBox1.Text = Home.nameFile;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Home.filePath = folder.SelectedPath;
                textBox2.Text = Home.filePath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("You didn't enter a name for your file.", "Error");
            } else
            {
                Home.nameFile = textBox1.Text;
                Home.filePath = textBox2.Text;
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO add a check if any changes has been done
            Console.WriteLine(String.Equals(Home.filePath, textBox2.Text));
            Console.WriteLine(String.Equals(Home.nameFile, textBox1.Text));
            if (String.Equals(Home.filePath, textBox2.Text) && String.Equals(Home.nameFile, textBox1.Text))
            {
                this.Close();
            } else
            {
                if(MessageBox.Show("Some changes have occured are you sure you want to quit ?", "Unsaved changes", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }     
        }
    }
}
