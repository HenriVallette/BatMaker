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
    public partial class TaskEditor : Form
    {
        public int ID;

        public TaskEditor(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            addInstruction();
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addInstruction();
            }
        }

        private void addInstruction()
        {
            if (String.IsNullOrEmpty(guna2ComboBox1.Text))
            {
                MessageBox.Show("You didn't enter a software to launch", "Error");
            } else if(String.IsNullOrEmpty(guna2TextBox1.Text))
            {
                MessageBox.Show("You didn't enter a file or website to launch", "Error");
            } else
            {
                Guna.UI2.WinForms.Guna2Chip instruction = new Guna.UI2.WinForms.Guna2Chip();
                instruction.Text = ("%s / %s", guna2TextBox1.Text, );
                instruction.Width = 275;
                instruction.Height = 35;
                instruction.FillColor = Color.CornflowerBlue;
                instruction.BorderColor = Color.SteelBlue;
                flowLayoutPanel1.Controls.Add(instruction);
            }
        }

        private void guna2ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label1.Text = guna2ComboBox1.Text;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(flowLayoutPanel1.Controls.Count == 0)
            {
                MessageBox.Show("You didn't enter a task to do", "Error");
            } else
            {
                foreach(Control tasks in flowLayoutPanel1.Controls)
                {
                    
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
