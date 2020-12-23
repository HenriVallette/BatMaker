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
    public partial class Task : UserControl
    {

        private int ID;

        public Task(int id)
        {
            InitializeComponent();
            checkBox1.Checked = true;
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskEditor task = new TaskEditor(ID);
            task.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home.tasks.Remove(getTaskFromID(ID));
        }

        private Task getTaskFromID(int ID)
        {
            foreach(Task task in Home.tasks)
            {
                if(task.ID == ID)
                {
                    return task;
                }
            }
            return null;
        }
    }
}
