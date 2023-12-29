using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace OOD_Project.Admin
{
    public partial class AddClassForm : Form
    {
        private ManageCourseForm manageCourse;
        private Section section;
        public AddClassForm(int section_id, ManageCourseForm manageCourse)
        {
            this.manageCourse = manageCourse;
            section = Section.GetSection(section_id);
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // update combo boxes
            comboDay.Items.AddRange(Enum.GetNames(typeof(WeekDays)));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime start = timeStart.Value;
            DateTime end = timeEnd.Value;
            WeekDays day = (WeekDays)comboDay.SelectedIndex;
            string building = txtBuilding.Text;
            string room = txtRoom.Text;

            Class newClass = new Class(0, building, room, day, end, start, section);
            Class.AddClass(newClass);
            Close();
            manageCourse.PopulateDGVs(); // refresh parent
        }
    }
}
