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
            label1.Text = ID.ToString();
        }
    }
}
