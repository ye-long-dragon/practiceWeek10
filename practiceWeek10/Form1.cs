using practiceWeek10.Models;
using practiceWeek10.Repositories;
using System.Data;

namespace practiceWeek10
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            ReadStudents();
        }

        int Id = 0;

        

        public void ReadStudents()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Student Id");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Birthdate");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone Number");

            var repo = new StudentRepository();
            var students = repo.ReadStudents();

            foreach (var student in students)
            {

                var row = dataTable.NewRow();
                row[0] = student.Id;
                row[1] = student.FirstName;
                row[2] = student.LastName;
                row[3] = student.Birtthdate;
                row[4] = student.address;
                row[5] = student.number;

                dataTable.Rows.Add(row);
            }
            this.dgvStudent.DataSource = dataTable;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentCreation studentCreation = new StudentCreation();
            if (studentCreation.ShowDialog() == DialogResult.Cancel) return;

            ReadStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var repo = new StudentRepository();
            repo.deleteStudents(Id);
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvStudent.Rows[e.RowIndex];
            Id = Convert.ToInt32(row.Cells[0].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
