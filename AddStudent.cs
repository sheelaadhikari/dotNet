using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class AddStudent : Form
    {
        int index = 0;
        Student[] students = new Student[3];
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
Student student = new Student();
            student.Name = maskedTextBox1.Text;
            student.Address = maskedTextBox3.Text;
            student.Email = maskedTextBox2.Text;
            
            students[index] = student;
            index++;
            MessageBox.Show("added successfully");
            maskedTextBox1.Text = String.Empty;
            maskedTextBox3.Text = String.Empty;
                maskedTextBox2.Text = String.Empty;



        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
