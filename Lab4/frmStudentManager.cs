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
    public partial class frmStudent : Form
    {
        StudentContext studentContext = new StudentContext();
        public frmStudent()
        {
            InitializeComponent();
        }
        private void Refresh()
        {
            cbxFaculty.DataSource = studentContext.Faculties.ToList();
            cbxFaculty.DisplayMember = "FacultyName";
            cbxFaculty.ValueMember = "FacultyID";
            dgvStudent.DataSource = studentContext.Students.Select(x => new
            {
                StudentID = x.StudentID,
                StudentName = x.StudentName,
                AverageScore = x.AverageScore,
                FacultyName = x.Faculty.FacultyName
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            try
            {
                var studentAdd = studentContext.Students.FirstOrDefault(x => x.StudentID == txtStudentID.Text);
                if (studentAdd != null)
                {
                    throw new Exception("Sinh viên đã tồn tại, vui lòng cập nhật sinh viên!!");
                }
                if (txtStudentID.Text.Length != 10)
                {
                    throw new Exception("Mã số sinh viên phải có 10 ký tự");
                }
                student.StudentID = txtStudentID.Text;
                student.StudentName = txtStudentName.Text;
                student.FacultyID = (int)cbxFaculty.SelectedValue;
                float parseFloat = 0;
                bool successful = float.TryParse(txtAverageScore.Text, out parseFloat);
                
                if (successful)
                {
                    student.AverageScore = parseFloat;
                }
                else
                {
                    throw new Exception("Vui lòng nhập điểm hợp lệ");
                }
                if (parseFloat < 0 || parseFloat > 10)
                {
                    throw new Exception("Vui lòng nhập điểm từ 1 - 10");
                }
                studentContext.Students.Add(student);
                studentContext.SaveChanges();
                txtStudentID.Text = null;
                txtAverageScore.Text = null;
                txtStudentName.Text = null;
                cbxFaculty.SelectedIndex = 1;
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var studentUpdate = studentContext.Students.FirstOrDefault(x => x.StudentID == txtStudentID.Text);
                if (studentUpdate != null)
                {
                    studentUpdate.StudentName = txtStudentName.Text;
                    studentUpdate.FacultyID = (int)cbxFaculty.SelectedValue;
                    float parseFloat = 0;
                    bool successful = float.TryParse(txtAverageScore.Text, out parseFloat);
                    if (successful)
                    {
                        studentUpdate.AverageScore = parseFloat;
                    }
                    studentContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Vui lòng chọn đúng sinh viên để sửa!");
                }
                Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = dgvStudent.CurrentRow.Cells[0].Value.ToString();
            txtStudentName.Text = dgvStudent.CurrentRow.Cells[1].Value.ToString();
            txtAverageScore.Text = dgvStudent.CurrentRow.Cells[2].Value.ToString();
            cbxFaculty.Text = dgvStudent.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Student studentRemove = studentContext.Students.FirstOrDefault(p => p.StudentID == txtStudentID.Text);
            if (studentRemove != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá sinh viên này?", "Bạn chắc chứ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    studentContext.Students.Remove(studentRemove);
                    studentContext.SaveChanges();
                }
                Refresh();
            }
        }

        private void btnFacultyManager_Click(object sender, EventArgs e)
        {
            frmFaculty frmFaculty = new frmFaculty();
            frmFaculty.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }


        private void btnFacultyManager_Click_1(object sender, EventArgs e)
        {
            frmFaculty frmFaculty = new frmFaculty();
            frmFaculty.Show();
        }
        private void quảnLýIkhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaculty frmFaculty = new frmFaculty();
            frmFaculty.Show();
        }

        //private void btnSearch_Click1(object sender, EventArgs e)
        //{
        //    frmStudentSearch frmStudentSearch = new frmStudentSearch();
        //    frmStudentSearch.Show();
        //}

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            frmStudentSearch frmStudentSearch = new frmStudentSearch();
            frmStudentSearch.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentSearch frmStudentSearch = new frmStudentSearch();
            frmStudentSearch.Show();
        }
    }
}
