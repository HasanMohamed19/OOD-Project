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
    public partial class EditClassForm : Form
    {
        private ManageCourseForm manageCourse;
        private Class thisClass;
        public EditClassForm(int class_id, ManageCourseForm manageCourse)
        {
            thisClass = Class.GetClass(class_id);
            this.manageCourse = manageCourse;
            InitializeComponent();
            InitializeComboBoxes();
            UpdateView();
        }
        private void InitializeComboBoxes()
        {
            // update combo boxes
            comboDay.Items.AddRange(Enum.GetNames(typeof(WeekDays)));
        }
        private void UpdateView()
        {
            timeStart.Value = thisClass.StartTime;
            timeEnd.Value = thisClass.EndTime;
            txtBuilding.Text = thisClass.Building;
            txtRoom.Text = thisClass.RoomNumber;
            comboDay.SelectedIndex = comboDay.Items.IndexOf(thisClass.DayOfTheWeek.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            thisClass.StartTime = timeStart.Value;
            thisClass.EndTime = timeEnd.Value;
            thisClass.Building = txtBuilding.Text;
            thisClass.RoomNumber = txtRoom.Text;
            thisClass.DayOfTheWeek = (WeekDays)comboDay.SelectedIndex+1;

            Class.EditClass(thisClass);
            Close();
            manageCourse.PopulateDGVs();
        }
    }
}
