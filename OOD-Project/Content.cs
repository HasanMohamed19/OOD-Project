using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Content
    {
        private int contentId;
        private string filename;
        private string path;
        private Course forCourse;

        public Content(int contentId, string filename, string path, Course forCourse)
        {
            this.contentId = contentId;
            this.filename = filename;
            this.path = path;
            this.forCourse = forCourse;
        }

        public static void DeleteContent(int content_id)
        {
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();
            dbm.Command.Parameters.AddWithValue("@content_id", content_id);
            dbm.Command.CommandText = "DELETE FROM [dbo].[content] WHERE content_id = @content_id";
            try
            {
                dbm.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                dbm.Command.Parameters.Clear();
                dbm.Connection.Close();
            }
            // TODO: delete file from filesystem

        }
        public int ContentId { get => contentId; set => contentId = value; }
        public string Filename { get => filename; set => filename = value; }
        public string Path { get => path; set => path = value; }
        public Course ForCourse { get => forCourse; set => forCourse = value; }
    }
}
