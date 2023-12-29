using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD_Project.Helpers
{
    public class Helper
    {
        public static void OpenChildForm(Form childForm, Panel panel)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void GenerateGradeReport(int courseId, string path, DataGridView dgv)
        {
            List<string> lines = new List<string>();
            dgv.Columns.RemoveAt(dgv.Columns.Count-1); // remove last column
            DataGridViewColumnCollection column = dgv.Columns;
            bool firstDone = false;
            StringBuilder columnLine = new StringBuilder();
            foreach (DataGridViewColumn col in column)
            {
                if (!firstDone)
                {
                    columnLine.Append(col.DataPropertyName);
                    firstDone = true;
                }
                else
                {
                    columnLine.Append("," + col.DataPropertyName);
                }
            }
            lines.Add(columnLine.ToString());

            foreach (DataGridViewRow row in dgv.Rows)
            {
                StringBuilder dataLine = new StringBuilder();
                firstDone = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!firstDone)
                    {
                        dataLine.Append(cell.Value);
                        firstDone = true;
                    }
                    else
                    {
                        dataLine.Append("," + cell.Value);
                    }
                }
                lines.Add(dataLine.ToString());

            }
            File.WriteAllLines(path, lines);

        }
    }
}
