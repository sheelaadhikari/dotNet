using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DisplayStudent : Form
    {
        Student[] students=new Student[3];
        public DisplayStudent(Student[] students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void DisplayStudent_Load(object sender, EventArgs e)
        {
           
         dataGridView1.DataSource= students;

        }
    }
}
