using Lab4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class frmStudentSearch : Form
    {
        StudentContext studentContext = new StudentContext();
        public frmStudentSearch()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Search()
        {
            List<Student> result = studentContext.Students.Where(x => x.StudentName.Contains(txtStudentName.Text) && x.StudentID.Contains(txtStudentID.Text) && x.FacultyID == (int)cbxFaculty.SelectedValue).ToList();
            dgvResult.DataSource = result.Select(x => new
            {
                StudentID = x.StudentID,
                StudentName = x.StudentName,
                AverageScore = x.AverageScore,
                FacultyName = x.Faculty.FacultyName
            }).ToList();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Refresh()
        {
            dgvResult.DataSource = studentContext.Students.Select(x => new
            {
                StudentID = x.StudentID,
                StudentName = x.StudentName,
                FacultyName = x.Faculty.FacultyName,
                AverageScore = x.AverageScore
            }).ToList();
            cbxFaculty.DataSource = studentContext.Faculties.ToList();
            cbxFaculty.DisplayMember = "FacultyName";
            cbxFaculty.ValueMember = "FacultyID";
        }
        private void frmStudentSearch_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát tìm kiếm?", "Ảe you sủe?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
