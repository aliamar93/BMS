using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class Admin_Interface : Form
    {
        public Admin_Interface()
        {
            InitializeComponent();
        }

        private void CreateStudent_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            newStudent.Show();
        }
    }
}
