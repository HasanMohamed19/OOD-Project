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

        public int ContentId { get => contentId; set => contentId = value; }
        public string Filename { get => filename; set => filename = value; }
        public string Path { get => path; set => path = value; }
        public Course ForCourse { get => forCourse; set => forCourse = value; }
    }
}
