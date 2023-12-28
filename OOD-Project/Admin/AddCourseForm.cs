using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.Admin
{
    public partial class AddCourseForm : Form
    {
        private ManageCourseForm manageCourse;
        public AddCourseForm(ManageCourseForm manageCourseForm)
        {
            InitializeComponent();
            this.manageCourse = manageCourseForm;
        }


        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            

        }
    }
}
