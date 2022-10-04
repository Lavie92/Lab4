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
        }

        private void frmFaculty_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var facultyUpdate = studentContext.Faculties.FirstOrDefault(x => x.FacultyID.ToString() == txtFacultyID.Text);
            if (facultyUpdate == null)
            {
                Faculty faculty = new Faculty();
                int parseInt = 0;
                bool successful = int.TryParse(txtFacultyID.Text, out parseInt); 
                if (successful)
                {
                    faculty.FacultyID = parseInt;
                }
                else
                {
                    throw new Exception("Mã khoa không hợp lệ!");
                }
                faculty.FacultyName = txtFacultyName.Text;
            }
        }
    }
}
