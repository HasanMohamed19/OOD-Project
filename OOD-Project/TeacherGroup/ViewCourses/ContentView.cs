﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.TeacherGroup.ViewCourses
{
    public partial class ContentView : Form
    {
        int courseId;
        public ContentView(int courseId)
        {
            InitializeComponent();
            this.courseId = courseId;
        }
    }
}
