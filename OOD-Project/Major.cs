using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOD_Project
{
    public enum Programme
    {
        ict = 1,
        business = 2,
        creativeMedia = 3,
        enginerring = 4,
        logistics = 5,
        foundation = 6
    }
    public class Major
    {
        private Programme forProgramme;
        private int majorId;
        private string name;

        public Major(Programme forProgramme, int majorId, string name)
        {
            this.forProgramme = forProgramme;
            this.majorId = majorId;
            this.name = name;
        }
        public Programme ForProgramme {  get { return forProgramme; } set {  forProgramme = value; } }
        public int MajorId { get {  return majorId; } set {  majorId = value; } }
        public string Name { get { return name; } set { name = value; } }


        public static List<Major> GetMajors()
        {
            List<Major> majors = new List<Major>();
            DatabaseManager dbm = DatabaseManager.Instance();
            dbm.Connection.Open();
            dbm.Command = dbm.Connection.CreateCommand();

            dbm.Command.CommandText = "SELECT * FROM [dbo].[major]";

            dbm.Reader = dbm.Command.ExecuteReader();
            while (dbm.Reader.Read())
            {
                int majorId = dbm.Reader.GetInt32(0);
                string majorName = dbm.Reader.GetString(1);
                Programme programme = (Programme)dbm.Reader.GetInt32(2);
                majors.Add(new Major(programme,majorId,majorName));
            }
            dbm.Connection.Close();
            return majors;
        }
    }
}
