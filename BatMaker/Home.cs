using System;
using System.Collections;
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
    public partial class Home : Form
    {

        public static string nameFile;
        public static string filePath = Application.StartupPath;
        public static int nbTasks = 0;
        public static List<Task> tasks = new List<Task>();
        private FlowLayoutPanel _flowLayoutPanel = new FlowLayoutPanel();
        private List<TaskData> _tasksData;

        public FlowLayoutPanel FlowLayoutPanel
        {
            get { return this._flowLayoutPanel; }
            set { this._flowLayoutPanel = flowLayoutPanel1; }
        }

        public List<TaskData> TaskData {
            get { return this._tasksData; }
            set { this._tasksData = value;  }
        }

        public Home()
        {
            InitializeComponent();
            TaskData = new List<TaskData>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task task = new Task(nbTasks++);
            flowLayoutPanel1.Controls.Add(task);
            tasks.Add(task);
            TaskData taskData = new TaskData(task.ID);
            TaskData.Add(taskData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO GENERATE BAT FILE
        }
    }
}
