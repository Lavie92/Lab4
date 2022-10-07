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
    public partial class frmFaculty : Form
    {
        StudentContext studentContext = new StudentContext();
        public frmFaculty()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.dgvFaculty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var facultyUpdate = studentContext.Faculties.FirstOrDefault(x => x.FacultyID.ToString() == txtFacultyID.Text);
                if (facultyUpdate == null)
                {
                    Faculty faculty = new Faculty();
                    int parseInt = 0;
                    //bool successful = int.TryParse(txtFacultyID.Text, out parseInt); 
                    //if (successful)
                    //{
                    //    faculty.FacultyID = parseInt;
                    //}
                    //else
                    //{
                    //    throw new Exception("Mã khoa không hợp lệ!");
                    //}
                    if (txtTotalProfessor.Text == "")
                    {
                        faculty.TotalProfessor = 0;
                    }
                    else
                    {
                        bool successful = int.TryParse(txtTotalProfessor.Text, out parseInt);
                        if (successful)
                        {
                            faculty.TotalProfessor = parseInt;
                        }
                        else
                        {
                            throw new Exception("Tổng số giáo sư không hợp lệ!");
                        }
                    }
                    
                    faculty.FacultyName = txtFacultyName.Text;
                    studentContext.Faculties.Add(faculty);
                    studentContext.SaveChanges();
                }
                else
                {
                    int parseInt = 0;
                    facultyUpdate.FacultyName = txtFacultyName.Text;
                    if (txtTotalProfessor.Text == "")
                    {
                        facultyUpdate.TotalProfessor = 0;
                    }
                    else
                    {
                        bool successful = int.TryParse(txtTotalProfessor.Text, out parseInt);
                        if (successful)
                        {
                            facultyUpdate.TotalProfessor = parseInt;
                        }
                        else
                        {
                            throw new Exception("Tổng số giáo sư không hợp lệ!");
                        }
                    }
                    studentContext.SaveChanges();
                }
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void Refresh()
        {
            txtFacultyID.Text = "";
            txtFacultyName.Text = "";
            txtTotalProfessor.Text = "";
            dgvFaculty.DataSource = studentContext.Faculties.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng?", "Ảe you sủe?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFacultyID.Text = dgvFaculty.CurrentRow.Cells[0].Value.ToString();
            txtFacultyName.Text = dgvFaculty.CurrentRow.Cells[1].Value.ToString();
            //if (string.IsNullOrEmpty(dgvFaculty.CurrentRow.Cells[2].Value.ToString()))
            //{
            //    txtTotalProfessor.Text = "0";
            //}
            //else
            {
                txtTotalProfessor.Text = dgvFaculty.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var facultyRemove = studentContext.Faculties.FirstOrDefault(x => x.FacultyID.ToString() == txtFacultyID.Text);
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá khoa này?", "Ảe you sủe?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (facultyRemove != null)
                {
                    studentContext.Faculties.Remove(facultyRemove);
                    studentContext.SaveChanges();
                }
            }
            Refresh();
        }

    }
}
