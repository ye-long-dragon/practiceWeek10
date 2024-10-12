using practiceWeek10.Models;
using practiceWeek10.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceWeek10
{
    public partial class StudentCreation : Form
    {
        public StudentCreation()
        {
            InitializeComponent();

            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Student student = new Student();
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Birtthdate = Convert.ToDateTime(txtBirthDate.Text);
            student.address = txtAddress.Text;
            student.number = txtNumber.Text;

            var repo = new StudentRepository();
            repo.createStudents(student);
            
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }
    }
}
